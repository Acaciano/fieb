using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using SouFieb.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SouFieb.DB
{
    public class EventoDB
    {
        private IConfiguration _configuration;

        public EventoDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Evento> BuscarTodos()
        {
            using (SqlConnection conexao = new ConexaoBancoDeDados(_configuration).Conectar())
            {
                return conexao.Query<Evento>("SELECT * FROM dbo.Evento");
            }
        }

        public void Salvar(Evento evento)
        {
            using (SqlConnection conexao = new ConexaoBancoDeDados(_configuration).Conectar())
            {
                conexao.Insert(evento);
            }
        }
    }
}
