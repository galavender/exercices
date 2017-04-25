using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorateur
{
    class Program
    {
        static void Main(string[] args)
        {
            bool recommence = true;

            while (recommence)
            {
                while (recommence)
                {
                    try
                    {
                        Console.WriteLine("Saisissez le chemin du dossier à explorer :");
                        string s = Console.ReadLine();
                        Analiseur.AnalyserDossier(s);
                        recommence = false;
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Entrer le chemin AVANT d'appuyé sur entrée");
                    }
                } 
                Console.WriteLine("{0} fichiers, dont {1} fichier .cs", Analiseur.NbFichiers, Analiseur.NbFichiersCS);
                Console.WriteLine("Nom du fichier le plus court : {0}\nNom du fichier le plus long : {1}", Analiseur.NomCourt, Analiseur.NomLong);
                Console.WriteLine("\nFichiers projet C# : ");

                foreach (var f in Analiseur.ListeFichierC)
                {
                    Console.WriteLine("{0}", f);
                }
                Console.WriteLine("Voulez-vous analyser d'autres dossiers? oui/non");
                if (Console.ReadLine() != "non")
                    recommence = true;

            }
            Console.ReadKey();
        }
    }
}
