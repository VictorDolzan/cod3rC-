using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
 
namespace CursoCSharp.Fundamentos
{
    class ReadingData
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string name = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int age = int.Parse(Console.ReadLine());         

            Console.Write("Qual é o seu Salário? ");
            double salary = double.Parse(Console.ReadLine(),
            CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {name}, \nSua idade é: {age}, \nSeu salário é R${salary}");
        }
    }
}