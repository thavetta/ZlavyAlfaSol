using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZlavyAlfa.Zlavy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZlavyAlfa.Zlavy.Tests
{
    [TestClass()]
    public class ZlavaDecoratorTests
    {
        [TestMethod()]
        public void InsertPocitacZliavTest()
        {
            var start = new ZakladCeny() { Poradie = 1, ZakladnaJednotkovaCenaBezDPH = 60M };
            var prvaZlava = new ZlavaPercentNormal() { Poradie = 200, ZlavaPercent = 0.1M };
            var druhaZlava = new ZlavaFixNormal() { Poradie = 100, ZlavaFix = 10M };
            var tretiaZlava = new ZlavaPercentNormal() { Poradie = 50, ZlavaPercent = 0.1M };

            ZlavyBase tester = start;
            tester = prvaZlava.InsertPocitacZliav(tester);
            tester = druhaZlava.InsertPocitacZliav(tester);
            tester = tretiaZlava.InsertPocitacZliav(tester);

            decimal expected = 39.6M;
            decimal vysledek = tester.VyslednaJednotkovaCenaBezDPH;

            Assert.AreEqual(expected,vysledek);
        }
    }
}