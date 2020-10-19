using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;
using System.Configuration;

namespace DemoDBDataAccessLayer.DB
{
    public class MySqlDbConnection : ISqlDbConnection
    {
        public List<T> LoadData<T, U>(string query, U parameter, string connectionStringName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.Query<T>(query, parameter).ToList();
            }
        }

        public int SaveData<U>(string query, U parameter, string connectionStringName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.Execute(query, parameter);
            }
        }
    }
}
