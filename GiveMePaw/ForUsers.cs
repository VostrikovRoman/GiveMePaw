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

        // Изменение цвета кнопок меню (слева)

        // Главная
        private void ForUsers_Load(object sender, EventArgs e)
        {

            //Меню слева//
            start_color();
            /*
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
            
            account_button.Text = surname + " " + name.Substring(0, 1) + ".";*/

            //////////////////
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_dog_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = true;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
           

        }

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



        //Кнопки левого меню//
        private void Main_Tab_button_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtMainText.ForeColor = Color.FromArgb(92, 65, 48);
            Main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtMain.Image = new Bitmap(Properties.Resources.main_Active);

            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_dog_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = true;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
        }
        private void Give_Tab_button_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtGiveText.ForeColor = Color.FromArgb(92, 65, 48);
            Give_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtGive.Image = new Bitmap(Properties.Resources.give_Active);

            give_away_panel.Visible = true;
            pet_panel.Visible = false;
            many_dog_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
        }
        private void contact_Tab_button_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtContactText.ForeColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtContact.Image = new Bitmap(Properties.Resources.phone_Active);

            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_dog_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = true;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
        }
        private void info_Tab_button_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButInfo.ForeColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            picturePaw.Image = new Bitmap(Properties.Resources.info_Active);

            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_dog_panel.Visible = false;
            info_panel.Visible = true;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
        }


        private void defoult_color()
        {
            labelButtMainText.ForeColor = Color.FromArgb(228, 164, 84);
            Main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtGiveText.ForeColor = Color.FromArgb(228, 164, 84);
            Give_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtContactText.ForeColor = Color.FromArgb(228, 164, 84);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButInfo.ForeColor = Color.FromArgb(228, 164, 84);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);



            pictureButtMain.Image = new Bitmap(Properties.Resources.main_Passive);

            pictureButtGive.Image = new Bitmap(Properties.Resources.give_Passive);

            pictureButtContact.Image = new Bitmap(Properties.Resources.phone_Passive);

            picturePaw.Image = new Bitmap(Properties.Resources.info_Passive);

        }

        private void start_color()
        {
            labelButtMainText.ForeColor = Color.FromArgb(92, 65, 48);
            Main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);

            labelButtGiveText.ForeColor = Color.FromArgb(228, 164, 84);
            Give_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtContactText.ForeColor = Color.FromArgb(228, 164, 84);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButInfo.ForeColor = Color.FromArgb(228, 164, 84);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);



            pictureButtMain.Image = new Bitmap(Properties.Resources.main_Active);

            pictureButtGive.Image = new Bitmap(Properties.Resources.give_Passive);

            pictureButtContact.Image = new Bitmap(Properties.Resources.phone_Passive);

            picturePaw.Image = new Bitmap(Properties.Resources.info_Passive);

        }

        public string Animal = "";

        private void panel_dog_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = true;
            main_panel.Visible = false;
            label_title_pet.Text = "СОБАКИ";
            Animal = "dog";
        }

        private void panel_cat_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = true;
            main_panel.Visible = false;
            label_title_pet.Text = "КОШКИ";
            Animal = "cat";
        }

        private void panel_parrot_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = true;
            main_panel.Visible = false;
            label_title_pet.Text = "ПОПУГАИ";
            Animal = "parrot";
        }

        private void panel_rabbit_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = true;
            main_panel.Visible = false;
            label_title_pet.Text = "КРОЛИКИ";
            Animal = "rabbit";
        }

        private void panel_mouse_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = true;
            main_panel.Visible = false;
            label_title_pet.Text = "МЕЛКИЕ ГРЫЗУНЫ";
            Animal = "mouse";
        }




        private void back_button_many_pets_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = false;
            main_panel.Visible = true;
            Animal = "";
        }

        








        // panel.Visible = true;
        // название панели.Visible = true
    }
}



// label_cat.Parent = pictureBox_Dog;
// label_cat.BackColor = Color.Transparent;