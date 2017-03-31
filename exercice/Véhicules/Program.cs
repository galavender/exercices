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
            /*Véhicules[] Tab = new Véhicules[4];
            Tab[0] = new Voiture("Bob", Energies.Aucune);         
            Tab[1] = new Moto("Marley", Energies.Aucune);
            Tab[2] = new Voiture("Bidule", Energies.Aucune);
            Tab[3] = new Moto("Chouette", Energies.Aucune);


            for (int i=0;i<Tab.Length;i++)
            {
                if (Tab[i] is Voiture)
                    Console.WriteLine("{0} pour {1}",((Voiture)Tab[i]).RefaireParallélisme(),Tab[i].Nom);

            }*/

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


            /*  Véhicules[] Tab = new Véhicules[4];
              Tab[0] = new Voiture("Mégane", 19000);
              Tab[1] = new Moto("Intruder", 13000);
              Tab[2] = new Voiture("Enzo", 380000);
              Tab[3] = new Moto("Yamaha", 11000);

              Dictionary<Véhicules, string> dico = new Dictionary<Véhicules, string>();

              foreach (Véhicules a in Tab)
              {
                  dico.Add(a, a.Nom);
              }

              foreach (Véhicules a in dico.Keys)
              {
                  Console.WriteLine("{0} : {1}", a.Nom, a.Prix);
              }
              SortedList<Véhicules, string> dico2 = new SortedList<Véhicules, string>();

              foreach (var a in dico)
              {
                  dico2.Add(a.Key, a.Value);
              }

              dico.Clear();
              foreach (Véhicules a in dico2.Keys)
              {
                  Console.WriteLine("{0} : {1}", a.Nom, a.Prix);
              }

              string[] ta = new string[5];*/


            /*
            Véhicules v1 = new Voiture("bob", Energies.Aucune);
            Véhicules v2 = new Moto("marley", Energies.Aucune);

            Console.WriteLine(v1.Description);
            Console.WriteLine(v2.Description);

            if (v1.CompareTo(v2) < 0)
                Console.WriteLine("{0} est plus économique que {1}", v1.Nom, v2.Nom);
            else if (v1.CompareTo(v2) == 0)
                Console.WriteLine("Les deux véhicules ont le même PRK");
            else
                Console.WriteLine("{0} est plus économique que {1}", v2.Nom, v1.Nom);*/



            Console.ReadKey();
            //Véhicules v3 = new Véhicules("nd", 5, Energies.Electrique);

        }
    }
}
