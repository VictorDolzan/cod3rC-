using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturasDeControle
{
    
        class EstruturaForVictor{
        public static void Executar(){
        //    Algorítimo que calcula a média de 5 alunos: 
        //     int quantidadeAlunos = 5;
        //     double totalIdade = 0;
        //     string idadeAlunos; 
        

        //     for(int i = 1; i <= quantidadeAlunos; i++){
        //         Console.Write($"Digite a idade do aluno {i}: ");
        //         idadeAlunos = Console.ReadLine();
        //         double.TryParse(idadeAlunos, out double idadeIntAlunos); 

        //         totalIdade += idadeIntAlunos;                
        //     }

        //   double media = quantidadeAlunos > 0 ? totalIdade / quantidadeAlunos : 0;    
        //   Console.WriteLine($"A média da idade dos alunos é: {media}");

        //Algorítimo que verifica se o número informado é par ou impar

                // string captureNumber;                

                // Console.WriteLine($"Digite um número:");
                // captureNumber = Console.ReadLine();
                // double.TryParse(captureNumber, out double captureNumberDouble);

                // if(captureNumberDouble % 2 == 1 ){
                //     Console.WriteLine($"Número digitado é: {captureNumberDouble}");
                //     Console.WriteLine("Número é impar!");

                // }else{
                //     Console.WriteLine("Número é par");
                // }

                //Algoritimo que exibe quantas pessoas tem mais de 18 anos
                 int totalPeople = 10;
                 int captureAdults = 0;
                 int captureYoung = 0; 
        
                for(int i = 1; i <= totalPeople; i++){
                   
                    Console.WriteLine($"Digite a idade da pessoa {i}");
                    string captureAge = Console.ReadLine();
                    int.TryParse(captureAge, out int age);

                    if(age >= 18){
                        captureAdults = captureAdults +1;
                    }else{
                        captureYoung = captureYoung + 1;
                    }                    
                }

                Console.WriteLine($"A quantidade de adultos é: {captureAdults}");
                Console.WriteLine($"A quantidade de jovens é: {captureYoung}");              
        }
    }
}