using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZlavyAlfa.Zlavy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var start = new ZakladCeny() { ZakladnaJednotkovaCenaBezDPH = 60M, TextUI = "Prvy tester"};
            var prvaZlava = new ZlavaPercentNormal() { Poradie = 200, ZlavaPercent = 0.05M, TextUI = "Zlava firemná 5 %"};
            var druhaZlava = new ZlavaFixNormal() { Poradie = 100, ZlavaFix = 10M, TextUI = "Zlava marketing 10 €"};
            var tretiaZlava = new ZlavaPercentNormal() { Poradie = 50, ZlavaPercent = 0.1M, TextUI = "Zlava vernostna 10 %"};

            ZlavyBase tester = start;
            tester = prvaZlava.InsertPocitacZliav(tester);
            tester = druhaZlava.InsertPocitacZliav(tester);
            tester = tretiaZlava.InsertPocitacZliav(tester);

            decimal expected = 41.8M;
            decimal vysledek = tester.VyslednaJednotkovaCenaBezDPH;

            Debug.WriteLine(tester);

            Assert.AreEqual(expected,vysledek);
        }
    }
}