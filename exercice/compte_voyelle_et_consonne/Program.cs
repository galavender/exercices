using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_voyelle_et_consonne
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb_voy, nb_con;
            Console.WriteLine("Entrer un mot");
            string mot=Console.ReadLine();
            comptage(mot, out nb_voy, out nb_con);
            mot = mot.ToUpper();
            Console.WriteLine("{0} comprend {1} consonnes et {2} voyelles", mot, nb_con, nb_voy);
            Console.ReadKey();
        }

        static void comptage(string mot, out int nb_voy, out int nb_con)
        {
            mot = mot.ToLower();
            nb_con = 0;
            nb_voy = 0;
            for(int i=0;i<mot.Length;i++)
            {
                if(mot[i]== 'a' || mot[i] == 'e' || mot[i] == 'y' || mot[i] == 'u' || mot[i] == 'i' || mot[i] == 'o')
                {
                    nb_voy++;
                }
               
            }
            nb_con = mot.Length - nb_voy;
            //mot=mot.ToUpper();
        }
    }
}
