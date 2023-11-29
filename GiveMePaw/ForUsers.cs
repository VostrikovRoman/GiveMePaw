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
    public partial class ForUsers : Form
    {
        public ForUsers()
        {
            InitializeComponent();
        }

        

        // Главная
        private void ForUsers_Load(object sender, EventArgs e)
        {
            //Для того, чтобы в профиле отображалось имя пользователя//
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

            account_button.Text = surname + " " + name.Substring(0, 1) + ".";

            //////////////////




            // Изменение цвета кнопок меню (слева)

            main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            //


        }

        // открыть форму account
        private void account_button_Click(object sender, EventArgs e)
        {
            ForUsers.ActiveForm.Hide();
            Account NewForm = new Account();
            NewForm.ShowDialog();
            Close();
        }

        private void back_button_for_users_Click(object sender, EventArgs e)
        {
            Close();
        }


        // кнопка выхода
     
        // Кнопки меню *(слева)
        private void give_away_Tab_button_Click(object sender, EventArgs e)
        {
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
         
        }

        private void contact_Tab_button_Click(object sender, EventArgs e)
        {
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
        }

        private void info_Tab_button_Click(object sender, EventArgs e)
        {
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
        }












        // panel.Visible = true;
        // название панели.Visible = true
    }
}



// label_cat.Parent = pictureBox_Dog;
// label_cat.BackColor = Color.Transparent;