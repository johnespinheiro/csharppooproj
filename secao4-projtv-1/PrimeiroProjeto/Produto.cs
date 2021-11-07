using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    //manter padrao, nome da classe começa com Maiusculo ( class Produto )
    class Produto
    {
        //mantendo padrao, nome de atributo começa com Maiusculo ( Ex Preco )
        public string Nome;
        public double Preco;
        public int Quantidade;

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
