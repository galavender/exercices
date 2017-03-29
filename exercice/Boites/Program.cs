using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Boites b1 = new Boites(30, 40, 50);
            Etiquete et1 = new Etiquete { _couleur = couleurs.blanc, Format = Formats.L, Texte = "Dupont" };
            Etiquete et2 = new Etiquete { _couleur = couleurs.rouge, Format = Formats.S, Texte = "FRAGILE" };
            b1.Etiqueter(et1, et2);
            Console.ReadKey();
            
        }
    }
}
