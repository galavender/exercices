using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stat
{
    [Flags]
    public enum Statuts
    {
        Aucun=0,
        CDI=1,
        CDD=2,
        Délégué=4,
        MembreDuCHSCT=8,
        ReprésentantSyndical=16

    }
    public class Personne
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public Statuts Statut { get; set; }

        public Personne(string nom, string prenom, Statuts statut)
        {
            Nom = nom;
            Prenom = prenom;
            Statut = statut;
        }

        public override string ToString()
        {
            //string s = 
                
                return string.Format("{0}, {1}, {2}",Nom, Prenom, Statut);
            /*if ((Statut & Statuts.CDI) == Statuts.CDI)
                s += string.Format(", en CDI");
            if ((Statut & Statuts.CDD) == Statuts.CDD)
                s += string.Format(", en CDD");
            if ((Statut & Statuts.Délégué) == Statuts.Délégué)
                s += string.Format(", délégué du personnel");
            if ((Statut & Statuts.MembreDuCHSCT) == Statuts.MembreDuCHSCT)
                s += string.Format(", membre du CHSCT");
            if ((Statut & Statuts.ReprésentantSyndical) == Statuts.ReprésentantSyndical)
                s += string.Format(", représentant syndical");
            return s;*/
        }

    }
}
