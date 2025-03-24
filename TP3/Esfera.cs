using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Esfera
    {
        public double raio;
        public double calcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (raio * raio * raio);
        }
    }
}
