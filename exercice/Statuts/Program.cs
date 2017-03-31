using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> P = new List<Personne>();
            List<Personne> P2 = new List<Personne>();
            List<Personne> P3 = new List<Personne>();
            P.Add(new Personne("TURPIN", "Abel", Statuts.CDI));
            P.Add(new Personne("BONNEAU", "Achille", Statuts.CDD | Statuts.Délégué));
            P.Add(new Personne("BLONDEL", "Adelphe", Statuts.CDI | Statuts.Délégué | Statuts.MembreDuCHSCT | Statuts.ReprésentantSyndical));
            P.Add(new Personne("BLACK", "Aimé", Statuts.CDI));
            P.Add(new Personne("PERRIER", "Aimée", Statuts.CDI));
            P.Add(new Personne("JORDAN", "Alain", Statuts.CDD | Statuts.MembreDuCHSCT));
            P.Add(new Personne("BAUDRY", "Alban", Statuts.CDD));
            P.Add(new Personne("ORLEANS", "Albert", Statuts.CDI | Statuts.Délégué | Statuts.ReprésentantSyndical));
            P.Add(new Personne("VALOIS", "Alexandra", Statuts.CDI | Statuts.ReprésentantSyndical));
            P.Add(new Personne("WEST", "Alexandre", Statuts.CDI | Statuts.Délégué | Statuts.MembreDuCHSCT));

            foreach (Personne a in P)
            {
                if (((a.Statut & Statuts.CDD) == Statuts.CDD) && ((a.Statut & Statuts.MembreDuCHSCT) == Statuts.MembreDuCHSCT))
                    P2.Add(a);
                if (((a.Statut & Statuts.CDI) == Statuts.CDI) && ((a.Statut & Statuts.Délégué) == Statuts.Délégué))
                    P3.Add(a);
            }
            foreach (Personne a in P3)
            {
                //Console.WriteLine(a);
                a.Statut |= Statuts.MembreDuCHSCT;
            }
            foreach (Personne a in P3)
            {
                //Console.WriteLine(a);
               
            }

            foreach (Personne a in P)
            {
                if ((a.Statut & Statuts.CDI) == Statuts.CDI)
                    a.Statut ^= Statuts.CDI;
                Console.WriteLine(a);

            }



            Console.ReadKey();
        }
    }
}
