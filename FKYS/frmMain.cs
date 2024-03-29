using FKYS.Core.Enums;
using FKYS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKYS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {

            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void AddControl(Form f)
        {
            ControlPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlPanel.Controls.Add(f);
            f.Show();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Merhaba "+ MainClass.Kullanici.Ad +" "+ MainClass.Kullanici.Soyad;
            if(MainClass.Kullanici.KullaniciTurID == (int)KullaniciTurEnum.Admin)
            {
                lblBaslik.Text = "Film Kütüphanesi Yönetim Sistemi";
                btnProfil.Visible= false;
            }
            else
            {
                lblBaslik.Text = "Film Kütüphanesi";
            }
        }

        private void btnFilmler_Click(object sender, EventArgs e)
        {
            AddControl(new frmFilmler());

        }


        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfilView frm = new frmProfilView();
            frm.Show();
        }

        private void btn_Istatistikler_Click(object sender, EventArgs e)
        {
            AddControl(new frmIstatistikler());
        }
    }
}
