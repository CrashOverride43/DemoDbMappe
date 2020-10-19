using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Configuration;

namespace DemoDBDataAccessLayer.DB
{
    /// <summary>
    /// Stellt 2 Methoden zur Verfügung.
    /// Eine zum Speichen und eine zum Lesen.
    /// </summary>
    public class MsSqlDbConnection : ISqlDbConnection
    {
        /// <summary>
        /// Zur Ausführung aller Sql Querys, die zur Datenabfrage dienen.
        /// </summary>
        /// <typeparam name="T">Definiert den Rückgabetypen der Methode</typeparam>
        /// <typeparam name="U">Definiert den Sql Parametertypen</typeparam>
        /// <param name="query">Die auszuführende Sql Query</param>
        /// <param name="parameter">Die Parameter der Sql Query</param>
        /// <returns>Gibt eine Liste vom Typ T zurück.</returns>
        public List<T> LoadData<T, U>(string query, U parameter, string connectionStringName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return con.Query<T>(query, parameter).ToList();
            }
        }

        /// <summary>
        /// Zur Ausführung aller Sql Querys, die zur Datenspeicherung oder -löschung dienen.
        /// </summary>
        /// <typeparam name="U">Definiert den Sql Parametertypen</typeparam>
        /// <param name="query">Die auszuführende Sql Query</param>
        /// <param name="parameter">Die Parameter der Sql Query</param>
        /// <returns>Anzahl an Veränderungen</returns>
        public int SaveData<U>(string query, U parameter, string connectionStringName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return con.Execute(query, parameter);
            }
        }
    }
}
