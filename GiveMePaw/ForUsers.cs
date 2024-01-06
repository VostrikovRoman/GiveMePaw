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
using System.Net;
using System.Net.Mail;

namespace GiveMePaw
{
    public partial class ForUsers : Form
    {
        public ForUsers()
        {
            InitializeComponent();
        }

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

            object name = "";
            object breed = "";
            object age = "";
            object photo = "";

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
                        MySqlCommand fill = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                        fill.Parameters.Add(f_1);
                        MySqlDataReader Reader_fill = fill.ExecuteReader();
                        if (Reader_fill.HasRows)
                        {
                            while (Reader_fill.Read())
                            {
                                name = Reader_fill.GetValue(2);
                                age = Reader_fill.GetValue(3);
                                breed = Reader_fill.GetValue(5);
                                photo = Reader_fill.GetValue(6);
                            }
                        }
                        Reader_fill.Close();
                        name_pet_1.Text = Convert.ToString(name);
                        breed_pet_1.Text = Convert.ToString(breed);
                        age_pet_1.Text = Convert.ToString(age);
                        try
                        {
                            image_pet_1.ImageLocation = Convert.ToString(photo);
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                        }

                        MySqlCommand fill_2 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_2 = new MySqlParameter("@id", list[num+1]);
                        fill_2.Parameters.Add(f_2);
                        MySqlDataReader Reader_fill_2 = fill_2.ExecuteReader();
                        if (Reader_fill_2.HasRows)
                        {
                            while (Reader_fill_2.Read())
                            {
                                name = Reader_fill_2.GetValue(2);
                                age = Reader_fill_2.GetValue(3);
                                breed = Reader_fill_2.GetValue(5);
                                photo = Reader_fill_2.GetValue(6);
                            }
                        }
                        Reader_fill_2.Close();
                        name_pet_2.Text = Convert.ToString(name);
                        breed_pet_2.Text = Convert.ToString(breed);
                        age_pet_2.Text = Convert.ToString(age);
                        try
                        {
                            image_pet_2.ImageLocation = Convert.ToString(photo);
                        }
                        catch 
                        {
                            image_pet_2.ImageLocation = "";
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
                        MySqlCommand fill = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                        fill.Parameters.Add(f_1);
                        MySqlDataReader Reader_fill = fill.ExecuteReader();
                        if (Reader_fill.HasRows)
                        {
                            while (Reader_fill.Read())
                            {
                                name = Reader_fill.GetValue(2);
                                age = Reader_fill.GetValue(3);
                                breed = Reader_fill.GetValue(5);
                                photo = Reader_fill.GetValue(6);
                            }
                        }
                        Reader_fill.Close();
                        name_pet_1.Text = Convert.ToString(name);
                        breed_pet_1.Text = Convert.ToString(breed);
                        age_pet_1.Text = Convert.ToString(age);
                        try
                        {
                            image_pet_1.ImageLocation = Convert.ToString(photo);
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                        }

                        MySqlCommand fill_2 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_2 = new MySqlParameter("@id", list[num + 1]);
                        fill_2.Parameters.Add(f_2);
                        MySqlDataReader Reader_fill_2 = fill_2.ExecuteReader();
                        if (Reader_fill_2.HasRows)
                        {
                            while (Reader_fill_2.Read())
                            {
                                name = Reader_fill_2.GetValue(2);
                                age = Reader_fill_2.GetValue(3);
                                breed = Reader_fill_2.GetValue(5);
                                photo = Reader_fill_2.GetValue(6);
                            }
                        }
                        Reader_fill_2.Close();
                        name_pet_2.Text = Convert.ToString(name);
                        breed_pet_2.Text = Convert.ToString(breed);
                        age_pet_2.Text = Convert.ToString(age);
                        try
                        {
                            image_pet_2.ImageLocation = Convert.ToString(photo);
                        }
                        catch
                        {
                            image_pet_2.ImageLocation = "";
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
                        MySqlCommand fill = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                        fill.Parameters.Add(f_1);
                        MySqlDataReader Reader_fill = fill.ExecuteReader();
                        if (Reader_fill.HasRows)
                        {
                            while (Reader_fill.Read())
                            {
                                name = Reader_fill.GetValue(2);
                                age = Reader_fill.GetValue(3);
                                breed = Reader_fill.GetValue(5);
                                photo = Reader_fill.GetValue(6);
                            }
                        }
                        Reader_fill.Close();
                        name_pet_1.Text = Convert.ToString(name);
                        breed_pet_1.Text = Convert.ToString(breed);
                        age_pet_1.Text = Convert.ToString(age);
                        try
                        {
                            image_pet_1.ImageLocation = Convert.ToString(photo);
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
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

                MySqlCommand fill = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                fill.Parameters.Add(f_1);
                MySqlDataReader Reader_fill = fill.ExecuteReader();
                if (Reader_fill.HasRows)
                {
                    while (Reader_fill.Read())
                    {
                        name = Reader_fill.GetValue(2);
                        age = Reader_fill.GetValue(3);
                        breed = Reader_fill.GetValue(5);
                        photo = Reader_fill.GetValue(6);
                    }
                }
                Reader_fill.Close();
                name_pet_1.Text = Convert.ToString(name);
                breed_pet_1.Text = Convert.ToString(breed);
                age_pet_1.Text = Convert.ToString(age);
                try
                {
                    image_pet_1.ImageLocation = Convert.ToString(photo);
                }
                catch
                {
                    image_pet_1.ImageLocation = "";
                    image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
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
                MySqlCommand fill = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                fill.Parameters.Add(f_1);
                MySqlDataReader Reader_fill = fill.ExecuteReader();
                if (Reader_fill.HasRows)
                {
                    while (Reader_fill.Read())
                    {
                        name = Reader_fill.GetValue(2);
                        age = Reader_fill.GetValue(3);
                        breed = Reader_fill.GetValue(5);
                        photo = Reader_fill.GetValue(6);
                    }
                }
                Reader_fill.Close();
                name_pet_1.Text = Convert.ToString(name);
                breed_pet_1.Text = Convert.ToString(breed);
                age_pet_1.Text = Convert.ToString(age);
                try
                {
                    image_pet_1.ImageLocation = Convert.ToString(photo);
                }
                catch
                {
                    image_pet_1.ImageLocation = "";
                    image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                }

                MySqlCommand fill_2 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_2 = new MySqlParameter("@id", list[num + 1]);
                fill_2.Parameters.Add(f_2);
                MySqlDataReader Reader_fill_2 = fill_2.ExecuteReader();
                if (Reader_fill_2.HasRows)
                {
                    while (Reader_fill_2.Read())
                    {
                        name = Reader_fill_2.GetValue(2);
                        age = Reader_fill_2.GetValue(3);
                        breed = Reader_fill_2.GetValue(5);
                        photo = Reader_fill_2.GetValue(6);
                    }
                }
                Reader_fill_2.Close();
                name_pet_2.Text = Convert.ToString(name);
                breed_pet_2.Text = Convert.ToString(breed);
                age_pet_2.Text = Convert.ToString(age);
                try
                {
                    image_pet_2.ImageLocation = Convert.ToString(photo);
                }
                catch
                {
                    image_pet_2.ImageLocation = "";
                    image_pet_2.Image = new Bitmap(Properties.Resources.not_img);
                }
            }
        }



        //Разделы//
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



        //Выйти в главное меню//
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


        //Кнопки переключения карточек//
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
            if (Animal == "dog")
            {
                Card(num, 1, "Собака");
            }
            else if (Animal == "cat")
            {
                Card(num, 2, "Кошка");
            }
            else if (Animal == "parrot")
            {
                Card(num, 3, "Попугай");
            }
            else if (Animal == "rabbit")
            {
                Card(num, 4, "Кролик");
            }
            else if (Animal == "mouse")
            {
                Card(num, 5, "Крыса");
            }
        }
        private void card_pet_2_Click(object sender, EventArgs e)
        {
            pet_panel.Visible = true;
            many_dog_panel.Visible = false;
            if (Animal == "dog")
            {
                Card(num+1, 1, "Собака");
            }
            else if (Animal == "cat")
            {
                Card(num + 1, 2, "Кошка");
            }
            else if (Animal == "parrot")
            {
                Card(num + 1, 3, "Попугай");
            }
            else if (Animal == "rabbit")
            {
                Card(num + 1, 4, "Кролик");
            }
            else if (Animal == "mouse")
            {
                Card(num + 1, 5, "Крыса");
            }
        }


        //Функция загрузки карточки//
        private void Card(int number, int animal_type, string animal)
        {
            try
            {
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

                object name = "";
                object breed = "";
                object age = "";
                object photo = "";
                object weight = "";

                MySqlCommand paste = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter p = new MySqlParameter("@id", list[number]);
                paste.Parameters.Add(p);
                MySqlDataReader Reader_paste = paste.ExecuteReader();
                if (Reader_paste.HasRows)
                {
                    while (Reader_paste.Read())
                    {
                        name = Reader_paste.GetValue(2);
                        age = Reader_paste.GetValue(3);
                        weight = Reader_paste.GetValue(4);
                        breed = Reader_paste.GetValue(5);
                        photo = Reader_paste.GetValue(6);
                    }
                }
                else
                {
                    MessageBox.Show("Животное уже забрали");
                }
                Reader_paste.Close();

                name_card.Text = Convert.ToString(name);
                age_card.Text = Convert.ToString(age) + " мес.";
                weight_card.Text = Convert.ToString(weight) + " грамм";
                breed_card.Text = Convert.ToString(breed);
                type_card.Text = animal;
                try
                {
                    photo_card.ImageLocation = Convert.ToString(photo);
                }
                catch
                {
                    photo_card.ImageLocation = "";
                    photo_card.Image = new Bitmap(Properties.Resources.not_img);
                }
                label2.Text = Convert.ToString(list[number]);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            
        }







        private void take_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите приютить это животное?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Message_put(SignIn.user_email);
            }
        }

        private void back_button_card_Click(object sender, EventArgs e)
        {
            pet_panel.Visible = false;
            many_dog_panel.Visible = true;
        }


        //Функция отправки письма//

        private void Message_put(string u_email)
        {
            object u_name = "";
            object u_surname = "";
            string animal = "";

            if (type_card.Text == "Собака")
            {
                animal = " собаку, по имени " + name_card.Text;
            }
            else if (type_card.Text == "Кошка")
            {
                animal = " кошку, по имени " + name_card.Text;
            }
            else if (type_card.Text == "Попугай")
            {
                animal = " попугая, по имени " + name_card.Text;
            }
            else if (type_card.Text == "Кролик")
            {
                animal = " кролика, по имени " + name_card.Text;
            }
            else if (type_card.Text == "Крыса")
            {
                animal = " крысу, по имени " + name_card.Text;
            }


            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DB db = new DB();
                db.openConnection();

                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE email = @email ", db.getConnection());
                MySqlParameter n1 = new MySqlParameter("@email", u_email);
                command.Parameters.Add(n1);
                MySqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        u_name = Convert.ToString(Reader.GetValue(1));
                        u_surname = Convert.ToString(Reader.GetValue(2));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }

            try
            {
                MailAddress from = new MailAddress("fortestIMT@gmail.com");
                MailAddress to = new MailAddress("rmnvstrkv@gmail.com");
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Приём животного!";
                m.IsBodyHtml = true;
                m.Body = "<html><head></head><body style = 'background: #e0e0e0;'><h1 align = 'center' style = 'color: #5c4130;'>Приём животного!</h1>" +
                    "<h2 align = 'center' style = 'color: black;'>Здравствуйте! Хочу приютить" + animal + ".</h2><h2 style = 'color: #3e3e3e; margin-left: 50px;'>Кличка: " + 
                    name_card.Text + "</h2><h2 style = 'color: #3e3e3e; margin-left: 50px;'>ID: " + label2.Text + "</h2><h2 style = 'color:#cc8c2c; margin-right: 50px;' align = 'right'>" + 
                    u_surname + " " + u_name + ", </h2><h2 style = 'color:#cc8c2c; margin-right: 50px;' align = 'right'>" + u_email + "</h2>" +
                    "<h2 align = 'center' style = 'color: black;'>Всего хорошего!</h2>" + 
                    "<table align = 'center'><tr><td><img src = 'https://github.com/VostrikovRoman/PhotoForGiveMePaw/blob/main/logo_give_me_paw%202.png?raw=true' width = '200px'></img></td></tr></table>" +
                    "<h2 align = 'center' style = 'color: #5c4130;'>ДайЛапу</h2></body></html>";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("fortestIMT@gmail.com", "pexzozphwawhzbog"),
                    EnableSsl = true
                };
                smtp.Send(m);
                MessageBox.Show("Заявка успешно отправлена");
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат электронной почты. Почта должна иметь окончания - @gmail/yandex/mail/bk/list и другие");

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Строка с адресом не должна быть пуста");
            }
            catch 
            {
                MessageBox.Show("Ошибка!");
            }
        }




    }
}

