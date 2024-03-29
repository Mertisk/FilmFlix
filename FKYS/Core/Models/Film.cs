using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKYS.Core.Models
{
    internal class Film
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Yonetmen { get; set; }
        public int Yil { get; set; }
        public byte[] Resim { get; set; }
        public string Aciklama { get; set; }
        public int TurID { get; set; }
    }
}
