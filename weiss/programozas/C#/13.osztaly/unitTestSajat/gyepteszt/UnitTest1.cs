using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GyepKalkulatorNS;

namespace GyepKalkulatorTests
{
    [TestClass]
    public class GyepKalkulatorTests
    {
        [TestMethod]
        public void NormalEset_SikeresSzamitas()
        {
            GyepKalkulator kalkulator = new GyepKalkulator();
            kalkulator.GyepesitestSzamol(10);
            Assert.AreEqual(39.25, kalkulator.Gyepterulet, 0.01);
        }

        [TestMethod]
        public void NullaAtmero_NullaEredmeny()
        {
            GyepKalkulator kalkulator = new GyepKalkulator();
            kalkulator.GyepesitestSzamol(0);
            Assert.AreEqual(0, kalkulator.Gyepterulet);
        }

        [TestMethod]
        public void KicsiAtmero_KisTerulet()
        {
            GyepKalkulator kalkulator = new GyepKalkulator();
            kalkulator.GyepesitestSzamol(1);
            Assert.IsTrue(kalkulator.Gyepterulet > 0 && kalkulator.Gyepterulet < 1);
        }
    }
}