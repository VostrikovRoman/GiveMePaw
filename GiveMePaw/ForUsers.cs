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
            object age = "";
            object breed = "";
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
                        MySqlCommand fill_name_1 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                        fill_name_1.Parameters.Add(f_1);
                        MySqlDataReader Reader_data = fill_name_1.ExecuteReader();
                        if (Reader_data.HasRows)
                        {
                            while (Reader_data.Read())
                            {
                                name = Reader_data.GetValue(2);
                                age = Reader_data.GetValue(3);
                                breed = Reader_data.GetValue(5);
                                photo = Reader_data.GetValue(6);
                            }
                        }
                        Reader_data.Close();

                        name_pet_1.Text = Convert.ToString(name);
                        age_pet_1.Text = Convert.ToString(age) + " мес.";
                        breed_pet_1.Text = Convert.ToString(breed);
                        try
                        {
                            image_pet_1.ImageLocation = Convert.ToString(photo);
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                        }

                        MySqlCommand fill_name_2 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_2 = new MySqlParameter("@id", list[num+1]);
                        fill_name_2.Parameters.Add(f_2);
                        MySqlDataReader Reader_data_2 = fill_name_2.ExecuteReader();
                        if (Reader_data_2.HasRows)
                        {
                            while (Reader_data_2.Read())
                            {
                                name = Reader_data_2.GetValue(2);
                                age = Reader_data_2.GetValue(3);
                                breed = Reader_data_2.GetValue(5);
                                photo = Reader_data_2.GetValue(6);
                            }
                        }
                        Reader_data_2.Close();

                        name_pet_2.Text = Convert.ToString(name);
                        age_pet_2.Text = Convert.ToString(age) + " мес.";
                        breed_pet_2.Text = Convert.ToString(breed);
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
                        MySqlCommand fill_name_1 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                        fill_name_1.Parameters.Add(f_1);
                        MySqlDataReader Reader_data = fill_name_1.ExecuteReader();
                        if (Reader_data.HasRows)
                        {
                            while (Reader_data.Read())
                            {
                                name = Reader_data.GetValue(2);
                                age = Reader_data.GetValue(3);
                                breed = Reader_data.GetValue(5);
                                photo = Reader_data.GetValue(6);
                            }
                        }
                        Reader_data.Close();

                        name_pet_1.Text = Convert.ToString(name);
                        age_pet_1.Text = Convert.ToString(age) + " мес.";
                        breed_pet_1.Text = Convert.ToString(breed);
                        try
                        {
                            image_pet_1.ImageLocation = Convert.ToString(photo);
                        }
                        catch
                        {
                            image_pet_1.ImageLocation = "";
                            image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                        }

                        MySqlCommand fill_name_2 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_2 = new MySqlParameter("@id", list[num+1]);
                        fill_name_2.Parameters.Add(f_2);
                        MySqlDataReader Reader_data_2 = fill_name_2.ExecuteReader();
                        if (Reader_data_2.HasRows)
                        {
                            while (Reader_data_2.Read())
                            {
                                name = Reader_data_2.GetValue(2);
                                age = Reader_data_2.GetValue(3);
                                breed = Reader_data_2.GetValue(5);
                                photo = Reader_data_2.GetValue(6);
                            }
                        }
                        Reader_data_2.Close();

                        name_pet_2.Text = Convert.ToString(name);
                        age_pet_2.Text = Convert.ToString(age) + " мес.";
                        breed_pet_2.Text = Convert.ToString(breed);
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
                        MySqlCommand fill_name_1 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                        MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                        fill_name_1.Parameters.Add(f_1);
                        MySqlDataReader Reader_data = fill_name_1.ExecuteReader();
                        if (Reader_data.HasRows)
                        {
                            while (Reader_data.Read())
                            {
                                name = Reader_data.GetValue(2);
                                age = Reader_data.GetValue(3);
                                breed = Reader_data.GetValue(5);
                                photo = Reader_data.GetValue(6);
                            }
                        }
                        Reader_data.Close();

                        name_pet_1.Text = Convert.ToString(name);
                        age_pet_1.Text = Convert.ToString(age) + " мес.";
                        breed_pet_1.Text = Convert.ToString(breed);
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

                MySqlCommand fill_name_1 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                fill_name_1.Parameters.Add(f_1);
                MySqlDataReader Reader_data = fill_name_1.ExecuteReader();
                if (Reader_data.HasRows)
                {
                    while (Reader_data.Read())
                    {
                        name = Reader_data.GetValue(2);
                        age = Reader_data.GetValue(3);
                        breed = Reader_data.GetValue(5);
                        photo = Reader_data.GetValue(6);
                    }
                }
                Reader_data.Close();

                name_pet_1.Text = Convert.ToString(name);
                age_pet_1.Text = Convert.ToString(age) + " мес.";
                breed_pet_1.Text = Convert.ToString(breed);
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
                no_animal_panel.Visible = true;
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
                MySqlCommand fill_name_1 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_1 = new MySqlParameter("@id", list[num]);
                fill_name_1.Parameters.Add(f_1);
                MySqlDataReader Reader_data = fill_name_1.ExecuteReader();
                if (Reader_data.HasRows)
                {
                    while (Reader_data.Read())
                    {
                        name = Reader_data.GetValue(2);
                        age = Reader_data.GetValue(3);
                        breed = Reader_data.GetValue(5);
                        photo = Reader_data.GetValue(6);
                    }
                }
                Reader_data.Close();

                name_pet_1.Text = Convert.ToString(name);
                age_pet_1.Text = Convert.ToString(age) + " мес.";
                breed_pet_1.Text = Convert.ToString(breed);
                try
                {
                    image_pet_1.ImageLocation = Convert.ToString(photo);
                }
                catch
                {
                    image_pet_1.ImageLocation = "";
                    image_pet_1.Image = new Bitmap(Properties.Resources.not_img);
                }

                MySqlCommand fill_name_2 = new MySqlCommand("SELECT * FROM pets WHERE id = @id ", db.getConnection());
                MySqlParameter f_2 = new MySqlParameter("@id", list[num+1]);
                fill_name_2.Parameters.Add(f_2);
                MySqlDataReader Reader_data_2 = fill_name_2.ExecuteReader();
                if (Reader_data_2.HasRows)
                {
                    while (Reader_data_2.Read())
                    {
                        name = Reader_data_2.GetValue(2);
                        age = Reader_data_2.GetValue(3);
                        breed = Reader_data_2.GetValue(5);
                        photo = Reader_data_2.GetValue(6);
                    }
                }
                Reader_data_2.Close();

                name_pet_2.Text = Convert.ToString(name);
                age_pet_2.Text = Convert.ToString(age) + " мес.";
                breed_pet_2.Text = Convert.ToString(breed);
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


        //Нажатия на разделы//

        private void panel_dog_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_card(1, "СОБАКИ", "dog");
            }
            catch 
            {
                MessageBox.Show("Ошибка!");
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



        //Выйти в меню//
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

        //Следующий набор карточек//
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

        //Выйти в меню карточек//
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

        //Выход из пустого набора карточек//
        private void back_button_no_animal_Click(object sender, EventArgs e)
        {
            no_animal_panel.Visible = false;
            many_dog_panel.Visible = false;
            main_panel.Visible = true;
            Animal = "";
            num = 0;
        }
        //Нажатие на карточку//

        private void Select_Card (int animal_type, int number)
        {
            pet_panel.Visible = true;
            many_dog_panel.Visible = false;

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
            Int64[] list = new Int64[count];

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

            MySqlCommand paste = new MySqlCommand("SELECT * FROM pets WHERE id = @id", db.getConnection());
            MySqlParameter p1 = new MySqlParameter("@id", list[number]);
            paste.Parameters.Add(p1);
            MySqlDataReader Reader_p = paste.ExecuteReader();

            object id = "";
            object name = "";
            object age = "";
            object weight = "";
            object breed = "";
            object photo = "";

            if (Reader_p.HasRows)
            {
                while (Reader_p.Read())
                {
                    id = Reader_p.GetValue(0);
                    name = Reader_p.GetValue(2);
                    age = Reader_p.GetValue(3) + " мес.";
                    weight = Reader_p.GetValue(4) + " грамм";
                    breed = Reader_p.GetValue(5);
                    photo = Reader_p.GetValue(6);
                }
            }
            Reader_p.Close();

            name_card.Text = Convert.ToString(name);
            if (Animal == "dog")
            {
                type_card.Text = "Собака";
            }
            else if (Animal == "cat")
            {
                type_card.Text = "Кошка";
            }
            else if (Animal == "parrot")
            {
                type_card.Text = "Попугай";
            }
            else if (Animal == "rabbit")
            {
                type_card.Text = "Кролик";
            }
            else if (Animal == "mouse")
            {
                type_card.Text = "Крыса";
            }
            age_card.Text = Convert.ToString(age);
            weight_card.Text = Convert.ToString(weight);
            breed_card.Text = Convert.ToString(breed);
            try
            {
                photo_card.ImageLocation = Convert.ToString(photo);
            }
            catch
            {
                photo_card.ImageLocation = "";
                photo_card.Image = new Bitmap(Properties.Resources.not_img);
            }
        }

        private void card_pet_1_Click(object sender, EventArgs e)
        {
            if (Animal == "dog")
            {
                try
                {
                    Select_Card(1, num);
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
                    Select_Card(2, num);
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
                    Select_Card(3, num);
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
                    Select_Card(4, num);
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
                    Select_Card(5, num);
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void card_pet_2_Click(object sender, EventArgs e)
        {
            
        }

        private void take_button_Click(object sender, EventArgs e)
        {

        }

        private void back_button_card_Click(object sender, EventArgs e)
        {
            pet_panel.Visible = false;
            many_dog_panel.Visible = true;
            name_card.Text = "Кличка";
            type_card.Text = "вид";
            breed_card.Text = "порода";
            age_card.Text = "?";
            weight_card.Text = "?";
        }

        private void cancel_button_give_away_Click(object sender, EventArgs e)
        {

        }

        private void Send (string type, string breed, string name, string age, string weight, string u_name, string u_surname, string u_email)
        {
            breed = breed_give_away.Text;
            name = name_give_away.Text;
            age = age_give_away.Text;
            weight = weight_give_away.Text;


            try
            {
                MailAddress from = new MailAddress("fortestIMT@gmail.com");
                MailAddress to = new MailAddress("rmnvstrkv@gmail.com");
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Сдача животного!";
                m.IsBodyHtml = true;
                m.Body = "<!DOCTYPE html><head></head><body style='background: #e0e0e0;'><h1 align = 'center' style='color: #5c4130;'>Сдача животного!</h1>"+
                    "<h2 style='color: black;' align = 'center'>Здравствуйте! Хочу сдать животное в приют. </h2>" +
                    "<h2 style='color: #454545; margin-left: 35px;'>Кличка: "+name+"</h2><h2 style='color: #454545; margin-left: 35px;'>Вид: "+type+"</h2>" +
                    "<h2 style='color: #454545; margin-left: 35px;'>Порода: "+breed+"</h2><h2 style='color: #454545; margin-left: 35px;'> Возраст: "+age+" мес.</h2>" +
                    "<h2 style='color: #454545; margin-left: 35px;'>Вес: "+weight+" грамм.</h2> <h2 align = 'right' style='color: #cc8c2c; margin-right: 35px;'>"+u_surname+" "+u_name+", </h2>" +
                    "<h2 align = 'right' style='color: #cc8c2c; margin-right: 35px;'>"+u_email+" </h2>" +
                    "<h2 style='color: black;' align = 'center'>Всего хорошего!</h2>" +
                    "<table align = 'center'><tr><td><img src = 'https://github.com/VostrikovRoman/PhotoForGiveMePaw/blob/main/logo_give_me_paw%202.png?raw=true' width = '200px' ></img><h2 align = 'center' style='color: #5c4130;'>ДайЛапу</h2></td></tr></table>" +
                    "</body></html>";
                //m.Body = "Здравствуйте!\nХочу сдать животное в приют.\n\nКличка: " + name + "\nВид: " + type + "\nПорода: " + breed + "\nВозраст: " + age + " мес.\nВес: " + weight + " грамм\n\n\Всего хорошего!" ;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("fortestIMT@gmail.com", "pexzozphwawhzbog"),
                    //Credentials = new NetworkCredential("fortestIMT@gmail.com", "osazmjbjywktkvjo"),

                    EnableSsl = true
                };
                smtp.Send(m);
                type_give_away.Text = "";
                name_give_away.Text = "";
                age_give_away.Text = "";
                weight_give_away.Text = "";
                breed_give_away.Text = "";
                MessageBox.Show("Ваша заявка отправлена!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат электронной почты. Почта должна иметь окончания - @gmail/yandex/mail/bk/list и другие");

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Строка с адресом не должна быть пуста");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void send_button_give_away_Click(object sender, EventArgs e)
        {
            string type = "";
            string breed = "";
            string name = "";
            string age = "";
            string weight = "";
            string u_name = "";
            string u_surname = "";
            string u_email = SignIn.user_email;
            string m_email = "";

            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DB db = new DB();
                db.openConnection();

                MySqlCommand data = new MySqlCommand("SELECT * FROM users WHERE email = @email ", db.getConnection());
                MySqlParameter n2 = new MySqlParameter("@email", u_email);
                data.Parameters.Add(n2);
                MySqlDataReader Reader = data.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        u_name = Reader.GetString(1);
                        u_surname = Reader.GetString(2);
                    }
                }
                Reader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }


            if (type_give_away.SelectedIndex+1 == 1 && breed_give_away.Text != "" && name_give_away.Text != "" && age_give_away.Text != "" && weight_give_away.Text != "")
            {
                Send("Собака", breed, name, age, weight, u_name, u_surname, u_email);
            }
            else if (type_give_away.SelectedIndex + 1 == 2 && breed_give_away.Text != "" && name_give_away.Text != "" && age_give_away.Text != "" && weight_give_away.Text != "")
            {
                Send("Кошка", breed, name, age, weight, u_name, u_surname, u_email);
            }
            else if (type_give_away.SelectedIndex + 1 == 3 && breed_give_away.Text != "" && name_give_away.Text != "" && age_give_away.Text != "" && weight_give_away.Text != "")
            {
                Send("Попугай", breed, name, age, weight, u_name, u_surname, u_email);
            }
            else if (type_give_away.SelectedIndex + 1 == 4 && breed_give_away.Text != "" && name_give_away.Text != "" && age_give_away.Text != "" && weight_give_away.Text != "")
            {
                Send("Кролик", breed, name, age, weight, u_name, u_surname, u_email);
            }
            else if (type_give_away.SelectedIndex + 1 == 5 && breed_give_away.Text != "" && name_give_away.Text != "" && age_give_away.Text != "" && weight_give_away.Text != "")
            {
                Send("Крыса", breed, name, age, weight, u_name, u_surname, u_email);
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }














        // panel.Visible = true;
        // название панели.Visible = true
    }
}



// label_cat.Parent = pictureBox_Dog;
// label_cat.BackColor = Color.Transparent;