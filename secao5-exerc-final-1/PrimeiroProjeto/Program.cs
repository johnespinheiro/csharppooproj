//using system - referencia para o namespace chamado system, que é padrao do .net que contem funções basicas de manipulações de programas
using System;
using System.Globalization;

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

            //declarando a var contabancaria, instanciando a conta, declarada aqui fora
            //pois declarada dentro do if só existirá dentro do if
            ContaBancaria conta;

            //entrada do numero da conta
            Console.Write("Entre com o numero da conta:");
            int numero = int.Parse(Console.ReadLine());

            //entrada titular conta
            Console.Write("Entre com o titular da conta:");
            string titular = Console.ReadLine();

            //entrada deposito inicial, dependente da resposta - if/else
            Console.Write("Haverá depósito inicial ? S/N");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor de deposito inicial");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            //caso nao tenha saldo inicial, usa o else, com a conta apenas com numero e titular
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("dados da conta");
            Console.WriteLine(conta);

            //digita o dado para deposito, salva em quantia e chama a operação deposito da class ContaBancaria
            Console.WriteLine();
            Console.Write("Entre um valor para deposito ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            //operação de saque, posso usar a var quantia, pois ja está declarada
            Console.WriteLine();
            Console.Write("Entre um valor para saue ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
