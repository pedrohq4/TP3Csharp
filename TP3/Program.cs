namespace TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 4:
            Ingresso ingresso = new Ingresso();
            ingresso.NomeDoShow = "ACDC";
            ingresso.Preco = 50.75;
            ingresso.QuantidadeDisponivel = 3;

            ingresso.AlterarPreco(50);
            ingresso.AlterarQuantidade(2);
            Console.WriteLine(ingresso.ExibirInformacoes());*/

            /*Exercício 6:
            Ingresso ingresso = new Ingresso("ACDC", 50.75, 3);

            Console.WriteLine(ingresso.ExibirInformacoes());*/

            /*Exercício 9:
            Matricula testeMatricula = new Matricula();

            testeMatricula.NomeDoAluno = "Pedro Henrique";
            testeMatricula.Curso = "Eng da computação";
            testeMatricula.NumeroMatricula = 32;
            testeMatricula.Situacao = "Ativo";
            testeMatricula.DataInicial = "12/12/2000";

            testeMatricula.Trancar();
            Console.WriteLine(testeMatricula.Situacao);
            testeMatricula.Reativar();
            Console.WriteLine(testeMatricula.Situacao);

            Console.WriteLine(testeMatricula.ExibirInformacoes());*/

            Circulo testeCirculo = new Circulo();
            Esfera testeEfera = new Esfera();

            testeEfera.raio = 3.0;
            testeCirculo.raio = 2.0;

            testeEfera.calcularVolume();
            testeCirculo.calcularArea();
        }
    }
}
