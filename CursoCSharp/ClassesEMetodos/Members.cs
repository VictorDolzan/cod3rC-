using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.ClassesEMetodos
{
    class Members{
        public static void Executar(){                  
            
            People User = new People();

            // User.PegarNomeUsuario();
            // User.PegarIdadeUsuario();
            User.PegarNomeUsuario();
            User.PegarIdadeUsuario();

            User.VerificarInformacoesUsuario();

            User.Presentation();
            
            
            // sicrano.Zerar();
            // sicrano.PresentInConsole();

            // var fulano = new People();
            // fulano.Nome = "Jasmin";
            // fulano.Idade = 30;
            // fulano.Endereco = "Rua das Acássias";

            // var fulanoPresentation = fulano.Presentation();
            // Console.WriteLine(fulanoPresentation.Length);
            // Console.WriteLine(fulanoPresentation);
        }
    }
}