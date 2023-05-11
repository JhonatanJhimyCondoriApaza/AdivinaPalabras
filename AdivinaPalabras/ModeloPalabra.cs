using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaPalabras
{
    class ModeloPalabra
    {
        public double peso { get; set; }
        public string palabra { get; set; }

        public ModeloPalabra(string palabra_recibida, double peso_recibida) {
            this.palabra = palabra_recibida;
            this.peso = peso_recibida; 
        }
    }
}
