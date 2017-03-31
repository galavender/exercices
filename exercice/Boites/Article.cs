using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    public class Article : IComparable
    {
        public int ID { get; }
        public string Libellé { get; set; }
        public double Poids { get; set; }


        public Article(int id, string libellé, double poids)
        {
            ID = id;
            Libellé = libellé;
            Poids = poids;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}g", ID, Libellé, Poids);
        }

        public int CompareTo(object obj)
        {
            if (obj is Article)
            {
              return ID.CompareTo(((Article)obj).ID);
                  
            }
            else
                throw new NotImplementedException();
        }
    }
}
