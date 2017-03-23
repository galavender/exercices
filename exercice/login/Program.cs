using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verif=false;
            while (!verif)
            {
                try
                {
                    Console.Write("Rentrer votre login : ");
                    string login = Console.ReadLine();
                    verif = verifLogin(login);

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            verif = false;
            while (!verif)
            {
                try
                {
                    Console.Write("Rentrer votre mot de passe : ");
                    string mdp = Console.ReadLine();
                    verif = verifMdp(mdp);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }

            }
            Console.ReadKey();

        }
        static bool verifLogin(string login)
        {
            if (login.Length > 4)
                return true;
            else
                throw new FormatException("Le login ne comporte pas assez de caractère (5 minimum)");
        }
        static bool verifMdp(string mdp)
        {
            if((mdp[0]==' ')||(mdp[mdp.Length-1]==' '))
                throw new FormatException("Le mot de passe ne doit pas commencer ni terminer par des espaces");
            if ((mdp.Length > 5) && (mdp.Length < 13))
                return true;
            else if(mdp.Length > 12)
                throw new FormatException("Le mot de passe comporte trop de caractère (6 minimum)");
            else
                throw new FormatException("Le mot de passe ne comporte pas assez de caractère (12 maximum)");
        }
    }
}
