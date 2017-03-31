using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{

    class Program
    {
        static void Main(string[] args)
        {
            Boites b1 = new Boites(30, 40, 50);
            Etiquete et1 = new Etiquete { _couleur = couleurs.blanc, Format = Formats.L, Texte = "Dupont" };
            Etiquete et2 = new Etiquete { _couleur = couleurs.rouge, Format = Formats.S, Texte = "FRAGILE" };
            b1.Etiqueter(et1, et2);
            var a1 = new Article(1, "Article 1", 502);
            var a2 = new Article(2, "Article 2", 627);
            var a3 = new Article(3, "Article 3", 72);

            b1.Articles.Add(a1.ID,a1);
            b1.Articles.Add(a2.ID, a2);
            b1.Articles.Add(a3.ID, a3);

            for (int i = 0; i < b1.Articles.Count; i++)
            {
                //Console.WriteLine(b1.Articles[i]);
                if (b1.Articles[i] is Article)
                {
                    b1.Articles[i].Libellé = string.Format("Article {0}", i + 4);
                    Console.WriteLine(b1.Articles[i]);
                }
            }

            foreach (var a in b1.Articles)
            {
                Console.WriteLine("{0}, {1}",a.Value, a.Key);
            }

            Console.ReadKey();

        }
    }
}
