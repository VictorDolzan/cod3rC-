using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine($"O valor é: {quebrado}, o que vc achou?");

            double grade = 9.7;
            int truncGrade = (int)grade;
            Console.WriteLine($"A nota truncada é: {truncGrade}, o que você achou?");

            Console.Write("Digite sua idade: ");
            string studentAgeString = Console.ReadLine();
            int studentAgeInt = int.Parse(studentAgeString);
            
            Console.Write("Qual a nota do aluno? "); //Eu que fiz
            double studentGrade = double.Parse(Console.ReadLine());
            int truncStudentGrade = (int)studentGrade;
            Console.WriteLine($"O resultado da nota do aluno é:{truncStudentGrade}\n Sua idade é:{studentAgeInt}");

             studentAgeInt = Convert.ToInt32(studentAgeString);
             Console.WriteLine($"Resultado é:{studentAgeInt}");

             Console.Write("Digite um número: ");
             string palavra = Console.ReadLine();
             int numero;
             int.TryParse(palavra, out numero);
             Console.WriteLine($"Resultado do TryParse é:{numero}");

            if(truncStudentGrade >= 6)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado!");
            }
            
        }
    }
}