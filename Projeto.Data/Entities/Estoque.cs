using System;
using System.Collections.Generic;
using System.Text;


namespace Projeto.Data.Entities
{
    public class Estoque
    {
        //prop + 2x[tab]
        public int IdEstoque { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Relacionamentos de Associacao
        public List<Produto> Produtos { get; set; }

        //ctor + 2x[tab]
        public Estoque()
        {
            //default(vazio)
        }

        //sobrecarga de métodos construtores (OVERLOADING)
        public Estoque(int idEstoque, string nome, string descricao)
        {
            IdEstoque = idEstoque;
            Nome = nome;
            Descricao = descricao;
        }

        //Sobreescrita de métodos
        public override string ToString()
        {
            return $"IdEstoque: {IdEstoque}, Nome: {Nome}, Descricão:{Descricao}";
        }
    }
}
