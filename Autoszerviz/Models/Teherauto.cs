using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    internal class Teherauto : Jarmu
    {
        public int Teherbiras { get; set; }

        public Teherauto(string rendszam, int gyartasiEv, string allapot, int teherbiras) : base(rendszam, gyartasiEv, allapot)
        {
            Teherbiras = teherbiras;
        }

        public override void SzervizVizsga()
        {
            Console.WriteLine($"Szervízvizsga elvégezve a {Rendszam} rendszámú, {GyartasiEv} gyártási évi teherautón, állapota: {Allapot}, teherbírása: {Teherbiras} kg");
        }
    }
}
