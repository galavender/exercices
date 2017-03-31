using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCryptage
{
    public class Cryptage
    {
        public List<char> Avant { get; set; }
        public List<char> Aprés { get; set; }

        public string crypter(string texte)
        {
            string s = string.Empty;
            cry.Avant = L;
            char[] c = texte.ToCharArray();
            for (int i=0;i<c.Length;i++)
            {
                Avant.FindIndex(c[i]);
            }
        }
    }
}
