using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using SouFieb.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SouFieb.DB
{
    public class PessoaDB
    {
        private IConfiguration _configuration;

        public PessoaDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Pessoa> BuscarTodos()
        {
            using (SqlConnection conexao = new ConexaoBancoDeDados(_configuration).Conectar())
            {
                return conexao.Query<Pessoa>("SELECT * FROM dbo.Pessoa");
            }
        }

        public Pessoa BuscarPorId(int id)
        {
            using (SqlConnection conexao = new ConexaoBancoDeDados(_configuration).Conectar())
            {
                return conexao.QueryFirstOrDefault<Pessoa>("SELECT * FROM dbo.Pessoa WHERE Id = @id", new { id });
            }
        }

        public void Salvar(Pessoa pessoa)
        {
            using (SqlConnection conexao = new ConexaoBancoDeDados(_configuration).Conectar())
            {
                conexao.Insert(pessoa);
            }
        }

        public void Atualizar(Pessoa pessoa)
        {
            using (SqlConnection conexao = new ConexaoBancoDeDados(_configuration).Conectar())
            {
                conexao.Update(pessoa);
            }
        }

        public bool Deletar(Pessoa pessoa)
        {
            using (SqlConnection conexao = new ConexaoBancoDeDados(_configuration).Conectar())
            {
               return conexao.Delete(pessoa);
            }
        }
    }
}
