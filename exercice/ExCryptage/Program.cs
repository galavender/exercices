using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCryptage
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\cle.txt";
            try
            {
                List<char> L = new List<char>();
                List<char> L2 = new List<char>();

                if (!File.Exists(path))
                {
                    throw new Exception();
                }
                string s = string.Empty;
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        s = sr.ReadLine();
                        L.Add(s[0]);
                        L2.Add(s[2]);
                    }

                    Cryptage cry = new Cryptage();
                    cry.Avant = L;
                    cry.Aprés = L2;


                    sr.Close();
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

    }
    
}
