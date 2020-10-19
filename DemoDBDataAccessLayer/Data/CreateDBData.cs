using DemoDBDataAccessLayer.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Data
{
    public class CreateDBData : BaseData
    {
        public CreateDBData(string connectionStringName = "MySql") : base(connectionStringName) { }

        public int createDataBase(string query, ISqlDbConnection dbConnection)
        {
            return dbConnection.SaveData<dynamic>(query, new { }, _connectionStringName);
        }
    }
}
