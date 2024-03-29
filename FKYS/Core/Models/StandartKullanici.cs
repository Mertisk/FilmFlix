using FKYS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKYS.Core.Models
{
    class StandartKullanici : Kullanici, INormalKullanici, IStandartKullanici
    {
        public void FilmListele()
        {
            // todo: listeleme sonucu özel işlemler burada yapılcak
        }

        public double UyelikUcretHesapla()
        {
            return UyelikUcreti;
        }

        public void YorumYap()
        {
            // todo: yorumyap sonucu özel işlemler burada yapılcak
        }
    }
}
