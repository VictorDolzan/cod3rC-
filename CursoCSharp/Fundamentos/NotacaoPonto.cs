using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            string userName = "Victor Dolzan criou isso!";
            var greetings = "Olá!".ToUpper().Insert(3, " Mundo!")
            .Replace("Mundo!","World!");

            Console.WriteLine(userName);
            Console.WriteLine(greetings);
            Console.WriteLine("Teste".Length);

            string importantValue = "Victor";
            Console.WriteLine(importantValue?.Length);
        }
    }
}