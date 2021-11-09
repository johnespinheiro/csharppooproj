//using system - referencia para o namespace chamado system, que é padrao do .net que contem funções basicas de manipulações de programas
using System;
//globalization para uso do . em vez da , nos decimais 
using System.Globalization;

// 09/11/21 - aula 51 e 52 - construtores e sobrecarga
// sobrecarga é um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porem com diferentes listas de parametros

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

            //produto ja instanciado da aula 51, sera utilizado depois
            //vamos instanciar o nome direto na entrada de dados nesta aula
            //           Produto p = new Produto("TV", 500.00, 10);

            //escreve no console as frases abaixo
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");

            //agora como tem que ler os dados primeiro pra depois instaciar o produto, aula 51, usa variavel auxiliar
            string nome = Console.ReadLine();

            Console.Write("Preço:");
            //            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Quantidade no estoque:");
            //            p.Quantidade = int.Parse(Console.ReadLine());

            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();


            //aula 51 - apos informar os dados nas vars, agora sim pode instanciar o produto

            Produto p = new Produto(nome, preco, quantidade);

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
