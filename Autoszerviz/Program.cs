using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autoszerviz.Models;

namespace Autoszerviz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jarmu> jarmuvek = new List<Jarmu>
            {
                new Szemelyauto("ABC-123", 2015, "Javításra vár", 4),
                new Teherauto("DEF-456", 2010, "Javításra alatt", 2000),
                new Motorkerekpar("GHI-789", 2020, "Kész")
            };
            foreach (var jarmu in jarmuvek)
            {
                jarmu.SzervizVizsga();
            }
        }
    }
}
