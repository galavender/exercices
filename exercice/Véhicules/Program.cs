using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicules v1 = new Voiture("bob", Energies.Aucune);
            Véhicules v2 = new Moto("marley", Energies.Aucune);

            Console.WriteLine(v1.Description);
            Console.WriteLine(v2.Description);
            Console.ReadKey();
        }
    }
}
