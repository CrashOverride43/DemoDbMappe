using System.Collections.Generic;

namespace DemoDBDataAccessLayer.DB
{
    public interface ISqlDbConnection
    {
        List<T> LoadData<T, U>(string query, U parameter, string connectionStringName);
        int SaveData<U>(string query, U parameter, string connectionStringName);
        int InsertData<U>(string query, U parameters, string connectionStringName);
    }
}