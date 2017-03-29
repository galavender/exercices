using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    public class Compte
    {

        #region champs privés
        // Field
        private bool _decouvert;
        private DateTime _cloture;
        private DateTime _creation;
        private decimal _solde;
        private decimal _decouvertAutorisé;
        #endregion


        #region Propriétés
        public bool ADecouvert
        {
            get { return _decouvert; }
        }

        public DateTime DateCloture
        {
            get { return _cloture; }
        }
        public decimal DécouvertAutorisé
        {
            get { return _decouvertAutorisé; }
            set { _decouvertAutorisé = value; }
        }

        public decimal SoldeCourant
        {
            get { return _solde; }
        }
        #endregion

   
        #region construteurs

        /// <summary>
        /// Constructeur sans paramètre
        /// </summary>
        public Compte()
        {        
            _creation = DateTime.Now;
            _solde = 0;
        }
        // Constructor that takes 1 arguments.
        public Compte(bool init_decouvert )
        {
            _decouvert = init_decouvert;
            _creation = DateTime.Now;
            _solde = 0;
        }

        // Constructor that takes 2 argument.
        public Compte(bool init_decouvert, decimal init_solde)
        {
            _decouvert = init_decouvert;
            _creation = DateTime.Now;
            _solde = init_solde;
        }
        #endregion


        #region Methode privée
        // Method
        private int CalculAncienneté()
        {
            return (DateTime.Now.Subtract(_creation)).Days;
        }

        private decimal CalculInteret()
        {
            return (_solde * 3 / 100);
            //Console.WriteLine("Les Interet seront de {0} euros", _solde*3/100);
        }

        private decimal CalculSolde()
        {
            return _solde;
            //Console.WriteLine("Le solde du compte est de {0} euros", _solde);
        }
        #endregion


        #region Methode publique
        public void ClotureCompte()
        {
            _cloture = DateTime.Today;
            _solde = 0;
        }

        public void Créditer(decimal credit)
        {
            _solde += credit;

            Console.WriteLine("Le nouveau solde est de {0} euros", _solde);
        }
        public void Débiter(decimal debit)
        {
            if(_solde-debit<_decouvertAutorisé)
            {
                _solde -= 5*debit/100;
            }

            _solde -= debit;
            if (_solde < 0)
                _decouvert = true;

            Console.WriteLine("Le nouveau solde est de {0} euros", _solde);
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            carte c = new carte {
                NumeroCarte = 11306843,
                NumeroCompte = 0364801,
                CodeSecret = 1201,
                DateExpiration = DateTime.Today.AddYears(2),
                CodeVerif = 36430 };

            DateTime dt = new DateTime(1996, 5, 12);
            Compte j = new Compte(true, 200);
            // j.CalculAncienneté();
            //j.CalculInteret();
            //j.CalculSolde();
            j.Créditer(150);
            j.Débiter(25);
            Console.ReadKey();
            bool b = j.ADecouvert;
        }
    }
    enum typecompte
    {
        Courant,
        Epargne,
        PEA,
        PEE
    }
}
