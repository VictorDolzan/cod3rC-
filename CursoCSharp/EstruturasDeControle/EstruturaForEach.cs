using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach{
        public static void Executar(){
            var palavra = "Opa!";

            foreach(var letra in palavra){
                Console.WriteLine(letra);
            }

            var alunos = new string[]{"Ana", "Bia", "Carlos"};
            foreach(string aluno in alunos){
                Console.WriteLine(aluno);
            }
        }
    }
}