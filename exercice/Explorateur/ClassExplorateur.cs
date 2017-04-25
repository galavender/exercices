using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorateur
{
    public delegate void DelegueExplorateur(FileInfo FI);

    public class Explorateur
    {
        public static void Explorer(string path, DelegueExplorateur explo)
        {
            var dir = new DirectoryInfo(path);

            if (dir.Exists)
            {
                foreach (var f in dir.EnumerateFiles("*", SearchOption.AllDirectories))
                {
                    explo(f);
                }
            }
            else
                throw new FileNotFoundException("Ce chemin n'existe pas");
        }
    }
}
