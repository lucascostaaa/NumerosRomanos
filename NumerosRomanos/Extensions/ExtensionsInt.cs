using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.Extensions
{
    public  static class ExtensionsInt
    {
        public static int ObterUnidades(this int unidade)
        {
            return (unidade % 100) % 10;
        }
        public static int ObterDezenas(this int dezena)
        {
            return (dezena % 100) / 10;
        }
        public static int ObterCentena(this int centena)
        {
            return (centena % 1000) / 100;
        }
        public static int ObterUnidadeDeMilhar(this int unidade)
        {
            return (unidade % 10000) / 1000;
        }
        public static int ObterDezenaDeMilhar(this int unidade)
        {
            return (unidade % 100000) / 10000;
        }

    }
}
