using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    public class ConversorRomanoparaArabico
    {
        public string numeroRomano;

        public ConversorRomanoparaArabico(string numeroRomano)
        {
            this.numeroRomano = numeroRomano;
        }
        public int Converter()
        {
            numeroRomano = numeroRomano.ToUpper();
            int resultado = 0;
            numeroRomano = Normalizar(numeroRomano);

            foreach(char letra in numeroRomano)
            {
                resultado += ConverteLetraNumero(letra);
            }
            if (numeroRomano.Contains("IV") || numeroRomano.Contains("IX"))
                resultado -= 2;
            if (numeroRomano.Contains("XL") || numeroRomano.Contains("XC"))
                resultado -= 20;
            if(numeroRomano.Contains("CD") || numeroRomano.Contains("CM"))
                resultado -= 200;
            if (numeroRomano.Contains("iv") || numeroRomano.Contains("ix"))
                resultado -= 2000; 

            return resultado;
        }
        private int ConverteLetraNumero(char letra)
        {
            switch (letra)
            {
                case 'I':
                    { return 1; }

                case 'V':
                    { return 5; }

                case 'X':
                    { return 10; }

                case 'L':
                    { return 50; }

                case 'C':
                    { return 100; }

                case 'D':
                    { return 500; }

                case 'M':
                    { return 1000; }

                case 'x':
                    { return 10000; }

                case 'i':
                    { return 1000; }

                case 'v':
                    { return 5000; }
            }

            return 0;
        }
        private static string Normalizar(string str)
        {
            str = str.ToUpper();

            str = str.Replace("Ī", "i");
            str = str.Replace("V̄", "v");
            str = str.Replace("X̄", "x");

            return str;
        }
    }
}
