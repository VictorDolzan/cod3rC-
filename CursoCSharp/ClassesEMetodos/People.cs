using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.ClassesEMetodos
{
    class People
    {
        public string Nome;
        public int Idade = 0; 
        public string Retorno;

        
        

        public void PegarNomeUsuario(){

            Console.WriteLine("Digite um nome de usuário: ");
            Nome = Console.ReadLine();                   
            
        }
        public void PegarIdadeUsuario(){
            Console.WriteLine("Digite uma idade para o usuário: ");
            string IdadeString = Console.ReadLine();            
            int.TryParse(IdadeString, out Idade);                       
        }
        // public void ZerarInformacoesNomeUsuario(){
        //     Nome = " ";
        // }
        // public void ZerarInformacoesIdadeUsuario(){
        //     IntIdade = 0;
        //     string NewIdadeString = " ";
        // }

        public void VerificarInformacoesUsuario(){
            
            while(Nome == " ")
            {             
                Console.WriteLine("É preciso digitar um nome! ");
                PegarNomeUsuario();                
            }
            while(Idade == 0){
                Console.WriteLine("A idade não foi digitada!");
                PegarIdadeUsuario();
            }             
        }
        public string Presentation()
        {    
            PegarNomeUsuario();
            PegarIdadeUsuario();       

            VerificarInformacoesUsuario();
             
            
            //return Presentation();     
           Console.Write($"O nome é: {Nome}, a idade é {Idade.ToString()} e a idade vezes 2 é: {Idade * 2}");
           Retorno = Console.ReadLine();
           return Retorno;            
              
        } 
    }
}