using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    internal class Motorkerekpar : Jarmu
    {
        public Motorkerekpar(string rendszam, int gyartasiEv, string allapot) : base(rendszam, gyartasiEv, allapot)
        {
        }

        public override void SzervizVizsga()
        {
            Console.WriteLine($"Szervízvizsga elvégezve a {Rendszam} rendszámú, {GyartasiEv} gyártási évi motorkerékpáron, állapota: {Allapot}");
        }
    }
}
