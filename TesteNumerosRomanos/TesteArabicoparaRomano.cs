using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace TesteNumerosRomanos
{
    [TestClass]
    public class TesteArabicoparaRomano
    {
        [TestMethod]
        public void DeveRetornarI()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(1);
            Assert.AreEqual("I", teste.ObterUnidadeRomano());
        }
        [TestMethod]
        public void DeveRetornarII()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(2);
            Assert.AreEqual("II", teste.ObterUnidadeRomano());
        }
        [TestMethod]
        public void DeveRetornarIII()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(3);
            Assert.AreEqual("III", teste.ObterUnidadeRomano());
        }
        [TestMethod]
        public void DeveRetornarV()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(5);
            Assert.AreEqual("V", teste.ObterUnidadeRomano());
        }
        [TestMethod]
        public void DeveRetornarX()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(10);
            Assert.AreEqual("X", teste.ObterDezenaRomano());
        }
        [TestMethod]
        public void DeveRetornarL()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(50);
            Assert.AreEqual("L", teste.ObterDezenaRomano());
        }
        [TestMethod]
        public void DeveRetornaC()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(100);
            Assert.AreEqual("C", teste.ObterCentenaRomano());
        }
        [TestMethod]
        public void DeveRetornaM()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(1000);
            Assert.AreEqual("M", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaXXX()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(30);
            Assert.AreEqual("XXX", teste.ObterDezenaRomano());
        }
        [TestMethod]
        public void DeveRetornaCCC()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(300);
            Assert.AreEqual("CCC", teste.ObterCentenaRomano());
        }
        [TestMethod]
        public void DeveRetornaMMM()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(3000);
            Assert.AreEqual("MMM", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaĪV̄()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(4000);
            Assert.AreEqual("ĪV̄", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaV̄()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(5000);
            Assert.AreEqual("V̄", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaV̄Ī()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(6000);
            Assert.AreEqual("V̄Ī", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaV̄ĪĪ()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(7000);
            Assert.AreEqual("V̄ĪĪ", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaV̄ĪĪĪ()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(8000);
            Assert.AreEqual("V̄ĪĪĪ", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaĪX̄()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(9000);
            Assert.AreEqual("ĪX̄", teste.ObterUnidadeDeMilharRomano());
        }
        [TestMethod]
        public void DeveRetornaX̄()
        {
            ConversorArabicoparaRomano teste = new ConversorArabicoparaRomano(10000);
            Assert.AreEqual("X̄", teste.ObterDezenaDeMilhar());
        }
    }
}
