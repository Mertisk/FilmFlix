using FKYS.Core.Enums;
using FKYS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKYS
{
    public partial class frmFilmler : Form
    {
        public frmFilmler()
        {
            InitializeComponent();


        }

        private void AddItems(string id, string name, Image pImage,string yil,string deger)
        {
           
            var w = new ucFilm
            {
                id = id,
                FilmName = name,
                FilmImage = pImage,
                Yil= yil,
                Deger = deger
            };

            filmPanel.Controls.Add(w);

            w.onSelect += W_onSelect;
        }

        private void W_onSelect(object? sender, EventArgs e)
        {
            
            if(MainClass.Kullanici.KullaniciTurID == (int)KullaniciTurEnum.Normal)
            {
                var wdg = (ucFilm)sender;
                frmFilmView frm = new frmFilmView();
                frm.filmID = Convert.ToInt32(wdg.id);
                frm.ShowDialog();
            }
            else if (MainClass.Kullanici.KullaniciTurID == (int)KullaniciTurEnum.Admin)
            {
                var wdg = (ucFilm)sender;
                frmFilmEkle frm = new frmFilmEkle();
                frm.filmSavedEvent += Frm_filmSavedEvent;
                frm.FilmID = Convert.ToInt32(wdg.id);
                frm.ShowDialog();
            }


        }

        public void LoadFilms(string? aranacakMetin)
        {
            filmPanel.Controls.Clear();

            string query = @";with a as(
            select AVG(d.Deger) as Deger,f.ID AS FilmID from Film as f
            full outer join Degerlendirme as d on d.FilmID = f.ID 
              group by f.ID,f.Ad

           )
           select t.ID, t.Resim,t.Ad,t.Yonetmen,t.Yil,tur.Tur,ISNULL(a.Deger,0) AS Deger
           from Film t
           inner join a on t.ID = a.FilmID
           inner join FilmTur as tur on tur.ID = t.TurID";


            if (aranacakMetin != "" && aranacakMetin != null)
            {
                query = @"
                ;with a as(
                            select AVG(d.Deger) as Deger,f.ID AS FilmID from Film as f
                            full outer join Degerlendirme as d on d.FilmID = f.ID 
                              group by f.ID,f.Ad

                           )
                           select t.ID, t.Resim,t.Ad,t.Yonetmen,t.Yil,tur.Tur,ISNULL(a.Deger,0) AS Deger
                           from Film t
                           inner join a on t.ID = a.FilmID
                           inner join FilmTur as tur on tur.ID = t.TurID
                        WHERE t.Ad LIKE '%" + aranacakMetin + "%' or t.Yonetmen LIKE '%" + aranacakMetin + "%' or tur.Tur LIKE '%" + aranacakMetin + "%' ";
            }

            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["Resim"];
                byte[] imageByteArray = imageArray;

                AddItems(item["ID"].ToString(), item["Ad"].ToString(), Image.FromStream(new MemoryStream(imageArray)), item["Yil"].ToString(), item["Deger"].ToString());

            }
        }

        private void BindComboBox()
        {
            string query = "Select * from FilmTur";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "FilmTur");

            DataRow row = ds.Tables[0].NewRow();
            row[0] = 0;
            row[1] = "Hepsi";
            ds.Tables[0].Rows.InsertAt(row, 0);

            //comboBox1.DataSource = ds.Tables["FilmTur"];
            //comboBox1.DisplayMember = "Tur";
            //comboBox1.ValueMember = "ID";



        }

        public void frmFilmler_Load(object sender, EventArgs e)
        {
            LoadFilms(null);

            if (MainClass.isAdmin())
            {
                btn_filmEkle.Visible = true;
            }
            else
            {
                btn_filmEkle.Visible = false;
            }



        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            LoadFilms(txt_filmAra.Text);
        }

        private void btn_filmEkle_Click(object sender, EventArgs e)
        {
            frmFilmEkle frm = new frmFilmEkle();
            frm.filmSavedEvent += Frm_filmSavedEvent;
            frm.Show();
        }

        private void Frm_filmSavedEvent(object? sender, EventArgs e)
        {
            LoadFilms(null);
        }
    }
}
