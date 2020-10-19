using DemoDBDataAccessLayer.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Data
{
    /// <summary>
    /// Basis Klasse zur Erstellung einer Verbindung zur Datenbank.
    /// Speichert den Connection String Name und eine Instanz der Connection Klasse.
    /// </summary>
    public class BaseData
    {
        protected MsSqlDbConnection MsSqlDbConnection = new MsSqlDbConnection();
        protected MySqlDbConnection MySqlDbConnection = new MySqlDbConnection();
        protected string _connectionStringName;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="connectionStringName">Der Connection String Name, welcher allgemeingültig ist für die Anwendung.</param>
        public BaseData(string connectionStringName)
        {
            _connectionStringName = connectionStringName;
        }
    }
}
