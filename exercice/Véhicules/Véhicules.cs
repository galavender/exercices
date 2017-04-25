using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public enum Energies
    {
        Aucune, Essence, Gazole, GPL, Electrique
    }

    public abstract class Véhicules : IComparable
    {
        public decimal Prix { get; set; }
        public string Nom { get; }
        public int NbRoues { get; }
        public Energies  Energie{ get; }
        public abstract decimal PRK { get; }
        public Dictionary<DateTime, string> CarnetEntretien { get; }

        public Véhicules(String nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
            CarnetEntretien = new Dictionary<DateTime, string>();
        }
        public Véhicules(String nom, decimal prix)
        {
            Nom = nom;
            Prix = prix;
            NbRoues = 0;
            CarnetEntretien = new Dictionary<DateTime, string>();
        }

        public virtual string Description
        {
            get
            {
                return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie);
            }
        }
        public abstract void CalculerConso();

        //public abstract int CompareTo(object obj);
        public  int CompareTo(object obj)
        {
            if (obj is Véhicules)
                return Prix.CompareTo(((Véhicules)obj).Prix);
            else
                throw new ArgumentException();
        }

        public void Entretenir(DateTime date, DelegueEntretien entretien )
        {
            if (!CarnetEntretien.ContainsKey(date))
                CarnetEntretien.Add(date, string.Empty);
            CarnetEntretien[date] += entretien(this);
        }
    }

    public class Voiture : Véhicules
    {
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {
        }
        public Voiture(string nom, decimal prix) : base(nom, prix)
        {
        }
        public override string Description
        {
            get
            {
                return "Je suis une Voiture \r\n" + base.Description;
            }
        }

        public string RefaireParallélisme()
        {
            return string.Format("Parallélisme refait");
        }

        public override decimal PRK
        {
            get
            {
                return 5;
            }
        }

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }
       
    }

    public class Moto : Véhicules
    {
        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {
        }
        public Moto(string nom, decimal prix) : base(nom, prix) { }
        public override string Description
        {
            get
            {
                return "Je suis une Moto \r\n" + base.Description;
            }
        }

        public override decimal PRK
        {
            get
            {
                return 4;
            }
        }

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }
    }


    public delegate string DelegueEntretien(Véhicules v);
}
