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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @eU OR `phone_number` = @phoneU", db.getConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = email_sign_up.Text;
            command.Parameters.Add("@phoneU", MySqlDbType.VarChar).Value = phone_sign_up.Text;

            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким email или номер телефона существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void link_to_sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInDisplay.Visible = false;
            SignUpDisplay.Visible = true;

            email_sign_in.Text = "email";
            password_sign_in.Text = "пароль";

        }

        private void link_to_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInDisplay.Visible = true;
            SignUpDisplay.Visible = false;

            surname_sign_up.Text = "фамилия";
            name_sign_up.Text = "имя";
            last_name_sign_up.Text = "отчество";
            phone_sign_up.Text = "телефон";
            email_sign_up.Text = "email";
            password_sign_up.Text = "пароль";
        }

        private void save_button_sign_up_Click(object sender, EventArgs e)
        {
            if (surname_sign_up.Text == "фамилия" | name_sign_up.Text == "имя" | last_name_sign_up.Text == "отчество" | phone_sign_up.Text == "телефон" | email_sign_up.Text == "email" | password_sign_up.Text == "пароль")
            {
                MessageBox.Show("Заполните всё колонки");
                return;
            }
            
            
            if (isUserExists())
                return;
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `second_name`, `patronomic`, `email`, `phone_number`, `password`) VALUES (@name, @sname, @patronomic, @email, @phone, @pass)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_sign_up.Text;
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = surname_sign_up.Text;
            command.Parameters.Add("@patronomic", MySqlDbType.VarChar).Value = last_name_sign_up.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_sign_up.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone_sign_up.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password_sign_up.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                surname_sign_up.Text = "фамилия";
                name_sign_up.Text = "имя";
                last_name_sign_up.Text = "отчество";
                phone_sign_up.Text = "телефон";
                email_sign_up.Text = "email";
                password_sign_up.Text = "пароль";
                SignInDisplay.Visible = true;
                SignUpDisplay.Visible = false;
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            db.closeConnection();
            
            
            
            
            
            
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            String emailUser = email_sign_in.Text;
            String passwordUser = password_sign_in.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @eU AND `password` = @pU", db.getConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = emailUser;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passwordUser;
            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();

            db.openConnection();
            MySqlCommand role = new MySqlCommand("SELECT role FROM `users` WHERE `email` = @eU AND `password` = @pU", db.getConnection());
            MySqlParameter n1 = new MySqlParameter("@eU", emailUser);
            role.Parameters.Add(n1);
            MySqlParameter n2 = new MySqlParameter("@pU", passwordUser);
            role.Parameters.Add(n2);
            string role_id = Convert.ToString(role.ExecuteScalar());
            role.ExecuteNonQuery();
            db.closeConnection();

            if (table.Rows.Count > 0)
            {
                user_email = emailUser;
                email_sign_in.Text = "email";
                password_sign_in.Text = "пароль";

                if (remember_me_button.Checked == true)
                {
                    SaveFile(emailUser, "checkSignIn.txt");
                }

                if (role_id == "3")
                {
                    SignIn.ActiveForm.Hide();
                    ForUsers NewForm = new ForUsers();
                    NewForm.ShowDialog();
                    Close();
                }
                else if (role_id == "1")
                {
                    SignIn.ActiveForm.Hide();
                    ForEmployers NewForm = new ForEmployers();
                    NewForm.ShowDialog();
                    Close();
                }
                else if (role_id == "2")
                {
                    SignIn.ActiveForm.Hide();
                    ForEmployers NewForm = new ForEmployers();
                    NewForm.ShowDialog();
                    Close();
                }
            }
            else
            {
                email_sign_in.ForeColor = Color.Firebrick;
                password_sign_in.ForeColor = Color.Firebrick;
                email_sign_in.Text = "email";
                password_sign_in.Text = "пароль";
                password_sign_in.UseSystemPasswordChar = false;
                textBox1.Focus();
            }
               
        }
        public static string user_email = "";

        //Функция записи текстового файла//
        void SaveFile(string a, string b)
        {
            try
            {
                File.Create(b).Close();
                File.WriteAllText(b, a);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }
        /////////

        /////Текст-подсказка для формы входа и регистрации/////
        private void email_sign_in_Enter(object sender, EventArgs e)
        {
           if (email_sign_in.Text == "email")
            {
                email_sign_in.Text = "";
            }
        }
        private void email_sign_in_Leave(object sender, EventArgs e)
        {
            if (email_sign_in.Text == "")
            {
                email_sign_in.Text = "email";
            }
        }

        private void password_sign_in_Enter(object sender, EventArgs e)
        {
            if (password_sign_in.Text == "пароль")
            {
                password_sign_in.Text = "";
                password_sign_in.UseSystemPasswordChar = true;
            }
        }

        private void password_sign_in_Leave(object sender, EventArgs e)
        {
            if (password_sign_in.Text == "")
            {
                password_sign_in.Text = "пароль";
                password_sign_in.UseSystemPasswordChar = false;
            }
            else
            {
                password_sign_in.UseSystemPasswordChar = true;
            }
        }

        private void surname_sign_up_Enter(object sender, EventArgs e)
        {
            if (surname_sign_up.Text == "фамилия")
            {
                surname_sign_up.Text = "";
            }
        }

        private void surname_sign_up_Leave(object sender, EventArgs e)
        {
            if (surname_sign_up.Text == "")
            {
                surname_sign_up.Text = "фамилия";
            }
        }

        private void name_sign_up_Enter(object sender, EventArgs e)
        {
            if (name_sign_up.Text == "имя")
            {
                name_sign_up.Text = "";
            }
        }

        private void name_sign_up_Leave(object sender, EventArgs e)
        {
            if (name_sign_up.Text == "")
            {
                name_sign_up.Text = "имя";
            }
        }

        private void last_name_sign_up_Enter(object sender, EventArgs e)
        {
            if (last_name_sign_up.Text == "отчество")
            {
                last_name_sign_up.Text = "";
            }
        }

        private void last_name_sign_up_Leave(object sender, EventArgs e)
        {
            if (last_name_sign_up.Text == "")
            {
                last_name_sign_up.Text = "отчество";
            }
        }

        private void phone_sign_up_Enter(object sender, EventArgs e)
        {
            if (phone_sign_up.Text == "телефон")
            {
                phone_sign_up.Text = "";
            }
        }

        private void phone_sign_up_Leave(object sender, EventArgs e)
        {
            if (phone_sign_up.Text == "")
            {
                phone_sign_up.Text = "телефон";
            }
        }

        private void email_sign_up_Enter(object sender, EventArgs e)
        {
            if (email_sign_up.Text == "email")
            {
                email_sign_up.Text = "";
            }
        }

        private void email_sign_up_Leave(object sender, EventArgs e)
        {
            if (email_sign_up.Text == "")
            {
                email_sign_up.Text = "email";
            }
        }

        private void password_sign_up_Enter(object sender, EventArgs e)
        {
            if (password_sign_up.Text == "пароль")
            {
                password_sign_up.Text = "";
            }
        }

        private void password_sign_up_Leave(object sender, EventArgs e)
        {
            if (password_sign_up.Text == "")
            {
                password_sign_up.Text = "пароль";
            }
        }
        /////     /////
    }
}
