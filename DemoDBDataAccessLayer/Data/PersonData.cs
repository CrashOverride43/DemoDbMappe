using System;
using System.Collections.Generic;
using System.Text;
using DemoDBDataAccessLayer.Models;
using DemoDBDataAccessLayer.DB;

namespace DemoDBDataAccessLayer.Data
{
    public class PersonData : BaseData, IData
    {
        public PersonData(string connectionStringName = "MySql") : base(connectionStringName) { }

        public List<PersonModel> SelectPersonByFirstname(string firstname)
        {
            string query = "SELECT * FROM Person WHERE Firstname = @Firstname;";
            return MySqlDbConnection.LoadData<PersonModel, dynamic>(query, new { Firstname = firstname }, _connectionStringName);
        }

        public int InsertPeople(List<PersonModel> people)
        {
            string query = "INSERT INTO Person (Firstname, Lastname, Email) VALUES (@Firstname, @Lastname, @Email);";
            return MySqlDbConnection.SaveData<dynamic>(query, people, _connectionStringName);
        }
        public List<T> SelectAll<T>()
        {
            string query = "SELECT * FROM Person;";
            return MySqlDbConnection.LoadData<T, dynamic>(query, new { }, _connectionStringName);
        }
    }
}
