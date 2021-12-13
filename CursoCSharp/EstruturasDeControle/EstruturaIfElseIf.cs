using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno: ");
            string entry = Console.ReadLine();
            Double.TryParse(entry, out double nota);

            if(nota >= 9.0){
                Console.WriteLine("Quadro de Honra!");
            }
            else if(nota >= 7.0){
                Console.WriteLine("Quadro de Honra 2!");
            }
            else if(nota >= 5.0){
                Console.WriteLine("Recuperação!");
            }
            else{
                Console.WriteLine("Reprovado");
            }
        }
    }
}