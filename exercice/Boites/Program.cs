using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    enum couleur
    {
        blanc,
        bleu,
        vert,
        jaune,
        orange,
        rouge,
        marron
    }
    enum matiere
    {
        carton,
        plastique,
        bois,
        metal
    }
    class Boites
    {

        #region paramètre
        private double _hauteur = 30;
        private double _largeur = 30;
        private double _longueur = 30;
        private couleur _Couleur;
        private matiere _mat = matiere.carton;
        #endregion


        #region propriété
        public double hauteur
        {
            get { return _hauteur; }
        }
        public double largeur
        {
            get { return _largeur; }
        }
        public double longueur
        {
            get { return _longueur; }
        }
        public couleur CouLeur
        {
            get {return _Couleur; }
            set {_Couleur=value; }
        }
        public matiere MyProperty
        {
            get {return _mat; }
        }
        public double Volume
        {
            get {return (_longueur*_largeur*_hauteur); }
        }
        #endregion


        #region Methode
        public string Etiqueter(string destinataire)
        {
            throw new NotImplementedException();
        }
        public string Etiqueter(string destinataire, bool fragile)
        {
            throw new NotImplementedException();
        }


        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
