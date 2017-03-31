using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalyseurLINQ a=new AnalyseurLINQ();
            a.ChargerDonnées();

            a.AfficherStats();
            Console.ReadKey();


        }
    }
}
