using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Livro
    {
        string Titulo;
        int AnoDePublicacao;
        int NumeroDePaginas;
        bool Alugado;

        Livro(string titulo)
        {
            Titulo = titulo;
            Alugado = false;
        }

        public void Reservar()
        {
            Alugado = true;
        }

        public void Devolver()
        {
            Alugado = false;
        }

        public double CalcularCustos()
        {
            return 3 + 3;
        }
    }
}
