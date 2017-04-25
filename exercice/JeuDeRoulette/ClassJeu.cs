using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRoulette
{
    public class Jeu
    {
        #region Champ privées
        private int _nbJetons;
        private Roulette _roulette;
        #endregion


        #region constructeur
        public Jeu()
        {
            SaisirNbJetonInit();
        }
        #endregion


        #region Méthode publique
        public void Jouer()
        {
            do
            {
                Mise mise;
                SaisirMise(out mise);
                AfficherRésultat(_roulette.LancerBille(), mise);
            } while (SaisirContinuation());
            AfficherStats();
        }
        #endregion


        #region Méthode privées
        private void SaisirNbJetonInit()
        {
            Console.WriteLine("Combien de jetons voulez-vous acheter?");
            string valeurx = Console.ReadLine();
            _nbJetons = int.Parse(valeurx);
        }

        private void SaisirMise(out Mise mise)
        {
            Combinaisons combi = Combinaisons.Aucune;

            Console.WriteLine("Quelle combinaison choisissez-vous ?");
            Console.WriteLine("24p / 24d : 24 premiers ou derniers numéros");
            Console.WriteLine("r / n : Couleur rouge ou noire");
            Console.WriteLine("i / p : Numéro impair ou pair");
            Console.WriteLine("x : Un numéro précis");

            combi |= (Combinaisons)Enum.Parse(typeof(Combinaisons), Console.ReadLine());

            Console.WriteLine("Combien de jetons misez-vous ? (max : {0})",_nbJetons);
            int misejeton = int.Parse(Console.ReadLine());

            mise = new Mise(misejeton, combi, 2);


        }

        private void AfficherRésultat(Lancé lancé, Mise mise)
        {
            throw new NotImplementedException();
        }

        private bool SaisirContinuation()
        {
            throw new NotImplementedException();
        }

        private void AfficherStats()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
