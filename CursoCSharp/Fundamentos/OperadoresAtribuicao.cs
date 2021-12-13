using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;

            num1 += 10;// num1 = num1 + 10;
            num1 -= 3;// num1 = num1 - 3;
            num1 *= 5;// num1 = num1 * 5;
            num1 /= 2;// num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; //a = a + 1;
            b--; //b = b - 1;

            Console.WriteLine($"Valor de A: {a}, valor de b: {b}");

            //não se preocupe com o código

            dynamic c = new System.Dynamic.ExpandoObject();
            c.name = "João";

            dynamic d = c;
            d.name = "Maria";

            Console.WriteLine(c.name);
        }
    }
}