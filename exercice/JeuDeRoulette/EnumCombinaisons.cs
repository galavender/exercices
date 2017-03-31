using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRoulette
{
    [Flags]
    public enum Combinaisons
    {
        Aucune=0, Premiers24=1, Dernier24=2, Rouge=4, Noir=8, Impair=16, Pair=32
    }
}
