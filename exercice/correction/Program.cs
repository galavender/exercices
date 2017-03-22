using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresPremier
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;


            while (true)
            {
                Console.Write("Combien de nombres premiers : ");
                n = Int32.Parse(System.Console.ReadLine()); //lecture du nombre est enregistrement dans n
                if(n==0)
                break;
                calculnombrepremier(n);

            }
                 Console.ReadKey();
        }
        static void calculnombrepremier(int nbpremier)
        {
            int divis, nbr, compt = 0;
            bool Est_premier;
            Console.WriteLine(2);
            nbr = 3;
            while (compt < nbpremier - 1)
            {
                divis = 2;
                Est_premier = true;
                do
                {
                    if (nbr % divis == 0) Est_premier = false;
                    else divis = divis + 1;
                }
                while ((divis <= nbr / 2) && (Est_premier == true));
                if (Est_premier)
                {
                    compt++;
                    System.Console.WriteLine(nbr);
                }
                nbr++;
            }
            
        }
    }
}
