using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Entities
{
    public class Produto
    {
        //prop + 2x[tab]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdEstoque { get; set; }

        //Assoiação de (TER1)
        public Estoque Estoque { get; set; }

        //construtor -> ctor + 2x[tab]
        public Produto()
        {
            //default (vazio)
        }

        //Sobrecarga de métodos (OVERLOADING)
        public Produto(int idProduto, string nome, decimal preco, int quantidade, int idEstoque)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            IdEstoque = idEstoque;
        }

        //SOBRESCRITA (overrride) do metodo ToString()
        public override string ToString()
        {
            return $"IdProduto: {IdProduto}, Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }
    }
}
