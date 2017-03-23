using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadKey();
        }
        static void Demo()
        {

            string texte;
            string phrase;
            int nb_phrases=1, nb_mots=1;  //plusieurs entiers
            //const double PI = 3.14159236;
            const string Deb_liste = " - ";

            phrase = "le C# est un language moderne et puissant!\n";
            texte = phrase;
            texte = texte + " du blabla\n";
            texte += Deb_liste + "application console\n";
            texte += Deb_liste + "application fenetrée windows et wpf";
            //Console.WriteLine(texte);
            char lettre;
            lettre = phrase[3];
            //Console.WriteLine(lettre);
            short s = 2;
            s++;
            //Console.WriteLine(s);

            int[] tab = new int[3] { 3, 4, 40 }; // tableau 3 entiers
            /*tab[0]= 12;
            tab[1]= 2;
            tab[2]= 0;*/
            //Console.WriteLine(tab.Length);

            /*for(int i=0; i<tab.Length;i++)
            {
                if(tab[i]<5)
                {
                    Console.WriteLine(tab[i] + " est inférieur à 5");
                }
                else
                {
                    Console.WriteLine(tab[i] + " est supérieur ou égale a 5");
                }

            }*/
            int j=0;
            while(j<texte.Length)
            {
                if (texte[j]=='\n')
                {
                    nb_phrases++;
                    //Console.WriteLine(tab[j] + " est inférieur à 5");
                }

                if (texte[j] == ' ')
                {
                    nb_mots++;
                    //Console.WriteLine(tab[j] + " est inférieur à 5");
                }

                if (texte[j] == '-')
                {
                    nb_mots--;
                }

                /*else
                {
                    Console.WriteLine(tab[j] + " est supérieur ou égale a 5");
                }*/
                j++;
            }
            Console.WriteLine("il y a " + nb_phrases + " phrases et " + nb_mots + " mots dans le texte");

        }
    }
}
