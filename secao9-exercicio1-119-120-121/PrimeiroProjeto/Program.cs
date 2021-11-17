using System;
using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Entities.Enums;
using System.Globalization;

/* exercício - ler os dados de um trabalhador com N contratos (N fornecido pelo usuario) 
 * Depois, solicitar do usuario um mês e mostrar qual foi o salário do funcionário nesse mês
 */
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //escreve e captura departamento - string deptName
            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();

            //escreve e captura nome trabalhador - string name
            Console.WriteLine("enter Worker Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            //workerlevel recebe a variavel level
            //recebe o enum.parse parametrizado com o worker level, recebendo os dados do console.readline
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            //salario base - recebe um double baseSalary
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //cria a var department dep, recebe um new department, recebe o deptName com o nome do departamento
            Department dept = new Department(deptName);

            //instanciando o worker, new worker com os dados digitados nas variaveis
            Worker worker = new Worker(name, level, baseSalary, dept);

            //var n salva quant contratos
            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            //laço for para repetir o comando enquanto i for menor que n ( num contratos )
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} Contract Data:");
                
                Console.Write("Data: dd/mm/yyyy");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration: ");
                int hours = int.Parse(Console.ReadLine());

                //apos digitar, instancia o contrato
                //apos criar o contrato, deve adicionar os contratos nos contratos do trabalhador instanciado
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //chama o trabalhador pra adicionar, e adiciona o contrato que acabou de instanciar
                worker.AddContract(contract);
            }

            //captura de mes e ano para a some dos ganhos do mes
            //salva o digitado em uma string montAndYear, faz o recorte do mes e do ano
            //recorta com substring
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income: (mm/yyyy) ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year,month), CultureInfo.InvariantCulture);
        }
    }
}
