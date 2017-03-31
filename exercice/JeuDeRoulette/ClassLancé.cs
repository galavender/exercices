using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRoulette
{
    public class Lancé
    {
        #region Constructeur
        public Lancé(int? num, Combinaisons combinaison)
        {

        }
        #endregion


        #region Méthode Publique
        public bool CorrespondA(Lancé lancé)
        {
            throw new NotImplementedException();
        }

        public string CorrespondA()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Propriété en lecture
        public int? Numéro { get; }
        public Combinaisons Combinaison { get; }
        #endregion
    }
}
