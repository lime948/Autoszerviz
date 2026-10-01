using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    internal abstract class Jarmu
    {
        public string Rendszam { get; set; }
        public int GyartasiEv { get; set; }
        public string Allapot { get; set; }

        public Jarmu(string rendszam, int gyartasiEv, string allapot)
        {
            Rendszam = rendszam;
            GyartasiEv = gyartasiEv;
            Allapot = allapot;
        }

        public virtual void SzervizVizsga() { }
    }
}
