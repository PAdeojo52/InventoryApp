using Dapper;
using InventoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.DataAccess
{
   public class EquipmentSetup
    {
        public EquipmentSetup()
        {

        }

        public static void CreateEquipment(EquipmentModel equipment)
        {
            string sqlQuery = "INSERT INTO Equipment(MacAddress, Make, Model, IsCheckedOut, CheckedOutBy, Type) Values (@MacAddress, @Make, @Model, @IsCheckedOut, @CheckedOutBy, @Type)";


            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }


                //            SQLiteCommand mycom = cnn.CreateCommand(sqlQuery);

                cnn.Execute(sqlQuery, equipment);
                cnn.Close();

                /*
                 * INSERT INTO "main"."User"("UserID","FirstName","LastName","Email","PhoneNumber","FineAmount","Password") VALUES (4,'','','',NULL,NULL,'');

                 */
            }
        }

        public static List<EquipmentModel> LoadEquipment()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EquipmentModel>("SELECT * FROM Equipment WHERE IsCheckedOut = 0" , new DynamicParameters());

                return output.ToList();
            }


         }

        public static List<EquipmentModel> LoadDesktop()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EquipmentModel>("SELECT * FROM Equipment WHERE Type = 'Desktop' AND IsCheckedOut = 0 ", new DynamicParameters());

                return output.ToList();
            }


        }

        public static List<EquipmentModel> LoadLaptop()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EquipmentModel>("SELECT * FROM Equipment WHERE Type = 'Laptop' AND IsCheckedOut = 0 ", new DynamicParameters());


                return output.ToList();
            }


        }



        public static List<EquipmentModel> LoadPhone()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EquipmentModel>("SELECT * FROM Equipment WHERE Type = 'Phone' AND IsCheckedOut = 0 ", new DynamicParameters());

                return output.ToList();
            }


        }



        public static List<EquipmentModel> LoadCheckedOutEquipment(string ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EquipmentModel>("SELECT * FROM Equipment WHERE CheckedOutBy = '" + ID + "' AND IsCheckedOut = 1", new DynamicParameters());
                
                return output.ToList();
            }
        }



            public static void CheckOut(string ID, string MacAddress)
            {
            string updateQuery = "Update Equipment Set IsCheckedOut = 1 , CheckedOutBy = @ID  WHERE MacAddress = @MacAddress";

            SQLiteConnection conn = new SQLiteConnection(LoadConnectionString());
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@MacAddress", MacAddress);

            cmd.ExecuteNonQuery();
            conn.Close();

             }


        public static void CheckIn(string MacAddress)
        {
            string updateQuery = "Update Equipment Set IsCheckedOut = 0 , CheckedOutBy = NULL  WHERE MacAddress = @MacAddress";


            SQLiteConnection conn = new SQLiteConnection(LoadConnectionString());
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@MacAddress", MacAddress);
            cmd.ExecuteNonQuery();
            conn.Close();
            /* using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
             {
                 using (SQLiteCommand command = new SQLiteCommand(cnn))
                 {
                 }
             }*/
        }


        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
