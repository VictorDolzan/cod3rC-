using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturasDeControle{
    class UsandoBreak{
        public static void Executar(){
            Random randomNumber = new Random();
            int numeroGerado = randomNumber.Next(1, 51);

            Console.WriteLine($"O número que queremos é {numeroGerado}");

            for(int i = 1; i <= 50; i++){
                Console.Write($"{i} é o número que queremos?");
                if(i == numeroGerado){
                    Console.WriteLine("Sim");
                    break;
                }else{
                    Console.WriteLine("Não");
                }
            }
            Console.WriteLine("FIM!!");
        }
    }
}