using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Automovel {
    internal class Program {
        static void Main(string[] args) {

            Automobilistica aut = new Automobilistica();

            aut.Modelo = "Argo";
            aut.marca = "Fiat";
            aut.ano = 2016;

            Console.WriteLine("Modelo: " + aut.marca);
            Console.WriteLine("Marca: " + aut.ano); 
            Console.WriteLine("Ano: " + aut.Modelo);


            aut.Acelerar();
            aut.Buzinar();
            aut.Parar();

        }
    }
}
