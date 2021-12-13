using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento 
            ? "Aprovado" : "Reprovado"; 

            Console.WriteLine(resultado);


        }
    }
}