using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço Desconto
            var price = 1000.0;
            var tax = 355;
            var discount = 0.1;

            double total = price + tax;
            var totalWithDiscount = total - (total * discount);
            Console.WriteLine($"O preço final é {totalWithDiscount}");

            //IMC
            double weight = 91.2;
            double hight = 1.71;
            double imc = weight / Math.Pow(hight,2);
            Console.WriteLine($"O IMC é: {imc}");

            //Número Par/Ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine($"{par}/2 tem resto {par % 2}");
            int numberPar = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{impar}/2 tem resto {impar % 2}");
            int numberImpar = int.Parse(Console.ReadLine());
            
           

            // if(numberPar == 0)
            // {
            //     Console.WriteLine("O número é par");
            // }
            // else
            // {
            //     Console.WriteLine("O Número é impar!");
            // }
        }
    }
}