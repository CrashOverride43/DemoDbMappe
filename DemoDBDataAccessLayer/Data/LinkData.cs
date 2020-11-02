using DemoDBDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Data
{
    public class LinkData : BaseData, IData
    {
        public LinkData (string connectionStringName = "MySql") : base(connectionStringName) { }

        public int InsertLink(List<LinkModel> link)
        {
            string query = "INSERT INTO Link (Linkname, Linkurl) VALUES (@Linkname, @Linkurl);";
            return MySqlDbConnection.SaveData<dynamic>(query, link, _connectionStringName);
        }

        public List<T> SelectAll<T>()
        {
            string query = "SELECT * FROM Link";
            return MySqlDbConnection.LoadData<T, dynamic>(query, new { }, _connectionStringName);
        }
    }
}
