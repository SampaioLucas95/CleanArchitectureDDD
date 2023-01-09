using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
 
 namespace SolutionName.Infrastructure.Context.Cotacao;

 public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("dbCotacao");
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }