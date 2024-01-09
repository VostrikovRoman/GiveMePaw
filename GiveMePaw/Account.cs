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
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE email = @email", db.getConnection());
            MySqlParameter n1 = new MySqlParameter("@email", SignIn.user_email);
            command.Parameters.Add(n1);
            MySqlDataReader Reader = command.ExecuteReader();

            object surname = "";
            object name = "";
            object last_name = "";
            object phone = "";
            object password = "";
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    surname = Reader.GetValue(2);
                    name = Reader.GetValue(1);
                    last_name = Reader.GetValue(3);
                    phone = Reader.GetValue(5);
                    password = Reader.GetValue(6);
                }
            }
            db.closeConnection();



            surname_account.BackColor = surname_account.BackColor;
            name_account.BackColor = name_account.BackColor;
            last_name_account.BackColor = last_name_account.BackColor;
            email_account.BackColor = email_account.BackColor;
            phone_account.BackColor = phone_account.BackColor;
            password_account.BackColor = password_account.BackColor;

            surname_account.Text = Convert.ToString(surname);
            name_account.Text = Convert.ToString(name);
            last_name_account.Text = Convert.ToString(last_name);
            email_account.Text = SignIn.user_email;
            phone_account.Text = Convert.ToString(phone);
            password_account.Text = Convert.ToString(password);

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
            delete_button_account.Visible = true;
            ButtChangePass.Visible = true;
        }

        private void cancel_button_account_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить изменения?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DB db = new DB();
                    db.openConnection();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE email = @email", db.getConnection());
                    MySqlParameter n1 = new MySqlParameter("@email", SignIn.user_email);
                    command.Parameters.Add(n1);
                    MySqlDataReader Reader = command.ExecuteReader();

                    object surname = "";
                    object name = "";
                    object last_name = "";
                    object phone = "";
                    object password = "";
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            surname = Reader.GetValue(2);
                            name = Reader.GetValue(1);
                            last_name = Reader.GetValue(3);
                            phone = Reader.GetValue(5);
                            password = Reader.GetValue(6);
                        }
                    }
                    db.closeConnection();

                    surname_account.Text = Convert.ToString(surname);
                    name_account.Text = Convert.ToString(name);
                    last_name_account.Text = Convert.ToString(last_name);
                    email_account.Text = SignIn.user_email;
                    phone_account.Text = Convert.ToString(phone);
                    password_account.Text = Convert.ToString(password);

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
                    delete_button_account.Visible = false;
                    ButtChangePass.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка!" + ex);
                }
            }
            
            
        }

        private void save_button_account_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    Hashing GH = new Hashing();
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
                    MySqlParameter n6 = new MySqlParameter("@password", GH.Hash(password_account.Text));
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
                    delete_button_account.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка!" + ex);
                }
            }
            
            
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
            string Out = "";
            if (MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    SaveFile(Out, "checkSignIn.txt");
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

        private void delete_button_account_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить свой аккаунт?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DB db = new DB();
                    db.openConnection();
                    MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE email = @email", db.getConnection());
                    MySqlParameter n1 = new MySqlParameter("@email", SignIn.user_email);
                    command.Parameters.Add(n1);
                    command.ExecuteNonQuery();
                    db.closeConnection();
                    File.WriteAllText("","checkSignIn.txt");
                    Account.ActiveForm.Hide();
                    SignIn NewForm = new SignIn();
                    NewForm.ShowDialog();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            
        }

        //Функция записи текстового файла//
        void SaveFile(string a, string b)
        {
            try
            {
                File.WriteAllText(b, a);
            }
            catch 
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void ButtChangePass_Click(object sender, EventArgs e)
        {
            panelChangePass.Visible = true;
            ButtChangePass.Visible = false;
            delete_button_account.Visible = false;



        }
        private void panelCancelChangePass_Click_1(object sender, EventArgs e)
        {
            panelChangePass.Visible = false;
            ButtChangePass.Visible = true;
            delete_button_account.Visible = true;
            tBLastPass.Text = "";
            tBNewPass.Text = "";
        }

        private void panelSavePass_Click(object sender, EventArgs e)
        {
            Hashing GH = new Hashing();
            if (GH.Hash(tBLastPass.Text) == password_account.Text)
            {
                try
                {

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DB db = new DB();
                    db.openConnection();

                    MySqlCommand command = new MySqlCommand("UPDATE users SET password=@password WHERE email = @old_email", db.getConnection());
                    MySqlParameter n1 = new MySqlParameter("@old_email", SignIn.user_email);
                    command.Parameters.Add(n1);
                    MySqlParameter n2 = new MySqlParameter("@password", GH.Hash(tBNewPass.Text));
                    command.Parameters.Add(n2);
                    command.ExecuteNonQuery();
                    db.closeConnection();
                    MessageBox.Show("Успешно!");
                    panelChangePass.Visible = false;
                    ButtChangePass.Visible = true;
                    delete_button_account.Visible = true;
                    tBLastPass.Text = "";
                    tBNewPass.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка!" + ex);
                }
            }
        }
    }
}
