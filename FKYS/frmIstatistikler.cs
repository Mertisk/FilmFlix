using FKYS.Core.Models;
using FKYS.Model;
using FKYS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKYS
{
    public partial class frmIstatistikler : Form
    {
        public frmIstatistikler()
        {
            InitializeComponent();
        }

        private void frmIstatistikler_Load(object sender, EventArgs e)
        {

            EnCokDegerlendirilenler();

            PuaniEnYuksekOlanlar();

        }





        private void EnCokDegerlendirilenler() {
            string query = @"  ;with a as(
                          select AVG(d.Deger) as Deger,d.FilmID from Film as f
                          inner join Degerlendirme as d on d.FilmID = f.ID
                            group by d.FilmID,f.Ad

	                        )
	                        select t.ID,t.Resim,t.Ad,t.Yonetmen,t.Yil,tur.Tur,a.Deger
	                        from Film t
	                        inner join a on t.ID = a.FilmID
	                        inner join FilmTur as tur on tur.ID = t.ID";

            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
       


        }
        private void PuaniEnYuksekOlanlar() {

            string query = @"  ;with a as(
  
                          select COUNT(d.KullaniciID) as Deger,d.FilmID from Film as f
                          inner join Degerlendirme as d on d.FilmID = f.ID
                            group by d.FilmID,f.Ad

	                        )
	                        select t.ID,t.Resim,t.Ad,t.Yonetmen,t.Yil,tur.Tur,a.Deger
	                        from Film t
	                        inner join a on t.ID = a.FilmID
	                        inner join FilmTur as tur on tur.ID = t.ID";

            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);


            dataGridView2.DataSource = dt;


        }


    }
}
