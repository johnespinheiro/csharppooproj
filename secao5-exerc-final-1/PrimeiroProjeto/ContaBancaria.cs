using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProjeto
{
    class ContaBancaria
    {
        //usando as propriedades de get e set direto na declaração da variavel
        //numero da conta pode ser acessado mas nao pode ser alterado
        //então é get(accesso), private set(alteração) (obj numero)
        public int Numero { get; private set; }
        public string Titular { get; set; }
        //saldo so pode ser trocado por meio das operações deposito e saque
        //então tem que ser private set 
        //então tem que ser private set 
        public double Saldo { get; private set; }

        //sobrecarga 1
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        //sobrecarga, usando o this para referenciar os parametros já passados
        //lembrando da formatação de nomes - maiuscula para o nome, minuscula para parametros
/*        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
*/
        //usando esta lógica, caso altere a operação de deposito, ela se refletirá automaticamente aqui
        //seria uma forma mais correta, já que a operação abaixo é apenas para o dep inicial
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        //operação deposito, vai ser void pq vai alterar o valor do saldo, n recebe dado direto
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

        //tostring para quando chamar o metodo conta, exibir o texto concatenado
        public override string ToString()
        {
            return "Conta: "
                + Numero
                +", Titular: "
                + Titular
                +", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    
}
