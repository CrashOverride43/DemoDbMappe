using DemoDBDataAccessLayer.DB;
using DemoDBDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Data
{
    public class CompanyData : BaseData, IData
    {
        public CompanyData(string connectionStringName = "MySql") : base(connectionStringName) { }

        public List<T> SelectAll<T>()
        {
            string query = "SELECT * FROM Company;";
            return MySqlDbConnection.LoadData<T, dynamic>(query, new { }, _connectionStringName);
        }
    }
}
