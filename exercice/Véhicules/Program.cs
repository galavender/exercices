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
          
            Véhicules[] Tab = new Véhicules[4];
            Tab[0] = new Voiture("Mégane", 19000);
            Tab[1] = new Moto("Intruder", 13000);
            Tab[2] = new Voiture("Enzo", 380000);
            Tab[3] = new Moto("Yamaha", 11000);

            Dictionary<string, Véhicules> dico = new Dictionary<string, Véhicules>();

            foreach (Véhicules a in Tab)
            {
                dico.Add(a.Nom, a);
            }

            foreach (Véhicules a in dico.Values)
            {
                Console.WriteLine("{0} : {1}",a.Nom,a.Prix);
            }
            SortedList<string, Véhicules> dico2 = new SortedList<string, Véhicules>();

            foreach (var a in dico)
            {
                dico2.Add(a.Key, a.Value);
            }

            dico.Clear();
            foreach (Véhicules a in dico2.Values)
            {
                Console.WriteLine("{0} : {1}", a.Nom, a.Prix);
            }

            string[] ta = new string[5];
            ta[0] = "Clio";
            ta[1] = "Mégane";
            ta[2] = "Golf";
            ta[3] = "Enzo";
            ta[4] = "Polo";
            
            foreach (var a in ta)
            {
                if (dico2.TryGetValue(a, out Tab[0]))
                    Console.WriteLine("{0} : {1}", Tab[0].Nom, Tab[0].Prix);

            }

            DelegueEntretien entretien = null;
            entretien += ChangerPneus;
            entretien += RetoucherPeinture;
            Tab[1].Entretenir(DateTime.Today, entretien);

            entretien += Vidanger;
            Tab[1].Entretenir(DateTime.Today, entretien);

            Console.WriteLine(Tab[1].CarnetEntretien[DateTime.Today]);

            Console.ReadKey();

        }

        static string ChangerPneus(Véhicules v)
        {
            return string.Format("{0} roues changer\n", v.NbRoues);
        }

        static string Vidanger(Véhicules v)
        {
            return string.Format("Vidange effectuée\n");
        }
        static string RetoucherPeinture(Véhicules v)
        {
            return string.Format("Peinture refaite\n", v.NbRoues);
        }






    }
}
