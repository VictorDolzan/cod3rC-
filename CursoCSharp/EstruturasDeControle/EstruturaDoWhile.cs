using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile{
        public static void Executar(){
            string entrada;

            do{
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem-vindo {entrada}");
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
            }
            while (entrada.ToLower() == "s");
        }
    }
}