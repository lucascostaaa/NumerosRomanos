using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;
using System;

namespace TesteRomanoParaArabico
{
    [TestClass]
    public class TesteRomanoParaArabico
    {
        [TestMethod]
        public void DeveRetornar1()
        {
            ConvervorRomanoparaArabico teste = new ConversorArabicoparaRomano(1);
            Assert.AreEqual("I", teste.ObterUnidadeRomano());
        }
    }
}
