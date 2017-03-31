using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRoulette
{


    public class Mise
    {
        #region Constructeur
        public Mise(int? num, Combinaisons combinaison, int num2)
        {

        }
        #endregion


        #region Méthode publique
        public string GetResultatTexte()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Propriété en lecture
        public Lancé Pari { get; }
        public int Gain { get; }
        #endregion


        #region Propriété en lecture/écriture
        public int NbJetons { get; set; }
        public bool Gagnante { get; set; }
        #endregion
    }
}
