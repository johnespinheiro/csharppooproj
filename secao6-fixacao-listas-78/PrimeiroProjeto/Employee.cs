using System.Globalization;

namespace PrimeiroProjeto
{
    class Employee
    {
        //declaração das variáveis
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        //construtor gerado
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        //operação para aumentar o salario
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        //concatenação para exibir as informações após a operação
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}
