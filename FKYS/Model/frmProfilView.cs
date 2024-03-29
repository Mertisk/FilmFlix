using FKYS.Core.Enums;
using FKYS.Core.Models;
using FKYS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FKYS.Model
{
    public partial class frmProfilView : Form
    {


        public frmProfilView()
        {
            InitializeComponent();
        }


        private void frmProfilView_Load(object sender, EventArgs e)
        {
            ControlDataBind();
            premiumHesapState();
        }


        private void ControlDataBind()
        {
            txtAd.Text = MainClass.Kullanici.Ad;
            txtSoyad.Text = MainClass.Kullanici.Soyad;
            dtDogumTarihi.Value = MainClass.Kullanici.DogumTarihi;
            txtTC.Text = MainClass.Kullanici.TcKimlikNo;
            

            var cinsiyetList = new List<ComboBoxClass>()
            {
                new ComboBoxClass() {ID=1,Name="Kadın"},
                new ComboBoxClass() {ID=2,Name="Erkek"},
            };
            cbCinsiyet.DataSource = cinsiyetList;
            cbCinsiyet.ValueMember = "Name";
            cbCinsiyet.DisplayMember= "Name";
            cbCinsiyet.SelectedValue = MainClass.Kullanici.Cinsiyet;


            var uyelikList = new List<ComboBoxClass>()
            {
                new ComboBoxClass() {ID=1,Name="Standart"},
                new ComboBoxClass() {ID=2,Name="Premium"},

            };
            txtUyelikTuru.Text = MainClass.Kullanici.UyelikTurID == (int)UyelikTurEnum.Premium ? UyelikTurEnum.Premium.ToString() : UyelikTurEnum.Standart.ToString();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ad = txtAd.Text;
            var soyad = txtSoyad.Text;
            var tc = txtTC.Text;
            var dogumTarihi = dtDogumTarihi.Value;
            var cinsiyet = cbCinsiyet.SelectedValue;


            string command = "UPDATE Kullanici SET Ad=@Ad,Soyad=@Soyad,TcKimlikNo=@TcKimlikNo,DogumTarihi=@DogumTarihi,Cinsiyet=@Cinsiyet WHERE ID=" + MainClass.Kullanici.ID;
            SqlCommand cmd = new SqlCommand(command, MainClass.con);

            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);
            cmd.Parameters.AddWithValue("@TcKimlikNo", tc);
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);

            MainClass.con.Open();
            cmd.ExecuteNonQuery();
            MainClass.con.Close();

            MessageBox.Show("Üyelik bilgileriniz başarıyla güncellenmiştir");



            MainClass.Kullanici = new Kullanici
            {
                Ad = ad,
                Soyad = soyad,
                Cinsiyet = cinsiyet.ToString(),
                DogumTarihi = dogumTarihi,
                TcKimlikNo = tc
            };
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            string command = "UPDATE Kullanici SET Aktif=0 WHERE ID="+MainClass.Kullanici.ID;
            SqlCommand cmd = new SqlCommand(command, MainClass.con);



            MainClass.con.Open();
            cmd.ExecuteNonQuery();
            MainClass.con.Close();


            MessageBox.Show("Hesabınız kapatılmıştır. Uygulamadan çıkış yapılıyor");

            Application.Exit();

        }

        private void btnPremiumOl_Click(object sender, EventArgs e)
        {


            var uyelikTurID = MainClass.Kullanici.UyelikTurID == (int)UyelikTurEnum.Premium ? (int)UyelikTurEnum.Standart : (int)UyelikTurEnum.Premium;

            if(uyelikTurID == (int)UyelikTurEnum.Premium)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Premium Üyelik ücreti " + MainClass.Kullanici.UyelikUcretHesapla() + " TL'dir.", "Uyarı", buttons);
                if (result == DialogResult.Yes)
                {

                }
                else
                {
                    return;
                }

            }


            string command = "UPDATE Kullanici SET UyelikTurID=@UyelikTurID WHERE ID=" + MainClass.Kullanici.ID;
            SqlCommand cmd = new SqlCommand(command, MainClass.con);

            MainClass.Kullanici.UyelikTurID = uyelikTurID;
            cmd.Parameters.AddWithValue("@UyelikTurID", MainClass.Kullanici.UyelikTurID);

            MainClass.con.Open();
            cmd.ExecuteNonQuery();
            MainClass.con.Close();


            premiumHesapState();
            ControlDataBind();



            MessageBox.Show("Üyelik bilgileriniz başarıyla güncellenmiştir");


        }

        private void premiumHesapState()
        {

            if(MainClass.Kullanici.UyelikTurID == (int)UyelikTurEnum.Premium)
            {
                btnPremiumOl.Text = "Premium iptal et";
                btnPremiumOl.BackColor= Color.DimGray;
                
            }
            else
            {
                btnPremiumOl.Text = "Premium Ol";
                btnPremiumOl.BackColor= Color.LightPink;
            }

        }
    }


    public class ComboBoxClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
