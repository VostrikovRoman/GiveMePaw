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
<<<<<<< HEAD
<<<<<<< HEAD
=======
       
>>>>>>> parent of b6674f6 (17.12.23 12:58)
=======
            //Меню слева//
            start_color();
<<<<<<< HEAD
       
>>>>>>> parent of 8cdf5d2 (19.12.23 7:18)
=======
            /*
>>>>>>> parent of 987a097 (21.12.23 16:20)
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
<<<<<<< HEAD

            account_button.Text = surname + " " + name.Substring(0, 1) + ".";
=======
            
            account_button.Text = surname + " " + name.Substring(0, 1) + ".";*/
>>>>>>> parent of 987a097 (21.12.23 16:20)

            //////////////////
<<<<<<< HEAD

            main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

<<<<<<< HEAD


        }

        private void main_Tab_button_Click(object sender, EventArgs e)
        {
=======
=======

            //main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            //give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = true;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
           

            
<<<<<<< HEAD
>>>>>>> parent of b6674f6 (17.12.23 12:58)
            label_dog.Parent = pictureBox_Dog;
            label_dog.BackColor = Color.Transparent;

            label_c.Parent = pictureBox_Cat;
            label_c.BackColor = Color.Transparent;

            label_p.Parent = pictureBox_Parrot;
            label_p.BackColor = Color.Transparent;

            label_r.Parent = pictureBox_Rabbit;
            label_r.BackColor = Color.Transparent;

<<<<<<< HEAD
            label_m.Parent = pictureBox_Mouse;
            label_m.BackColor = Color.Transparent;
>>>>>>> parent of 1f79cf1 (16.12.23 12:56)
=======
            label_mouse.Parent = pictureBox_Mouse;
            label_mouse.BackColor = Color.Transparent;
>>>>>>> parent of b6674f6 (17.12.23 12:58)

        }

        private void give_away_Tab_button_Paint(object sender, PaintEventArgs e)
        {
=======
            /*label_dog.Parent = pictureBox_Dog;
            label_dog.BackColor = Color.Transparent;

            label_cat.Parent = pictureBox_Cat;
            label_cat.BackColor = Color.Transparent;

            label_parrot.Parent = pictureBox_Parrot;
            label_parrot.BackColor = Color.Transparent;

            label_rabbit.Parent = pictureBox_Rabbit;
            label_rabbit.BackColor = Color.Transparent;

            label_mouse.Parent = pictureBox_Mouse;
            label_mouse.BackColor = Color.Transparent;*/


>>>>>>> parent of 8cdf5d2 (19.12.23 7:18)

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

        // сдать животное
        private void pictureBox4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            give_away_panel.Visible = true;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(164, 123, 81); 
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
=======
            defoult_color();
            labelButtMainText.ForeColor = Color.FromArgb(92, 65, 48);
            Main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtMain.Image = new Bitmap(Properties.Resources.main_Active);
>>>>>>> parent of 8cdf5d2 (19.12.23 7:18)
        }

<<<<<<< HEAD
=======
        private void label3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            give_away_panel.Visible = true;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

        }

        private void give_away_Tab_button_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = true;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
=======
            defoult_color();
            labelButtGiveText.ForeColor = Color.FromArgb(92, 65, 48);
            Give_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtGive.Image = new Bitmap(Properties.Resources.give_Active);
>>>>>>> parent of 8cdf5d2 (19.12.23 7:18)
        }

        // контакты

        private void contact_Tab_button_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = true;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48); 
            contact_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
<<<<<<< HEAD
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = true;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48); 
            contact_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = true;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48); 
            contact_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
=======
            pictureButtContact.Image = new Bitmap(Properties.Resources.phone_Active);
>>>>>>> parent of 8cdf5d2 (19.12.23 7:18)
        }
        // инфо

        private void info_Tab_button_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = true;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48); 
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48); 
            info_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
<<<<<<< HEAD
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = true;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
=======
            picturePaw.Image = new Bitmap(Properties.Resources.info_Active);
>>>>>>> parent of 8cdf5d2 (19.12.23 7:18)
        }

        private void label5_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = true;
            contacts_panel.Visible = false;
            main_panel.Visible = false;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
        }

        // Главная

        private void main_Tab_button_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = true;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
=======
            labelButtMainText.ForeColor = Color.FromArgb(164, 123, 81);
            Main_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtGiveText.ForeColor = Color.FromArgb(164, 123, 81);
            Give_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtContactText.ForeColor = Color.FromArgb(164, 123, 81);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButInfo.ForeColor = Color.FromArgb(164, 123, 81);
>>>>>>> parent of b6674f6 (17.12.23 12:58)
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = true;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
<<<<<<< HEAD
=======



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
>>>>>>> parent of 987a097 (21.12.23 16:20)
        }

        private void label2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            give_away_panel.Visible = false;
            pet_panel.Visible = false;
            many_animal_panel.Visible = false;
            info_panel.Visible = false;
            contacts_panel.Visible = false;
            main_panel.Visible = true;
            error_panel.Visible = false;
            lacky_panel.Visible = false;
            main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
=======
            many_dog_panel.Visible = true;
            main_panel.Visible = false;
            label_title_pet.Text = "МЕЛКИЕ ГРЫЗУНЫ";
            Animal = "mouse";
>>>>>>> parent of 987a097 (21.12.23 16:20)
        }

        



<<<<<<< HEAD




=======
        private void back_button_many_pets_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = false;
            main_panel.Visible = true;
            Animal = "";
        }

        
>>>>>>> parent of 987a097 (21.12.23 16:20)

=======
>>>>>>> parent of 8cdf5d2 (19.12.23 7:18)

=======
        
>>>>>>> parent of b6674f6 (17.12.23 12:58)



>>>>>>> parent of a42d482 (16.12.23 16:57)



        // panel.Visible = true;
        // название панели.Visible = true
    }
}



// label_cat.Parent = pictureBox_Dog;
// label_cat.BackColor = Color.Transparent;