using FKYS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKYS.Core.Models
{
     class Kullanici:IKullanici
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public bool Aktif { get; set; }
        public int KullaniciTurID { get; set; }
        public int UyelikTurID { get; set; }
        public string TcKimlikNo { get; set; }

        public double UyelikUcreti = 100;
    }
}
