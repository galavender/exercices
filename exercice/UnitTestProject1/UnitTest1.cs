using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boites;

namespace Boites
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Boites[] tab = new Boites[4];
            tab[0] = new Boites();
            tab[1] = new Boites();
            tab[2] = new Boites();
            tab[3] = new Boites();

            Assert.AreEqual(4, Boites.NbBoite);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Boites tab = new Boites(30,40,50);
            

            Assert.AreEqual(60000, tab.Volume);

        }


    }
}
