﻿using MySql.Data.MySqlClient;
using System;
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
            email_account.ReadOnly = false;
            phone_account.ReadOnly = false;
            password_account.ReadOnly = false;

            surname_account.ForeColor = Color.Black;
            name_account.ForeColor = Color.Black;
            last_name_account.ForeColor = Color.Black;
            email_account.ForeColor = Color.Black;
            phone_account.ForeColor = Color.Black;
            password_account.ForeColor = Color.Black;

            update_button_account.Visible = false;
            save_button_account.Visible = true;
            cancel_button_account.Visible = true;
        }

        private void cancel_button_account_Click(object sender, EventArgs e)
        {
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

            update_button_account.Visible = true;
            save_button_account.Visible = false;
            cancel_button_account.Visible = false;
        }

        private void save_button_account_Click(object sender, EventArgs e)
        {
            string surname = surname_account.Text;
            string name = name_account.Text;
            string last_name = last_name_account.Text;
            string email = email_account.Text;
            string phone = phone_account.Text;
            string password = password_account.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE users SET second_name=@surname, name=@name, patronomic=@last_name, email=@new_email, phone_number=@phone, password=@password WHERE email = @old_email", db.getConnection());
            MySqlParameter n1 = new MySqlParameter("@old_email", SignIn.user_email);
            command.Parameters.Add(n1);
            MySqlParameter n2 = new MySqlParameter("@surname", surname);
            command.Parameters.Add(n2);
            MySqlParameter n3 = new MySqlParameter("@name", name);
            command.Parameters.Add(n3);
            MySqlParameter n4 = new MySqlParameter("@email", email);
            command.Parameters.Add(n4);
            MySqlParameter n5 = new MySqlParameter("@phone", phone);
            command.Parameters.Add(n5);
            MySqlParameter n6 = new MySqlParameter("@password", password);
            command.Parameters.Add(n6);
            db.closeConnection();

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

            update_button_account.Visible = true;
            save_button_account.Visible = false;
            cancel_button_account.Visible = false;
        }

        private void back_button_account_Click(object sender, EventArgs e)
        {
            Account.ActiveForm.Hide();
            ForUsers NewForm = new ForUsers();
            NewForm.ShowDialog();
            Close();
        }

        private void exit_button_account_Click(object sender, EventArgs e)
        {
            Account.ActiveForm.Hide();
            SignIn NewForm = new SignIn();
            NewForm.ShowDialog();
            Close();
        }
    }
}
