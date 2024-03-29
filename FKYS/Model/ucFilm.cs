using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKYS.Model
{
    
    public partial class ucFilm : UserControl
    {

        public ucFilm()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public string id { get; set; }
        public string Puan { get; set; }
        public string Yil { get; set; }
        public string Deger
        {
            get { return lblPuan.Text; }
            set { lblPuan.Text = "(10/"+value+")"; }
        }
        public string FilmName 
        {
            get { return lblFilmName.Text; } 
            set { lblFilmName.Text = value; } 
        }

        public Image FilmImage
        {
            get { return pBox_FilmImage.Image; }
            set { pBox_FilmImage.Image = value; }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            onSelect.Invoke(this, e);
        }

        private void ucFilm_Click(object sender, EventArgs e)
        {
            
        }

        private void pBox_FilmImage_Click(object sender, EventArgs e)
        {
            onSelect.Invoke(this, e);
        }
    }
}
