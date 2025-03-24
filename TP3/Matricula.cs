using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP3
{
    class Matricula
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;
        public string DataInicial;

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public string ExibirInformacoes()
        {
            return $"Nome: {NomeDoAluno}, Curso: {Curso}, Numero da matricula: {NumeroMatricula}, Situação: {Situacao}, Data Inicial: {DataInicial}";
        }
    }
}
