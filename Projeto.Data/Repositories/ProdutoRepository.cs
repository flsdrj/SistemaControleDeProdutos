using Dapper;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        //atributo
        private string connectionString;

        //contrutor com entradas de argumentos
        public ProdutoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Produto obj)
        {
            var query = "insert into Produto(Nome, Preco, Quantidade, IdEstoque) "
                      + "values(@nome, @Preco, @Quantidade, @IdEstoque)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }
        public void Alterar(Produto obj)
        {
            var query = "update Produto set Nome = @Nome, Preco = @Preco, Quantidade = @Quantidade, "
                      + "IdEstoque = @IdEstoque where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Produto obj)
        {
            var query = "delete from Produto where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }        

        public List<Produto> ConsultarTodos()
        {
            var query = "select * from Produto";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query).ToList();
            }
        }

        public Produto ConsultarPorId(int idProduto)
        {
            var query = "select * from Produto where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query, new { idProduto }).FirstOrDefault();
            }
        }


    }
}
