using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace SouFieb.DB
{
    public class ConexaoBancoDeDados
    {
        private IConfiguration _configuration;

        public ConexaoBancoDeDados(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection Conectar()
        {
            return new SqlConnection(_configuration.GetConnectionString("DB"));
        }
    }
}
