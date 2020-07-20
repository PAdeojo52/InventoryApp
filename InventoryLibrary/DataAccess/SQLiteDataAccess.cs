using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    class SQLiteDataAccess
    {
        //Create PErson Model
        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUsers(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User(FirstName, LastName, Email, PhoneNumber , FineAmount, Admin) values (@FirstName, @LastName, @Email, @PhoneNumber , @FineAmount, @Admin)",user);
            }
        }

        private static string LoadConnectionString(string id ="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
