using MySql.Data.MySqlClient;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
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

        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @eU OR `phone_number` = @phoneU", db.getConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = email_sign_up.Text;
            command.Parameters.Add("@phoneU", MySqlDbType.VarChar).Value = phone_sign_up.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

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
        
        private void save_button_sign_up_Click(object sender, EventArgs e)
        {
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

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                email_sign_in.Text = "email";
                password_sign_in.Text = "пароль";
                SignIn.ActiveForm.Hide();
                ForUsers NewForm = new ForUsers();
                NewForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль!");
            }
               
        }


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
