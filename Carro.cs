using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel {
    public abstract class Carro {

        public  string Modelo { get; set; }  
        public int ano { get; set; }
        public string marca { get; set; }


        public abstract void Acelerar();
        public abstract void Parar();

        public abstract void Buzinar();
    }
}
