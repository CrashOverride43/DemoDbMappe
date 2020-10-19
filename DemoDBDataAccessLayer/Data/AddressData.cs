using DemoDBDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Data
{
    /// <summary>
    /// Sammlung aller Methoden, um Daten in AddressTable zu schreiben und aus ihr zu Lesen.
    /// </summary>
    public class AddressData : BaseData, IData
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="connectionStringName">Siehe BaseData</param>
        public AddressData(string connectionStringName = "MySql") : base(connectionStringName) { }

        /// <summary>
        /// Definiert eine Query zur Abfrage aller Adressen.
        /// </summary>
        /// <returns>Gibt die Selektierten Adressen als Liste zurück.</returns>

        public List<T> SelectAll<T>()
        {
            string query = "SELECT * FROM Address;";
            return MySqlDbConnection.LoadData<T, dynamic>(query, new { }, _connectionStringName);
        }
    }
}
