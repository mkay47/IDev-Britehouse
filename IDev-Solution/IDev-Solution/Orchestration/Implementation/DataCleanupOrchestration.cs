using Dapper;
using Hackathon.Orchestration.Interface;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Hackathon.Orchestration
{
    public class DataCleanupOrchestration : IDataCleanupOrchestration
    {
        private readonly IConfiguration _config;

        public DataCleanupOrchestration(IConfiguration config)
        {
            _config = config;
        }

        public string CleanAndLoad()
        {
            string sql = "SELECT TOP 10 * FROM OrderDetails";

            using (var connection = new SqlConnection(_config.GetSection("ConnectionString").Value))
            {
                var orderDetail = connection.Query(sql).FirstOrDefault();
                
            }

            return null;
        }
    }
}
