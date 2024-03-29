using FKYS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKYS.Core.Models
{
    class PremiumKullanici : Kullanici, INormalKullanici ,IPremiumKullanici
    {
        public void Degerlendir()
        {
            // todo: değerlendirme sonucu özel işlemler burada yapılcak
        }

        public void FilmListele()
        {
            // todo: listeleme sonucu özel işlemler burada yapılcak
        }

        public double UyelikUcretHesapla()
        {
            return (UyelikUcreti + UyelikUcreti * 0.25);
        }

        public void YorumYap()
        {
            // todo: yorumyap sonucu özel işlemler burada yapılcak
        }
    }
}

// inheritence
// polimorfizm 
// encapsilation
