using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace GiveMePaw
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (File.ReadAllText("checkSignIn.txt") != "")
                {
                    string emailUser = File.ReadAllText("checkSignIn.txt");

                    DB db = new DB();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    db.openConnection();
                    MySqlCommand role = new MySqlCommand("SELECT role FROM `users` WHERE `email` = @eU", db.getConnection());
                    MySqlParameter n1 = new MySqlParameter("@eU", emailUser);
                    role.Parameters.Add(n1);
                    string role_id = Convert.ToString(role.ExecuteScalar());
                    role.ExecuteNonQuery();
                    db.closeConnection();

                    SignIn.user_email = emailUser;

                    if (role_id=="1" || role_id == "2")
                    {
                        Application.Run(new ForEmployers());
                    }
                    else if (role_id == "3")
                    {
                        Application.Run(new ForUsers());
                    }

                }
                else
                {
                    Application.Run(new SignIn());
                }
                
            }
            catch
            {
                Application.Run(new Lost_Internet());
            }
        }
    }
}
