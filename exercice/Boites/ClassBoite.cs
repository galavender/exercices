using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    public enum couleurs
    {
        blanc,
        bleu,
        vert,
        jaune,
        orange,
        rouge,
        marron
    }
    public enum matieres
    {
        carton,
        plastique,
        bois,
        metal
    }
    public enum Formats
    {
        XS, S, M, L, XL
    }

    public class Boites
    {

        #region paramètre
        private double _hauteur;
        private double _largeur;
        private double _longueur;
        public static int NbBoite { get; private set; }
        private Etiquete _etiquetteDest { get; set; }
        private Etiquete _etiquetteFragile { get; set; }

        #endregion


        #region constructeur
        public Boites()
        {        
            NbBoite++;
        }
        public Boites(double hauteur, double longueur, double largeur):this()
        {
            _hauteur = hauteur;
            _largeur = largeur;
            _longueur = longueur;
        }
        public Boites(double hauteur, double longueur, double largeur, matieres matiere) : this(hauteur, longueur, largeur)
        {
            _matière = matiere;
        }
        #endregion


        #region propriété
        public double hauteur
        {
            get { return _hauteur; }
        }
        public int NbBoites { get {return NbBoite; } }
        public double largeur
        {
            get { return _largeur; }
        }
        public double longueur
        {
            get { return _longueur; }
        }
        public couleurs _couleur { get; set; }
        public matieres _matière { get; }

        public double Volume
        {
            get { return (_longueur * _largeur * _hauteur); }
        }
        #endregion


        #region Methode
        public void Etiqueter(string destinataire)
        {
            _etiquetteDest=new Etiquete { Format = Formats.L, Texte = destinataire, _couleur = couleurs.blanc };
           
            //throw new NotImplementedException();
        }
        public void Etiqueter(string destinataire, bool fragile)
        {
            if(fragile) _etiquetteFragile = new Etiquete { Format = Formats.S, Texte = "FRAGILE", _couleur = couleurs.rouge };
            
            Etiqueter(destinataire);
            //throw new NotImplementedException();
        }
        public void Etiqueter(Etiquete destinataire, Etiquete fragile)
        {
            _etiquetteFragile = fragile;
            _etiquetteDest = destinataire;
            //throw new NotImplementedException();

        }
        public bool Compare(Boites B)
        {
            return ((B._matière == this._matière) && (B._hauteur == this._hauteur) && (B._largeur == this._largeur) && (B._longueur == this._longueur));
        }
        #endregion
    }
    public class Etiquete
    {
        #region Champs en lecture ecriture
        public couleurs _couleur { get; set; }
        public Formats Format{ get; set; }
        public string Texte { get; set; }
        #endregion


    }
}
