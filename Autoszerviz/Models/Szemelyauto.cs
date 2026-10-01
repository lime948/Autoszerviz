using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    internal class Szemelyauto : Jarmu
    {
        public int AjtokSzama { get; set; }
        public Szemelyauto(string rendszam, int gyartasiEv, string allapot, int ajtokSzama) : base(rendszam, gyartasiEv, allapot)
        {
            AjtokSzama = ajtokSzama;
        }

        public override void SzervizVizsga()
        {
            Console.WriteLine($"Szervízvizsga elvégezve a {Rendszam} rendszámú, {GyartasiEv} gyártási évi személyautón, állapota: {Allapot}");
        }
    }
}
