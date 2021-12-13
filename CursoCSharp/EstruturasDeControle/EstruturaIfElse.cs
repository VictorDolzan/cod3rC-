using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7;

            if(nota >= 7)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não faz mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}