using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Linq
{
    public class AnalyseurLINQ
    {
        private List<DonnéesMois> _data;
        public List<DonnéesMois> Data
        {
            get { return _data; }
        }

        public AnalyseurLINQ()
        {
            _data = new List<DonnéesMois>();
        }

        public void ChargerDonnées()
        {
            string chemin = @"..\..\DonnéesMétéoParis.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))
            {
                string ligne;

                while ((ligne = str.ReadLine()) != null)
                {
                    cpt++;
                    if (cpt == 1) continue; // On n'analyse pas la première ligne car elle contient les en-têtes

                    var tab = ligne.Split('\t');
                    try
                    {
                        var donnéesMois = new DonnéesMois
                        {
                            Mois = DateTime.Parse(tab[0]),
                            TMin = double.Parse(tab[1]),
                            TMax = double.Parse(tab[2]),
                            Précipitations = double.Parse(tab[3]),
                            Ensoleillement = double.Parse(tab[4])
                        };

                        // Ajout des données du mois à la liste
                        Data.Add(donnéesMois);
                    }
                    catch (FormatException)
                    {
                        // On ignore simplement la ligne
                        Console.WriteLine("Erreur de format à la ligne suivante :\r\n{0}", ligne);
                    }
                }
            }
        }

        public void AfficherStats()
        {
            // mois de la température min la plus basse (méthode 1 : affiche seulement le premier)
            var date = Data.OrderBy(a => a.TMin).First();
            Console.WriteLine("La température minimum était de {0}°C au mois de {1:d}", date.TMin, date.Mois);


            // mois de la température min la plus basse (méthode 1 : affiche tous les mois avec la température minimal)
            var res = Data.Where(m => m.TMin == Data.Min(t => t.TMin));

            foreach (var a in res)
            {
                Console.WriteLine("La température minimum était de {0} au mois de {1:d}", a.TMin, a.Mois);
            }

           
            // Sommes des précipitations de l'année 2016
            var somme = Data.Where(b => b.Mois.Year == 2016).Sum(a => a.Précipitations);
            Console.WriteLine("Le total des précipitations est de {0}", somme);

            // Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années
            var duré = Data.Where(a => a.Mois.Month == 07).Average(b => b.Ensoleillement);
            Console.WriteLine("La durée moyenne d'ensoleillement au mois de juillet est de {0}", duré);

            // Précipitations moyennes par année
            var annee = Data.Select(n => n.Mois.Year).Distinct();


            foreach (var a in annee)            
            {
                var pre = Data.Where(b => b.Mois.Year == a).Average(c => c.Précipitations);
                Console.WriteLine("La précipitation moyenne de l'année {0} est de {1}", a, pre);
            }
        }
    }

    /// <summary>
    /// Classe contenant les données d'un mois de relevé météo
    /// </summary>
    public class DonnéesMois
    {
        public DateTime Mois { get; set; }
        public double TMin { get; set; }
        public double TMax { get; set; }
        public double Précipitations { get; set; }
        public double Ensoleillement { get; set; }
    }
}
