using System;
using System.Globalization;

/*
 * A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.
*/

namespace PrimeiroProjeto
{
       class Program
    {
        static void Main(string[] args)
        {
            //inicia um novo vetor (vect) estudante com 10 posições
            Estudante[] vect = new Estudante[10];

            //preenche a quant de quartos que serão alugados 
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            //laço for - inicia em 1, repete e soma 1 para cada interação até i ser igual a n
            for (int i = 1; i <= n; i++)
            {
                //escreve aluguel numero:
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                //salva nome e email nas variaveis e joga pro vetor
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                //seleciona o numero do quarto e adiciona a ele as informações
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);


            }
            //relatorio quartos ocupados
            //laço for preenchendo só os não nulos
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
