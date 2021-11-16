//classe Workers, lista nome, a classe enum WorkerLevel (pasta separada e classe criada - enums )
//com o nivel do trabalhador 

//explicação - o objeto trabalhador vai ficar associado com os 3 objetos hourcontract, conforme dados que digitamos 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto.Entities
{
    class Worker
    {
        public string Name { get; set; }
        //enum workerlevel - tipo workerlevel com nome level
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //composição - tipo department com o nome Department - classe declarada em entities
        //dentro da classe worker, declarado propriedade tipo department
        public Department Department { get; set; }
        //composição - tipo lista da classe HourContract, onde salva data, valor e horas 
        //uso de lista porque um trabalhador tem vários contratos 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }
        //obs: não é associada a lista de um para muitos no construtor, pois inicia em 0 e você vai preenchendo
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //operação de add contrato - tipo void, inicia vazio - operação addcontract
        // vai acessar a lista de contratos (Contracts) e adicionar o contrato (contract)
        //que chegou como parametro de entrada
        //chama o Contracts.add para adicionar o contrato que chegou como argumento do método
        //mesma lógica no removecontract
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        //começa a soma com basesalary, pois o trabalhador tem um salario base
        //foreach - para para hourcontract contract na lista de contratos 
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }


}
