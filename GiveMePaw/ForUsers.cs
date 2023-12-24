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

        private void Card()
        {

        }



        public string Animal = "";

        public Int32 num = 0;

        private void Animal_card(int animal_type, string title_animal, string animal)
        {
            many_dog_panel.Visible = true;
            main_panel.Visible = false;
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

                        
                        try
                        {
                            MySqlCommand fill_photo_1 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                            MySqlParameter f_7 = new MySqlParameter("@id", list[num]);
                            fill_photo_1.Parameters.Add(f_7);
                            image_pet_1.ImageLocation = Convert.ToString(fill_photo_1.ExecuteScalar());
                            fill_photo_1.ExecuteNonQuery();
                        }
                        catch 
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_2.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                            image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                        }
                        try
                        {
                            MySqlCommand fill_photo_2 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                            MySqlParameter f_8 = new MySqlParameter("@id", list[num + 1]);
                            fill_photo_2.Parameters.Add(f_8);
                            image_pet_2.ImageLocation = Convert.ToString(fill_photo_2.ExecuteScalar());
                            fill_photo_2.ExecuteNonQuery();
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_2.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                            image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                        }
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

                        try
                        {
                            MySqlCommand fill_photo_1 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                            MySqlParameter f_7 = new MySqlParameter("@id", list[num]);
                            fill_photo_1.Parameters.Add(f_7);
                            image_pet_1.ImageLocation = Convert.ToString(fill_photo_1.ExecuteScalar());
                            fill_photo_1.ExecuteNonQuery();
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_2.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                            image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                        }
                        try
                        {
                            MySqlCommand fill_photo_2 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                            MySqlParameter f_8 = new MySqlParameter("@id", list[num + 1]);
                            fill_photo_2.Parameters.Add(f_8);
                            image_pet_2.ImageLocation = Convert.ToString(fill_photo_2.ExecuteScalar());
                            fill_photo_2.ExecuteNonQuery();
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_2.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                            image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                        }
                    }
                    else if (num < count && num + 1 >= count)
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

                        try
                        {
                            MySqlCommand fill_photo_1 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                            MySqlParameter f_7 = new MySqlParameter("@id", list[num]);
                            fill_photo_1.Parameters.Add(f_7);
                            image_pet_1.ImageLocation = Convert.ToString(fill_photo_1.ExecuteScalar());
                            fill_photo_1.ExecuteNonQuery();
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_2.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                            image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                        }
                    }
                    
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

                try
                {
                    MySqlCommand fill_photo_1 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                    MySqlParameter f_7 = new MySqlParameter("@id", list[num]);
                    fill_photo_1.Parameters.Add(f_7);
                    image_pet_1.ImageLocation = Convert.ToString(fill_photo_1.ExecuteScalar());
                    fill_photo_1.ExecuteNonQuery();
                }
                catch
                {
                    image_pet_1.ImageLocation = "";
                    image_pet_2.ImageLocation = "";
                    image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                    image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                }
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

                try
                {
                    MySqlCommand fill_photo_1 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                    MySqlParameter f_7 = new MySqlParameter("@id", list[num]);
                    fill_photo_1.Parameters.Add(f_7);
                    image_pet_1.ImageLocation = Convert.ToString(fill_photo_1.ExecuteScalar());
                    fill_photo_1.ExecuteNonQuery();
                }
                catch
                {
                    image_pet_1.ImageLocation = "";
                    image_pet_2.ImageLocation = "";
                    image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                    image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                }
                try
                {
                    MySqlCommand fill_photo_2 = new MySqlCommand("SELECT photo FROM pets WHERE id = @id ", db.getConnection());
                    MySqlParameter f_8 = new MySqlParameter("@id", list[num + 1]);
                    fill_photo_2.Parameters.Add(f_8);
                    image_pet_2.ImageLocation = Convert.ToString(fill_photo_2.ExecuteScalar());
                    fill_photo_2.ExecuteNonQuery();
                }
                catch
                {
                    image_pet_1.ImageLocation = "";
                    image_pet_2.ImageLocation = "";
                    image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                    image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                }
            }
        }




        private void panel_dog_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_card(1, "СОБАКИ", "dog");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!"+ex);
            }
        }
        private void panel_cat_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_card(2, "КОШКИ", "cat");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void panel_parrot_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_card(3, "ПОПУГАИ", "parrot");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void panel_rabbit_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_card(4, "КРОЛИКИ", "rabbit");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void panel_mouse_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_card(5, "КРЫСЫ", "mouse");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }




        private void back_button_many_pets_Click(object sender, EventArgs e)
        {
            many_dog_panel.Visible = false;
            main_panel.Visible = true;
            Animal = "";
            num = 0;
            image_pet_1.ImageLocation = "";
            image_pet_2.ImageLocation = "";
            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
            image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
        }

        private void next_butt_Click(object sender, EventArgs e)
        {
            if (Animal == "dog")
            {
                try
                {
                    num += 2;
                    Animal_card(1, "СОБАКИ", "dog");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "cat")
            {
                try
                {
                    num += 2;
                    Animal_card(2, "КОШКИ", "cat");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "parrot")
            {
                try
                {
                    num += 2;
                    Animal_card(3, "ПОПУГАИ", "parrot");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "rabbit")
            {
                try
                {
                    num += 2;
                    Animal_card(4, "КРОЛИКИ", "rabbit");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "mouse")
            {
                try
                {
                    num += 2;
                    Animal_card(5, "КРЫСЫ", "mouse");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void back_butt_Click(object sender, EventArgs e)
        {
            if (Animal == "dog")
            {
                try
                {
                    num -= 2;
                    Animal_card(1, "СОБАКИ", "dog");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "cat")
            {
                try
                {
                    num -= 2;
                    Animal_card(2, "КОШКИ", "cat");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "parrot")
            {
                try
                {
                    num -= 2;
                    Animal_card(3, "ПОПУГАИ", "parrot");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "rabbit")
            {
                try
                {
                    num -= 2;
                    Animal_card(4, "КРОЛИКИ", "rabbit");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else if (Animal == "mouse")
            {
                try
                {
                    num -= 2;
                    Animal_card(5, "КРЫСЫ", "mouse");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }


        //Нажатие на карточку//

        private void card_pet_1_Click(object sender, EventArgs e)
        {
            pet_panel.Visible = true;
            many_dog_panel.Visible = false;
        }

        private void card_pet_2_Click(object sender, EventArgs e)
        {
            pet_panel.Visible = true;
            many_dog_panel.Visible = false;
        }

        private void take_button_Click(object sender, EventArgs e)
        {

        }

        private void back_button_card_Click(object sender, EventArgs e)
        {
            pet_panel.Visible = false;
            many_dog_panel.Visible = true;
        }










        // panel.Visible = true;
        // название панели.Visible = true
    }
}



// label_cat.Parent = pictureBox_Dog;
// label_cat.BackColor = Color.Transparent;