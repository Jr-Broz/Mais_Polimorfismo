using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel {
    public class Automobilistica: Carro {

        public override void Parar() {
            Console.WriteLine("Parando  o Carro, gustavo");
        }

        public override void Acelerar() {

            Console.WriteLine("Acelerando!");


        }

        public override void Buzinar() {
            Console.WriteLine("bi-bi");
        }
    }
}
