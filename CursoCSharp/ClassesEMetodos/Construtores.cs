using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro{
        public string Model;
        public string Manufacturer;
        public int Year;

        public Carro(string model, string manufacturer, int year){
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
        }

        public Carro(){
            
        }
    }
    class Contrutores{
        public static void Executar(){
            var car1 = new Carro();
            car1.Manufacturer = "BMW";
            car1.Model = "325i";
            car1.Year = 2017;

            Console.WriteLine(
                $"Carro é produzido pela empresa {car1.Manufacturer} com o modelo {car1.Model} e o ano {car1.Year}");

            var car2 = new Carro("KA", "Ford", 2018);
            Console.WriteLine($"{car2.Manufacturer} {car2.Model} {car2.Year}");

            var car3 = new Carro(){
                Manufacturer = "Fiat",
                Model = "Uno",
                Year = 2019
            };
            Console.WriteLine(
                $"Carro é produzido pela empresa {car3.Manufacturer} com o modelo {car3.Model} e o ano {car3.Year}");
        }
    }
}