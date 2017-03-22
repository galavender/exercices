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
            int n = int.Parse(valeurx);

            int i = 2, j, compt=0;
            bool est_premier;
          
            while (compt<n)
            {
                j = 2;
                est_premier = true;
                while((j < i)&&(est_premier))
                {
                    if(i%j==0) est_premier = false;
                    j++;
                }

                if(est_premier)
                {
                    Console.WriteLine(i);
                    compt++;
                }
                i++;               
            }
            Console.ReadKey();
        }
    }
}
