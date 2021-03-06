using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    //manter padrao, nome da classe começa com Maiusculo ( class Produto )
    class Produto
    {
        //mantendo padrao, nome de atributo começa com Maiusculo ( Ex Preco ) - usando get e set ( auto properties )
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //gerando um construtor - construtor é uma operação que tem o mesmo nome da classe
        //voce define se o seu construtor vai receber algum parametro de entrada - dentro das () após o nome do construtor
        //nome do parametro começa com minuscula
        //declarando os parametros, na hora de instanciar é obrigado a informar nome, preço e quantidade já no construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //segundo construtor - aula de sobrecarga 52
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        //como o nome possui uma logica customizada, nao pode ser usado como auto properties, usa a manual
        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    Nome = value;
                }
            }
        }
        //construtor padrão, sem valores definidos na construção

        public Produto()
        {

        }

        //função publica (acessivel por todos), tipo double  , nome iniciando maiusculo  
        public double ValorTotalEmEstoque()
        {
            //retorna o preço * quantidade 
            return Preco * Quantidade;
        }

        /* aula 44 - função vai ser void(vazio)
         * porque a operação de adicionar ou remover o estoque nao tem que retornar valor de saida,
         * vai simplesmente ir na quant do produto e mudar o valor dele
         * padrao mantido - quando vai iniciar alguma variavel de parametro de entrada de funcao - letra minuscula (int quantidade)
         */
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        //assinatura basica do tostring - classe publica, override indicando q veio de outra classe, string tipo de saida e nome da funcao tostring - aula 43
        public override string ToString()
        {
            //retornando nome concatenado com $ e preço - aula 43
            return Nome +
                ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }


}
