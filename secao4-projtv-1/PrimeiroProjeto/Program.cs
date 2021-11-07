//using system - referencia para o namespace chamado system, que é padrao do .net que contem funções basicas de manipulações de programas
using System;
//globalization para uso do . em vez da , nos decimais 
using System.Globalization;

// aula 43 - 07/11/21 - 10:48 - object e to string
// aula 44 - 07/11/21 - 11:03 - terminando construção do programa

//declaração de namespace deste arquivo - primeiroprojeto - namespace é um agrupamento de classes relacionadas, 
namespace PrimeiroProjeto
{
    // a class program está declarada que está dentro do namespace primeiroprojeto
    //por questao de boa pratica e organização, classes devem estar dentro das namespaces
    // a declaração da classe - todo codigo fonte escrito em C# deve estar dentro de uma classe, a classe é a unidade basica da POO
    //por convenção e organização, normalmente a classe leva o mesmo nome do arquivo para ficar mais facil de identificar - ex. arquivo program com a classe program
    class Program
    {
        //static void - membro da classe, entrypoint do programa(ponto de entrada) - é uma declaração padrao da linguagem C#
        static void Main(string[] args)
        {
            //comando dentro do entrypoint que será executado em primeiro lugar no programa
            //chama a classe produto e cria um novo produto
            Produto p = new Produto();
            
            //escreve no console as frases abaixo
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
           
            //adiciona o que for digitado como nome do produto P - sec 4 aula 42
            p.Nome = Console.ReadLine();

            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            //exibe o p com a função de ToString(aula 43)
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            /*inicio aula 44 - usuario digita a quant de produtos para adicionar
             * chama a função AdicionarProdutos na classe Produto para fazer a soma
             * chama remover produtos para reduzer a quantidade
             */
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            //chama a variavel qte, nao declara novamente porque ja foi declarada em cima
            Console.Write("Digite o numero de produtos a ser removido ao estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }

    }
}
