using FKYS.Core.Enums;
using FKYS.Core.Models;
using FKYS.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FKYS.Model
{
    public partial class frmFilmView : Form
    {
        public int filmID { get; set; }
        public frmFilmView()
        {
            InitializeComponent();
        }

        private void frmFilmView_Load(object sender, EventArgs e)
        {
            filmInfoLoad();
            filmYorumLoad();
            filmDegerlendirmeLoad();
            izlemeListesiButtonChange();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filmInfoLoad() 
        {
            string query = "Select * from Film where ID="+filmID;
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Film film = dt.Rows[0].ToObject<Film>();

                Byte[] imageArray = (byte[])film.Resim;

                pBox_FilmResim.Image = Image.FromStream(new MemoryStream(imageArray));
                lblFilmAd.Text = film.Ad;
                lblFilmYil.Text = film.Yil.ToString();
                lblFilmYonetmen.Text = film.Yonetmen;
                txtFilmAciklama.Text = film.Aciklama;

            }


        }

        private void filmDegerlendirmeLoad()
        {
            string query = "Select Avg(Deger) as Deger from Degerlendirme where FilmID=" + filmID;
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            if (dt.Rows.Count > 0 && dt.Rows[0]["Deger"] != DBNull.Value)
            {
                int deger = Convert.ToInt32(dt.Rows[0]["Deger"].ToString());
                lblFilmPuan.Text = deger.ToString();
                numericUpDown1.Value = deger;
            }
            else
            {
                int deger = 1;
                lblFilmPuan.Text = deger.ToString();
                numericUpDown1.Value = deger;
            }

        }

        private void filmYorumLoad()
        {
            string query = "Select * from Yorum where FilmID=" + filmID;
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            listBox2.DisplayMember = "YorumMetni";
            listBox2.ValueMember = "id";
            listBox2.DataSource = dt;

        }

        private bool izlemeListesindeMi()
        {
            var res = false; 
            string query = "Select * from IzlemeListesi where FilmID=" + filmID+ "and KullaniciID="+MainClass.Kullanici.ID;
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        private void izlemeListesiButtonChange()
        {
            if (izlemeListesindeMi())
            {
                btn_izlemeEkleCikar.Text = "izleme Listesinden Çıkar";
                btn_izlemeEkleCikar.BackColor = Color.LightPink;
            }
            else
            {
                btn_izlemeEkleCikar.Text = "izleme Listesine Ekle";
                btn_izlemeEkleCikar.BackColor = Color.LightGreen;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_izlemeEkleCikar_Click(object sender, EventArgs e)
        {
            string command = "";
            if (izlemeListesindeMi())
            {
                command = "DELETE FROM IzlemeListesi WHERE FilmID=" + filmID + " and KullaniciID=" + MainClass.Kullanici.ID;
            }
            else
            {
                command = "INSERT INTO IzlemeListesi (FilmID,KullaniciID) VALUES(" + filmID + "," + MainClass.Kullanici.ID + ")";
            }

            SqlCommand cmd = new SqlCommand(command, MainClass.con);

            try
            {
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                izlemeListesiButtonChange();
            }
            catch
            {

            }
        }

        private void btn_PuanKaydet_Click(object sender, EventArgs e)
        {

            if (MainClass.Kullanici.UyelikTurID == (int)UyelikTurEnum.Standart) {
                MessageBox.Show("Değerlendirme yapabilmeniz için Premium Üye olmanız gerekmektedir.");
                return; 
            }


            string query = "Select * from Degerlendirme where FilmID=" + filmID + "and KullaniciID=" + MainClass.Kullanici.ID;
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            string command = "";
            var puan = numericUpDown1.Value.ToString();
            
            if (dt.Rows.Count > 0)
            {
                command = "UPDATE Degerlendirme SET Deger="+puan+"  WHERE FilmID=" + filmID + " and KullaniciID=" + MainClass.Kullanici.ID;
            }
            else
            {
                command = "INSERT INTO Degerlendirme  (Deger,FilmID,KullaniciID) VALUES("+puan+","+filmID+","+MainClass.Kullanici.ID+")";
            }

            SqlCommand cmdi = new SqlCommand(command, MainClass.con);

            MainClass.con.Open();
            cmdi.ExecuteNonQuery();
            MainClass.con.Close();

            filmDegerlendirmeLoad();
        }

        private void btn_YorumYap_Click(object sender, EventArgs e)
        {
            string yorum = richTextBox1.Text;
            if (yorum == "")
                return;
 
            string command = "INSERT INTO Yorum (FilmID, YorumMetni, KullaniciID) VALUES(" + filmID + ",'"+ yorum +"'," + MainClass.Kullanici.ID + ")";


            SqlCommand cmdi = new SqlCommand(command, MainClass.con);

            MainClass.con.Open();
            cmdi.ExecuteNonQuery();
            MainClass.con.Close();
            
            filmYorumLoad();

            MessageBox.Show("Yorumunuz başarıyla kaydedildi");
            richTextBox1.Text = "";

        }
    }
}
