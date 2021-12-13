using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool goodBehaviour = false;
            string entry;

            Console.Write("Digite a nota do aluno: ");
            entry = Console.ReadLine();
            Double.TryParse(entry, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entry = Console.ReadLine();

            if(entry == "S" || entry == "s")
            {
                goodBehaviour = true;
            }

            //goodBehaviour = entry.ToLower() == "s";

            if(nota >= 9.0 && goodBehaviour)
            {
                Console.WriteLine("Quadro de honra!");
            }
            
            if(nota >= 9.0 && !goodBehaviour)
            {
                Console.WriteLine("Não faz parte do quadro de honra!");
            }
            
        }
    }
}