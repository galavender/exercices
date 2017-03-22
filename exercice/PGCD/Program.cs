using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("entrer un nombre\n");
            string valeurx = Console.ReadLine();
            int x = int.Parse(valeurx);
            Console.WriteLine("\nentrer un deuxième nombre\n");
            string valeury = Console.ReadLine();
            int y = int.Parse(valeury);

            Console.WriteLine("\n" + x + "\n" + y);

            while (x != y)
            {
                if(x>y)
                {
                    x -= y;
                }
                else
                {
                    y -= x;
                }
            }
            Console.WriteLine("\nPGCD = " + x);
            Console.ReadKey();

        }
    }
}
