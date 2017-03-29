using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    public class carte
    {
        public long NumeroCarte { get; set; }
        public long NumeroCompte { get; set; }
        public DateTime DateExpiration{ get; set; }
        public int CodeVerif { get; set; }
        public int CodeSecret { get; set; }

    }
}
