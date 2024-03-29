using FKYS.Core.Models;
using FKYS.Utils;
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
    public partial class frmFilmEkle : Form
    {

        public int FilmID { get; set; }

        private bool isUpdateForm = false;

        public event EventHandler filmSavedEvent = null;
        public frmFilmEkle()
        {
            InitializeComponent();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Resim Seçiniz";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                pBox_FilmAfis.Image = Image.FromFile(fileOpen.FileName);
            }
            fileOpen.Dispose();
        }

        private void BindComboBox()
        {
            string query = "Select * from FilmTur";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "FilmTur");

            //DataRow row = ds.Tables[0].NewRow();
            //row[0] = 0;
            //row[1] = "Hepsi";
            //ds.Tables[0].Rows.InsertAt(row, 0);

            cmbBoxTur.DataSource = ds.Tables["FilmTur"];
            cmbBoxTur.DisplayMember = "Tur";
            cmbBoxTur.ValueMember = "ID";



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            var ad = txtAd.Text;
            var yonetmen = txtYonetmen.Text;
            var yil = Convert.ToInt32(txtYil.Text);
            var aciklama = rTxtAciklama.Text;
            var turID = Convert.ToInt32(cmbBoxTur.SelectedValue);

            string message = "";
            string command = "";

            if (!isUpdateForm) {
                command = "INSERT INTO Film (Ad,Yonetmen,Yil,Aciklama,TurID,Resim) VALUES(@Ad,@Yonetmen,@Yil,@Aciklama,@TurID,@Resim)";
                message = "Film başarıyla eklendi.";
            }
            else
            {
                command = "UPDATE Film SET Ad = @Ad,Yonetmen=@Yonetmen,Yil=@Yil,Aciklama=@Aciklama,TurID=@TurID,Resim=@Resim WHERE ID="+FilmID;
                message = "Film başarıyla güncellendi.";

            }
            SqlCommand cmd = new SqlCommand(command, MainClass.con);

            MemoryStream stream = new MemoryStream();
            pBox_FilmAfis.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] resim = stream.ToArray();

            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Yonetmen", yonetmen);
            cmd.Parameters.AddWithValue("@Yil", yil);
            cmd.Parameters.AddWithValue("@Aciklama", aciklama);
            cmd.Parameters.AddWithValue("@TurID", turID);
            cmd.Parameters.AddWithValue("@Resim", resim);


            MainClass.con.Open();
            cmd.ExecuteNonQuery();
            MainClass.con.Close();


            Notify();

            this.Close();


            if (filmSavedEvent != null)
                filmSavedEvent(this, e);

            MessageBox.Show(message);

        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {
            BindComboBox();



            if(FilmID!=null && FilmID > 0)
            {
                isUpdateForm = true;
                filmDetail();
                btnKaydet.Text = "Güncelle";
                btnSil.Visible = true;
            }

        }

        private void Notify()
        {
            
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Yeni Film Eklendi";
            notifyIcon1.BalloonTipTitle = "Yeni Film Bildirimi";
            notifyIcon1.Text = "Yeni Film Eklendi";
            notifyIcon1.ShowBalloonTip(10000);

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Yeni Filmler Eklendi...");
            notifyIcon1.Visible = false;
        }


        private void filmDetail()
        {
            string query = "Select * from Film where ID=" + FilmID;
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Film film = dt.Rows[0].ToObject<Film>();
                Byte[] imageArray = (byte[])film.Resim;

                pBox_FilmAfis.Image = Image.FromStream(new MemoryStream(imageArray));
                txtAd.Text = film.Ad;
                txtYil.Text = film.Yil.ToString();
                txtYonetmen.Text = film.Yonetmen;
                rTxtAciklama.Text = film.Aciklama;
                cmbBoxTur.SelectedValue = film.TurID;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
 
                string command = @"Delete from Yorum where FilmID = " + FilmID +
    "Delete from Degerlendirme where FilmID = " + FilmID +
    "Delete from Film where ID=" + FilmID;
                SqlCommand cmd = new SqlCommand(command, MainClass.con);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();

                this.Close();

                if (filmSavedEvent != null)
                    filmSavedEvent(this, e);

                MessageBox.Show("Film başarıyla silindi.");



        }
    }
}
