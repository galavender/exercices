using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{

    public interface ICompteBancaire
    {

    }

    public abstract class Alerte : ICompteBancaire
    {
        protected ICompteBancaire compte;

        public Alerte(ICompteBancaire c)
        {
            compte = c;
        }

        public abstract void AlerterClient();
    }

    public class CompteBancaireAlertable : Alerte
    {
        public CompteBancaireAlertable(ICompteBancaire c) : base(c)
        {
            //Coucou
        }
        public override void AlerterClient()
        {
            Console.WriteLine("CLIENT ALERTE!!!");
        }
    }
}
