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
            MySqlCommand command = new MySqlCommand("SELECT ", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_sign_up.Text;
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = surname_sign_up.Text;
            command.Parameters.Add("@patronomic", MySqlDbType.VarChar).Value = last_name_sign_up.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_sign_up.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone_sign_up.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password_sign_up.Text;

            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
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

        }
    }
}
