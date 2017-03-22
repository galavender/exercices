using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre_entier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Combien de nombre premier : ");
            string valeurx = Console.ReadLine();
            int x = int.Parse(valeurx);
            int i = 3, j, k=1;
            bool est_premier;
            Console.WriteLine("\n2");
            while (k<x)
            {
                j = 2;
                est_premier = true;
                while(j < i)
                {
                    if(i%j==0)
                    {
                        est_premier = false;
                    }
                    j++;
                }

                if(est_premier)
                {
                    Console.WriteLine(i);
                    k++;
                }
                i++;
               
            }
            Console.ReadKey();
        }
    }
}
