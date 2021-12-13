using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double value = 15.175;
            Console.WriteLine(value.ToString("F1"));
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine(value.ToString("P"));
            Console.WriteLine(value.ToString("#.##"));

            CultureInfo nCulture = new CultureInfo("pt-BR");
            Console.WriteLine(value.ToString("C2", nCulture));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}