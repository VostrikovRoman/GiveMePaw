using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiveMePaw
{
    
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            db.openConnection();
            //Surname//
            MySqlCommand command_surname = new MySqlCommand("SELECT second_name FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n1 = new MySqlParameter("@email", SignIn.user_email);
            command_surname.Parameters.Add(n1);
            string surname = (string)command_surname.ExecuteScalar();
            command_surname.ExecuteNonQuery();
            //Name//
            MySqlCommand command_name = new MySqlCommand("SELECT name FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n2 = new MySqlParameter("@email", SignIn.user_email);
            command_name.Parameters.Add(n2);
            string name = (string)command_name.ExecuteScalar();
            command_name.ExecuteNonQuery();
            //Last_name//
            MySqlCommand command_last_name = new MySqlCommand("SELECT patronomic FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n3 = new MySqlParameter("@email", SignIn.user_email);
            command_last_name.Parameters.Add(n3);
            string last_name = (string)command_last_name.ExecuteScalar();
            command_last_name.ExecuteNonQuery();
            //Email//
            MySqlCommand command_email = new MySqlCommand("SELECT email FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n4 = new MySqlParameter("@email", SignIn.user_email);
            command_email.Parameters.Add(n4);
            string email = (string)command_email.ExecuteScalar();
            command_email.ExecuteNonQuery();
            //Phone//
            MySqlCommand command_phone = new MySqlCommand("SELECT phone_number FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n5 = new MySqlParameter("@email", SignIn.user_email);
            command_phone.Parameters.Add(n5);
            string phone = (string)command_phone.ExecuteScalar();
            command_phone.ExecuteNonQuery();
            //Password//
            MySqlCommand command_password = new MySqlCommand("SELECT password FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n6 = new MySqlParameter("@email", SignIn.user_email);
            command_password.Parameters.Add(n6);
            string password = (string)command_password.ExecuteScalar();
            command_password.ExecuteNonQuery();


            db.closeConnection();

            surname_account.BackColor = surname_account.BackColor;
            name_account.BackColor = name_account.BackColor;
            last_name_account.BackColor = last_name_account.BackColor;
            email_account.BackColor = email_account.BackColor;
            phone_account.BackColor = phone_account.BackColor;
            password_account.BackColor = password_account.BackColor;

            surname_account.Text = surname;
            name_account.Text = name;
            last_name_account.Text = last_name;
            email_account.Text = email;
            phone_account.Text = phone;
            password_account.Text = password;

            surname_account.ReadOnly = true;
            name_account.ReadOnly = true;
            last_name_account.ReadOnly = true;
            email_account.ReadOnly = true;
            phone_account.ReadOnly = true;
            password_account.ReadOnly = true;
            
            surname_account.ForeColor = Color.Gray;
            name_account.ForeColor = Color.Gray;
            last_name_account.ForeColor = Color.Gray;
            email_account.ForeColor = Color.Gray;
            phone_account.ForeColor = Color.Gray;
            password_account.ForeColor = Color.Gray;
        }

        private void update_button_account_Click(object sender, EventArgs e)
        {
            surname_account.ReadOnly = false;
            name_account.ReadOnly = false;
            last_name_account.ReadOnly = false;
            password_account.ReadOnly = false;

            surname_account.ForeColor = Color.Black;
            name_account.ForeColor = Color.Black;
            last_name_account.ForeColor = Color.Black;
            password_account.ForeColor = Color.Black;

            update_button_account.Visible = false;
            save_button_account.Visible = true;
            cancel_button_account.Visible = true;
        }

        private void cancel_button_account_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            db.openConnection();
            //Surname//
            MySqlCommand command_surname = new MySqlCommand("SELECT second_name FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n1 = new MySqlParameter("@email", SignIn.user_email);
            command_surname.Parameters.Add(n1);
            string surname = (string)command_surname.ExecuteScalar();
            command_surname.ExecuteNonQuery();
            //Name//
            MySqlCommand command_name = new MySqlCommand("SELECT name FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n2 = new MySqlParameter("@email", SignIn.user_email);
            command_name.Parameters.Add(n2);
            string name = (string)command_name.ExecuteScalar();
            command_name.ExecuteNonQuery();
            //Last_name//
            MySqlCommand command_last_name = new MySqlCommand("SELECT patronomic FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n3 = new MySqlParameter("@email", SignIn.user_email);
            command_last_name.Parameters.Add(n3);
            string last_name = (string)command_last_name.ExecuteScalar();
            command_last_name.ExecuteNonQuery();
            //Email//
            MySqlCommand command_email = new MySqlCommand("SELECT email FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n4 = new MySqlParameter("@email", SignIn.user_email);
            command_email.Parameters.Add(n4);
            string email = (string)command_email.ExecuteScalar();
            command_email.ExecuteNonQuery();
            //Phone//
            MySqlCommand command_phone = new MySqlCommand("SELECT phone_number FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n5 = new MySqlParameter("@email", SignIn.user_email);
            command_phone.Parameters.Add(n5);
            string phone = (string)command_phone.ExecuteScalar();
            command_phone.ExecuteNonQuery();
            //Password//
            MySqlCommand command_password = new MySqlCommand("SELECT password FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n6 = new MySqlParameter("@email", SignIn.user_email);
            command_password.Parameters.Add(n6);
            string password = (string)command_password.ExecuteScalar();
            command_password.ExecuteNonQuery();


            db.closeConnection();

            surname_account.Text = surname;
            name_account.Text = name;
            last_name_account.Text = last_name;
            email_account.Text = email;
            phone_account.Text = phone;
            password_account.Text = password;

            surname_account.ReadOnly = true;
            name_account.ReadOnly = true;
            last_name_account.ReadOnly = true;
            password_account.ReadOnly = true;

            surname_account.ForeColor = Color.Gray;
            name_account.ForeColor = Color.Gray;
            last_name_account.ForeColor = Color.Gray;
            email_account.ForeColor = Color.Gray;
            phone_account.ForeColor = Color.Gray;
            password_account.ForeColor = Color.Gray;

            update_button_account.Visible = true;
            save_button_account.Visible = false;
            cancel_button_account.Visible = false;
        }

        private void save_button_account_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE users SET name=@name, second_name=@surname, patronomic=@last_name, email=@new_email, phone_number=@phone, password=@password WHERE email = @old_email", db.getConnection());
            MySqlParameter n1 = new MySqlParameter("@old_email", SignIn.user_email);
            command.Parameters.Add(n1);
            MySqlParameter n2 = new MySqlParameter("@surname", surname_account.Text);
            command.Parameters.Add(n2);
            MySqlParameter n3 = new MySqlParameter("@name", name_account.Text);
            command.Parameters.Add(n3);
            MySqlParameter n4 = new MySqlParameter("@new_email", email_account.Text);
            command.Parameters.Add(n4);
            MySqlParameter n5 = new MySqlParameter("@phone", phone_account.Text);
            command.Parameters.Add(n5);
            MySqlParameter n6 = new MySqlParameter("@password", password_account.Text);
            command.Parameters.Add(n6);
            MySqlParameter n7 = new MySqlParameter("@last_name", last_name_account.Text);
            command.Parameters.Add(n7);
            command.ExecuteNonQuery();
            db.closeConnection();

            surname_account.ReadOnly = true;
            name_account.ReadOnly = true;
            last_name_account.ReadOnly = true;
            password_account.ReadOnly = true;

            surname_account.ForeColor = Color.Gray;
            name_account.ForeColor = Color.Gray;
            last_name_account.ForeColor = Color.Gray;
            email_account.ForeColor = Color.Gray;
            phone_account.ForeColor = Color.Gray;
            password_account.ForeColor = Color.Gray;
            

            update_button_account.Visible = true;
            save_button_account.Visible = false;
            cancel_button_account.Visible = false;
        }



        private void back_button_account_Click(object sender, EventArgs e)
        {
            try
            {
                if (SignIn.Remember == "") 
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

                    if (role_id == "1" || role_id == "2")
                    {
                        Account.ActiveForm.Hide();
                        ForEmployers NewForm = new ForEmployers();
                        NewForm.ShowDialog();
                        Close();
                    }
                    else if (role_id == "3")
                    {
                        Account.ActiveForm.Hide();
                        ForUsers NewForm = new ForUsers();
                        NewForm.ShowDialog();
                        Close();
                    }

                }
                else if (SignIn.Remember == "a")
                {
                    Account.ActiveForm.Hide();
                    ForEmployers NewForm = new ForEmployers();
                    NewForm.ShowDialog();
                    Close();
                }
                else if (SignIn.Remember == "p")
                {
                    Account.ActiveForm.Hide();
                    ForUsers NewForm = new ForUsers();
                    NewForm.ShowDialog();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }

        }

        private void exit_button_account_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("checkSignIn.txt");
                Account.ActiveForm.Hide();
                SignIn NewForm = new SignIn();
                NewForm.ShowDialog();
                Close();
                
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

    }
}
