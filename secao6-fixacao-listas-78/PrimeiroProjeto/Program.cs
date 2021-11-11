//using system - referencia para o namespace chamado system, que é padrao do .net que contem funções basicas de manipulações de programas
using System;
using System.Globalization;
using System.Collections.Generic;

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

            //entrada dados, numero de empregados
            Console.WriteLine("quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //gera a lista empregados em cima da classe employee
            List<Employee> list = new List<Employee>();

            //laço for - para preencher a lista com a quantidade de empregados selecionados na variavel n
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            // id do empregado para receber o aumento de salario 
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            //operação - expressao lambda x => - para procurar o id do empregado
            // na lista e fazer o aumento do salário conforma porcentagem adicionada
            //se for nulo retorna que funcionario nao existe
            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            //escreve a lista de funcionarios atualizados com o novo salario
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
