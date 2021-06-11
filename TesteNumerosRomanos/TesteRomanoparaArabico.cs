using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace TesteNumerosRomanos
{
    [TestClass]
    public class testeRomanoparaArabico
    {
        [TestMethod]
        public void DeveRetornar1()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("I");
            Assert.AreEqual(1, teste.Converter());
        }
        [TestMethod]
        public void DeveRetornar2()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("II");
            Assert.AreEqual(2, teste.Converter());
        }
        [TestMethod]
        public void DeveRetornar3()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("III");
            Assert.AreEqual(3, teste.Converter());
        }
        [TestMethod]
        public void DeveRetornar5()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("V");
            Assert.AreEqual(5, teste.Converter());
        }
        [TestMethod]
        public void DeveRetornar10()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("X");
            Assert.AreEqual(10, teste.Converter());
        }
        [TestMethod]
        public void DeveRetornar50()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("L");
            Assert.AreEqual(50, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna100()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("C");
            Assert.AreEqual(100, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna1000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("M");
            Assert.AreEqual(1000, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna30()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("XXX");
            Assert.AreEqual(30, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna300()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("CCC");
            Assert.AreEqual(300, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna3000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("MMM");
            Assert.AreEqual(3000, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna4000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("ĪV̄");
            Assert.AreEqual(4000, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna5000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("V̄");
            Assert.AreEqual(5000, teste.Converter());
        }
        [TestMethod]

        public void DeveRetorna6000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("V̄Ī");
            Assert.AreEqual(6000, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna7000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("V̄ĪĪ");
            Assert.AreEqual(7000, teste.Converter());
        }

        [TestMethod]
        public void DeveRetorna8000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("V̄ĪĪĪ");
            Assert.AreEqual(8000, teste.Converter());
        }
        [TestMethod]
        public void DeveRetorna9000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("ĪX̄");
            Assert.AreEqual(9000, teste.Converter());
        }
        [TestMethod]
        public void DeveRetornaX10000()
        {
            ConversorRomanoparaArabico teste = new ConversorRomanoparaArabico("X̄");
            Assert.AreEqual(10000, teste.Converter());
        }
    }
}
