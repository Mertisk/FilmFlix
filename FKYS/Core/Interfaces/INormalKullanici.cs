﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKYS.Core.Interfaces
{
    internal interface INormalKullanici:IKullanici
    {
        void YorumYap();
        void FilmListele();
        double UyelikUcretHesapla();
    }
}