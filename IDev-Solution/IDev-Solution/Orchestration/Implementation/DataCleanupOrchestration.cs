using Dapper;
using Hackathon.Orchestration.Interface;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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

        public List<string> CleanAndLoadCSV()
        {

            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            using (var reader = new StreamReader("wwwroot/Hackaton Data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    //listB.Add(values[1]);
                }
            }
            
            return listA.AsList();
        }

        public List<string> CleanAndLoad()
        {
            //CleanAndLoadCSV();
            //LoadInDB();

            return CleanAndLoadCSV();
        }

        public string LoadInDB()
        {
            var sql = "SELECT TOP 10 * FROM OrderDetails";
            var cs = "Server=Localhost;Database=i_dev;Uid=root;";

            using (var connection = new SqlConnection(cs))
            {
                var orderDetail = connection.Query(sql).FirstOrDefault();

            }

            return null;
        }
    }
}
