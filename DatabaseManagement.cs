using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace GroupProject
{
    class DatabaseManagement
    {
        private static MySqlConnection conn;

        public static void DbInitialize()
        {
            DbInit();
        }

        private static void DbInit() //Db Connection Method
        {
            
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "sql2.freemysqlhosting.net";
            conn_string.UserID = "sql2231281";
            conn_string.Password = "mA2*xJ5*";
            conn_string.Database = "sql2231281";
            conn = new MySqlConnection(conn_string.ToString());
        }

        //open connection to database
        private static bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (MySqlException ex)
            {
               // MessageBox.Show(ex.Message);
                return false;
            }
        }



        public static List<string> LoginCommand(string username,string password)
        {
            if (OpenConnection() == true)
            {
                List<string> list = new List<string>();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    MySqlDataReader reader;
                    cmd.CommandText = string.Format("Select * From employee where username = '{0}' and password = '{1}'", username, password);
                    //cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(reader["employeeNo"] + "");
                            list.Add(reader["username"] + "");
                            list.Add(reader["role"] + "");
                        }
                    }
                    else
                    {
                    }
                    reader.Close();
                    CloseConnection();
                    return list;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
