using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Circulo
    {
        public double raio;

        public double calcularArea()
        {
            return Math.PI * (raio * raio);
        }
    }
}
