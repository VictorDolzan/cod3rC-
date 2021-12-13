using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;
            string nome = "Victor Dolsan Criou Isso!";

            raio = 5.5;
            //PI = 3.16;

            double area = PI * raio * raio;
            Console.WriteLine(nome);
            Console.WriteLine(area);            
            Console.WriteLine("Área é " + area);

            //Tipos internos

            bool estachovendo = true;
            Console.WriteLine("Está chovendo " + estachovendo);

            byte idade = 45;
            Console.WriteLine("A idade é: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols é: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor de INT é: " + menorValorInt); // mais usado os inteiros

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("A população brasileira é de: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long é: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial é: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador é: " + precoComputador);

            double valorDeMercadoDaApple = 10000000000.00;
            Console.WriteLine("O Valor de mercado da Apple é: " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelhas = decimal.MaxValue;
            Console.WriteLine("Distância das estrelhas é: " + distanciaEntreAsEstrelhas);

            char letra = 'b';
            Console.WriteLine("A letra é: " + letra);

            string texto = "Seja Bem vindo ao curso de C#";
            Console.WriteLine(texto);
        }
    }
}