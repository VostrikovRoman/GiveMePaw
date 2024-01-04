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
<<<<<<< HEAD
            label_title_pet.Text = "СОБАКИ";
            Animal = "dog";
=======
            label_title_pet.Text = title_animal;
            Animal = animal;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(pet_type) FROM pets WHERE pet_type = @animal_type ", db.getConnection());
            MySqlParameter n1 = new MySqlParameter("@animal_type", animal_type);
            command.Parameters.Add(n1);
            Int64 count = (Int64)command.ExecuteScalar();
            command.ExecuteNonQuery();

            MySqlCommand command_give = new MySqlCommand("SELECT id FROM pets WHERE pet_type = @animal_type ", db.getConnection());
            MySqlParameter n2 = new MySqlParameter("@animal_type", animal_type);
            command_give.Parameters.Add(n2);
            MySqlDataReader Reader = command_give.ExecuteReader();
            Int32[] list = new Int32[count];

            int i = 0;

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    list[i] = Reader.GetInt32(0);
                    i += 1;
                }
            }
            Reader.Close();

            if (count > 2 )
            {
                card_pet_1.Visible = true;
                card_pet_2.Visible = true;
                back_butt.Visible = true;
                next_butt.Visible = true;

                if (count % 2 == 0)
                {
                    if (num < count)
                    {
                        card_pet_1.Visible = true;
                        card_pet_2.Visible = true;
                        if (num + 2 < count)
                        {
                            next_butt.Visible = true;
                        }
                        else
                        {
                            next_butt.Visible = false;
                        }
                        if (num - 1 >= 0)
                        {
                            back_butt.Visible = true;
                        }
                        else
                        {
                            back_butt.Visible = false;
                        }
                        MySqlCommand fill_name_1 = new MySqlCommand("SELECT name FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                        fill_name_1.Parameters.Add(f_1);
                        name_pet_1.Text = Convert.ToString(fill_name_1.ExecuteScalar());
                        fill_name_1.ExecuteNonQuery();
                        MySqlCommand fill_name_2 = new MySqlCommand("SELECT name FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_2 = new MySqlParameter("@id", list[num+1]);
                        fill_name_2.Parameters.Add(f_2);
                        name_pet_2.Text = Convert.ToString(fill_name_2.ExecuteScalar());
                        fill_name_2.ExecuteNonQuery();

                        MySqlCommand fill_breed_1 = new MySqlCommand("SELECT breed FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_3 = new MySqlParameter("@id", list[num]);
                        fill_breed_1.Parameters.Add(f_3);
                        breed_pet_1.Text = Convert.ToString(fill_breed_1.ExecuteScalar());
                        fill_breed_1.ExecuteNonQuery();
                        MySqlCommand fill_breed_2 = new MySqlCommand("SELECT breed FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_4 = new MySqlParameter("@id", list[num + 1]);
                        fill_breed_2.Parameters.Add(f_4);
                        breed_pet_2.Text = Convert.ToString(fill_breed_2.ExecuteScalar());
                        fill_breed_2.ExecuteNonQuery();

                        MySqlCommand fill_age_1 = new MySqlCommand("SELECT age FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_5 = new MySqlParameter("@id", list[num]);
                        fill_age_1.Parameters.Add(f_5);
                        age_pet_1.Text = Convert.ToString(fill_age_1.ExecuteScalar());
                        fill_age_1.ExecuteNonQuery();
                        MySqlCommand fill_age_2 = new MySqlCommand("SELECT age FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_6 = new MySqlParameter("@id", list[num + 1]);
                        fill_age_2.Parameters.Add(f_6);
                        age_pet_2.Text = Convert.ToString(fill_age_2.ExecuteScalar());
                        fill_age_2.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (num<count && num + 1 < count)
                    {
                        name_pet_1.Text = Convert.ToString(list[num]);
                        name_pet_2.Text = Convert.ToString(list[num + 1]);
                        card_pet_1.Visible = true;
                        card_pet_2.Visible = true;
                        if (num + 2 < count)
                        {
                            next_butt.Visible = true;
                        }
                        else
                        {
                            next_butt.Visible = false;
                        }
                        if (num - 1 >= 0)
                        {
                            back_butt.Visible = true;
                        }
                        else
                        {
                            back_butt.Visible = false;
                        }
                    }
                    else
                    {
                        name_pet_1.Text = Convert.ToString(list[num]);
                        card_pet_1.Visible = true;
                        card_pet_2.Visible = false;
                        next_butt.Visible = false;
                        if (num - 1 >= 0)
                        {
                            back_butt.Visible = true;
                        }
                        else
                        {
                            back_butt.Visible = false;
                        }
                    }
                    MySqlCommand fill_name_1 = new MySqlCommand("SELECT name FROM pets WHERE id = @id ", db.getConnection());
                    MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                    fill_name_1.Parameters.Add(f_1);
                    name_pet_1.Text = Convert.ToString(fill_name_1.ExecuteScalar());
                    fill_name_1.ExecuteNonQuery();

                    MySqlCommand fill_breed_1 = new MySqlCommand("SELECT breed FROM pets WHERE id = @id ", db.getConnection());
                    MySqlParameter f_3 = new MySqlParameter("@id", list[num]);
                    fill_breed_1.Parameters.Add(f_3);
                    breed_pet_1.Text = Convert.ToString(fill_breed_1.ExecuteScalar());
                    fill_breed_1.ExecuteNonQuery();

                    MySqlCommand fill_age_1 = new MySqlCommand("SELECT age FROM pets WHERE id = @id ", db.getConnection());
                    MySqlParameter f_5 = new MySqlParameter("@id", list[num]);
                    fill_age_1.Parameters.Add(f_5);
                    age_pet_1.Text = Convert.ToString(fill_age_1.ExecuteScalar());
                    fill_age_1.ExecuteNonQuery();
                }
            }
            else if (count == 1)
            {
                card_pet_1.Visible = true;
                card_pet_2.Visible = false;
                back_butt.Visible = false;
                next_butt.Visible = false;

                if (num < count)
                {
                    name_pet_1.Text = Convert.ToString(list[num]);
                }

                MySqlCommand fill_name_1 = new MySqlCommand("SELECT name FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                fill_name_1.Parameters.Add(f_1);
                name_pet_1.Text = Convert.ToString(fill_name_1.ExecuteScalar());
                fill_name_1.ExecuteNonQuery();

                MySqlCommand fill_breed_1 = new MySqlCommand("SELECT breed FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_3 = new MySqlParameter("@id", list[num]);
                fill_breed_1.Parameters.Add(f_3);
                breed_pet_1.Text = Convert.ToString(fill_breed_1.ExecuteScalar());
                fill_breed_1.ExecuteNonQuery();

                MySqlCommand fill_age_1 = new MySqlCommand("SELECT age FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_5 = new MySqlParameter("@id", list[num]);
                fill_age_1.Parameters.Add(f_5);
                age_pet_1.Text = Convert.ToString(fill_age_1.ExecuteScalar());
                fill_age_1.ExecuteNonQuery();
            }
            else if (count == 0)
            {
                card_pet_1.Visible = false;
                card_pet_2.Visible = false;
                back_butt.Visible = false;
                next_butt.Visible = false;
                MessageBox.Show("Здесь никого нет :)");
            }
            else if (count == 2)
            {
                card_pet_1.Visible = true;
                card_pet_2.Visible = true;
                back_butt.Visible = false;
                next_butt.Visible = false;
                
                if (num < count)
                {
                    name_pet_1.Text = Convert.ToString(list[num]);
                    name_pet_2.Text = Convert.ToString(list[num+1]);
                }
                MySqlCommand fill_name_1 = new MySqlCommand("SELECT name FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                fill_name_1.Parameters.Add(f_1);
                name_pet_1.Text = Convert.ToString(fill_name_1.ExecuteScalar());
                fill_name_1.ExecuteNonQuery();
                MySqlCommand fill_name_2 = new MySqlCommand("SELECT name FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_2 = new MySqlParameter("@id", list[num + 1]);
                fill_name_2.Parameters.Add(f_2);
                name_pet_2.Text = Convert.ToString(fill_name_2.ExecuteScalar());
                fill_name_2.ExecuteNonQuery();

                MySqlCommand fill_breed_1 = new MySqlCommand("SELECT breed FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_3 = new MySqlParameter("@id", list[num]);
                fill_breed_1.Parameters.Add(f_3);
                breed_pet_1.Text = Convert.ToString(fill_breed_1.ExecuteScalar());
                fill_breed_1.ExecuteNonQuery();
                MySqlCommand fill_breed_2 = new MySqlCommand("SELECT breed FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_4 = new MySqlParameter("@id", list[num + 1]);
                fill_breed_2.Parameters.Add(f_4);
                breed_pet_2.Text = Convert.ToString(fill_breed_2.ExecuteScalar());
                fill_breed_2.ExecuteNonQuery();

                MySqlCommand fill_age_1 = new MySqlCommand("SELECT age FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_5 = new MySqlParameter("@id", list[num]);
                fill_age_1.Parameters.Add(f_5);
                age_pet_1.Text = Convert.ToString(fill_age_1.ExecuteScalar());
                fill_age_1.ExecuteNonQuery();
                MySqlCommand fill_age_2 = new MySqlCommand("SELECT age FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_6 = new MySqlParameter("@id", list[num + 1]);
                fill_age_2.Parameters.Add(f_6);
                age_pet_2.Text = Convert.ToString(fill_age_2.ExecuteScalar());
                fill_age_2.ExecuteNonQuery();
            }
>>>>>>> parent of 16dfda5 (21.12.23 20:00)
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