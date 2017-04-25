using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorateur
{
    public static class Analiseur
    {


        public static int NbFichiers { get; private set; }
        public static int NbFichiersCS { get; private set; }
        public static string NomCourt { get; private set; }
        public static string NomLong { get; private set; }
        public static List<String> ListeFichierC { get; } = new List<string>();


        public static void AnalyserDossier(string path)
        {


            NbFichiers = 0;
            NbFichiersCS = 0;
            NomCourt = "ffffffffffffffffffffff";
            NomLong = string.Empty;
            ListeFichierC.Clear();


            DelegueExplorateur explo = null;
            explo += CompterFichiers;
            explo += AnalyserNom;
            explo += FiltrerProjet;


            Explorateur.Explorer(path, explo);
        }
        public static void CompterFichiers(FileInfo FI)
        {
            NbFichiers++;
            if (FI.Extension.ToLower() == ".cs")
                NbFichiersCS++;
        }
        public static void AnalyserNom(FileInfo FI)
        {
            if (FI.Name.Length < NomCourt.Length)
                NomCourt = FI.Name;
            if (FI.Name.Length > NomLong.Length)
                NomLong = FI.Name;
        }

        public static void FiltrerProjet(FileInfo FI)
        {
            if (FI.Extension.ToLower() == ".csproj")  
                ListeFichierC.Add(Path.GetFileNameWithoutExtension(FI.Name));
            
        }


    }



}
