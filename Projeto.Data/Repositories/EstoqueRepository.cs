using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Entities; //importando
using Projeto.Data.Contracts; //importando
using System.Data.SqlClient; //importando
using Dapper; //importando
using System.Linq;

namespace Projeto.Data.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        //atributo
        private string connectionString;

        //contrutor com entradas de argumentos
        public EstoqueRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Estoque obj)
        {
            var query = "insert into Estoque(Nome, Descricao) values(@nome, @Descricao)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Alterar(Estoque obj)
        {
            var query = "update Estoque set Nome = @Nome, Descricao =  @Descricao "
                      + "where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Estoque obj)
        {
            var query = "delete from Estoque where IdEstoque = @IdEStoque";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }

        }

        public List<Estoque> ConsultarTodos()
        {
            var query = "select * from Estoque";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Estoque>(query).ToList();
            }
        }

        public Estoque ConsultarPorId(int idEstoque)
        {
            var query = "select * from Estoque where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Estoque>(query, new { idEstoque }).FirstOrDefault();
            }
        }  
    }
}
