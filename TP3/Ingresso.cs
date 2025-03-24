using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Ingresso
    {
        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            NomeDoShow = nomeDoShow;
            Preco = preco;
            QuantidadeDisponivel = quantidadeDisponivel;
        }

        public string NomeDoShow { get; private set; }
        public double Preco { get; private set; }
        public int QuantidadeDisponivel { get; private set; }

        public void AlterarPreco(double preco)
        {
            Preco = preco;
        }

        public void AlterarQuantidade(int quantidade)
        {
            QuantidadeDisponivel = quantidade;
        }

        public string ExibirInformacoes()
        {
            return $"nome do show: {NomeDoShow}, Preço: {Preco:C}, Quantidade de ingressos: {QuantidadeDisponivel}";
        }
    }
}
