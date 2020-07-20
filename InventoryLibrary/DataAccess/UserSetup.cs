using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryLibrary.DataAccess
{
    public class UserSetup
    {
        public UserSetup()
        {

        }

        public static void CreateUser(UserModel user)
        {

            string sqlQuery = "INSERT INTO User(FirstName, LastName, Email, PhoneNumber, FineAmount, Admin, Password) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @FineAmount, @Admin, @Password)";


            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }


                //            SQLiteCommand mycom = cnn.CreateCommand(sqlQuery);

                cnn.Execute(sqlQuery, user);
                cnn.Close();

                /*
                 * INSERT INTO "main"."User"("UserID","FirstName","LastName","Email","PhoneNumber","FineAmount","Password") VALUES (4,'','','',NULL,NULL,'');

                 */


            }
            
        }

        public static string Login(string email, string pw)
        {
            string loginQuery = "SELECT * FROM User WHERE Email = @Email AND Password = @Password";
            /* using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
             {
 */
            // cnn.Open();
            SQLiteConnection conn = new SQLiteConnection(LoadConnectionString());
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(loginQuery, conn);
            //var output = cnn.Query<UserModel> ("select Password From User Where Email = " + email);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", pw);
            var dt = new DataTable();

            using (var da = new SQLiteDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            //SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            //da.
            //cmd.ExecuteScalar();
            //

            //  da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You are Logged in", "Login Succesful");
                conn.Close();
                return email;
            }
            else
            {
                MessageBox.Show("Login Failed");
                conn.Close();
                return "_failedLogin";
            }
        }

       
        public static DataTable GetAccount(string email)
        {

            string AccountQuery = "SELECT* FROM User WHERE Email = @Email";

            // cnn.Open();
            SQLiteConnection conn = new SQLiteConnection(LoadConnectionString());
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(AccountQuery, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            var dt = new DataTable();

            using (var da = new SQLiteDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            return dt;
            /* using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
             {
                // cnn.para
                = cnn.Query<UserModel>("SELECT * FROM User WHERE Email = @Email", new DynamicParameters());
 */
            //return output.ToList();
           /* }*/

        }



        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
