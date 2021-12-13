using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string userName = "Victor Dolzan criou isso";
            string notebookNome = "Notebook Gamer";
            string notebookMarca = "Dell";
            double notebookPreco = 5800.00;

            Console.WriteLine(userName);
            Console.WriteLine("O " + notebookNome + " da marca "
             + notebookMarca + " custa " + notebookPreco + ".");

             Console.WriteLine("O {0} da marca {1} custa {2}.",
             notebookNome, notebookMarca, notebookPreco);

             Console.WriteLine($"A marca {notebookMarca} é legal!!");
        }
    }
}