using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double score = 6.0;
            Console.Write("Digite a nota: ");
            double score = double.Parse(Console.ReadLine());
            double passingScore = 7.0;

            Console.WriteLine($"Nota inválida? {score > 10.0}");
            Console.WriteLine($"Nota inválida? {score < 0.0}");
            Console.WriteLine($"Perfeito? {score == 10.0}");
            Console.WriteLine($"Tem como melhorar? {score != 10.0}");
            Console.WriteLine($"Passou por média? {score >= passingScore}");
            Console.WriteLine($"Recuperação? {score < passingScore}");
            Console.WriteLine($"Reprovado? {score <= 3.0}");
        }
    }
}