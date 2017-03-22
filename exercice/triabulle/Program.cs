using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triabulle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mots = { "beta", "alpha", "gamma", "delta" };
            string[] mots2 = { "beta", "alpha", "gamma", "delta" };

            affichage(mots);

            /*mots2 =*/ TriABulle(mots);

            affichage(mots2);
            affichage(mots);

           
            Console.ReadKey();
        }
        static void affichage(string[] mots)
        {
            for (int i = 0; i < mots.Length; i++)
                Console.Write(mots[i] + " ");
            Console.Write("\n");
        }

        /*static string[] TriABulle(string[] mots)
        {
            string echange;
            string[] tableau = new string[mots.Length];

            for (int i = 0; i < mots.Length; i++)
                tableau[i] = mots[i];


            for (int i=0;i<mots.Length-1;i++)
            {
                if (tableau[i].CompareTo(tableau[i + 1]) == 1)
                {
                    echange = tableau[i];
                    tableau[i] = tableau[i + 1];
                    tableau[i + 1] = echange;
                    i -=2;
                    if (i == -2)
                        i=0;
                }
            }
            
            return tableau;
        }*/
        static void TriABulle(IComparable[] mots)
        {
            IComparable echange;
            // string[] tableau = new string[mots.Length];
            
            // for (int i = 0; i < mots.Length; i++)
            // tableau[i] = mots[i];


            for (int i = 0; i < mots.Length - 1; i++)
            {
                if (mots[i].CompareTo(mots[i + 1]) == 1)
                {
                    echange = mots[i];
                    mots[i] = mots[i + 1];
                    mots[i + 1] = echange;
                    i -=2;
                    if (i == -2)
                        i=0;
                }
            }

           // return mots;
        }
    }
}
