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
                    verifLogin(login);
                    verif = true;
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
                    verifMdp(mdp);
                    verif = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }

            }
            Console.ReadKey();
            

        }
        static void verifLogin(string login)
        {
            if (login.Length <5)
                throw new FormatException("Le login ne comporte pas assez de caractère (5 minimum)");
        }
        static void verifMdp(string mdp)
        {
            if((mdp[0]==' ')||(mdp[mdp.Length-1]==' '))
                throw new FormatException("Le mot de passe ne doit pas commencer ni terminer par des espaces");
            if (mdp.Length > 12)
                throw new FormatException("Le mot de passe comporte trop de caractères (entre 6 et 12 caractères)");
            else if(mdp.Length <6)
                throw new FormatException("Le mot de passe ne comporte pas assez de caractères (entre 6 et 12 caractères)");
        }
    }
}
