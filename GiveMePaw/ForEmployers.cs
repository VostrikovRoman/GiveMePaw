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
    public partial class ForEmployers : Form
    {
        FormAddPet form;
        public ForEmployers()
        {
            InitializeComponent();
            form = new FormAddPet(this); 
        }
        
       
        private void labelButtUsersText_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtUsersText.ForeColor = Color.FromArgb(92, 65, 48);
            Users_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtUsers.Image = new Bitmap(Properties.Resources.user_Active);
            panelPet.Visible = false;
            panelContact.Visible = false;
            panelUsersFind.Visible = true;
            panelInfo.Visible = false;
        }
        
        private void labelButtPetText_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtPetText.ForeColor = Color.FromArgb(92, 65, 48);
            Pet_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtPet.Image = new Bitmap(Properties.Resources.animal_Active);
            panelPet.Visible = true;
            panelContact.Visible = false;
            panelUsersFind.Visible = false;
            panelInfo.Visible = false;
        }

        private void labelButtContactText_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtContactText.ForeColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtContact.Image = new Bitmap(Properties.Resources.phone_Active);
            panelPet.Visible = false;
            panelContact.Visible = true;
            panelUsersFind.Visible = false;
            panelInfo.Visible = false;

            Fill_contacts(1);
            Fill_contacts(2);
        }

        private void labelButInfo_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButInfo.ForeColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            picturePaw.Image = new Bitmap(Properties.Resources.info_Active);
            panelPet.Visible = false;
            panelContact.Visible = false;
            panelUsersFind.Visible = false;
            panelInfo.Visible = true;
        }


        private void defoult_color()
        {
            labelButtUsersText.ForeColor = Color.FromArgb(228, 164, 84);
            Users_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtPetText.ForeColor = Color.FromArgb(228, 164, 84);
            Pet_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtContactText.ForeColor = Color.FromArgb(228, 164, 84);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButInfo.ForeColor = Color.FromArgb(228, 164, 84);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);



            pictureButtUsers.Image = new Bitmap(Properties.Resources.user_Passive);

            pictureButtPet.Image = new Bitmap(Properties.Resources.animal_Passive);

            pictureButtContact.Image = new Bitmap(Properties.Resources.phone_Passive);

            picturePaw.Image = new Bitmap(Properties.Resources.info_Passive);

        }

        private void labelButtFindUser_Click(object sender, EventArgs e)
        {
            String email = emailFindUser.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select users.email, users.second_name, users.name, users.patronomic, users.phone_number, roles.description FROM `users` INNER JOIN `roles` ON users.role = roles.id_roles WHERE `email` = @eU", db.getConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = email;

            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();

            if (table.Rows.Count > 0)
            {
                panelFindUsers.Visible = false;
                panelUser.Visible = true;
                panelBackButtBack.Visible = true;

                labelEmail.Text = Convert.ToString(table.Rows[0][0]);
                labelSecondName.Text = "Фамилия: " + Convert.ToString(table.Rows[0][1]);
                labelName.Text = "Имя: " + Convert.ToString(table.Rows[0][2]);
                labelPatronomic.Text = "Отчество: " + Convert.ToString(table.Rows[0][3]);
                labelPhoneNum.Text = "Номер телефона: " + Convert.ToString(table.Rows[0][4]);
                labelRole.Text = "Роль: " + Convert.ToString(table.Rows[0][5]);
            }
            else
            {
                MessageBox.Show("Пользователя с таким email не существует!");
            }
        }

        private void labelChangeRoleAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите назначить этого пользователя\nадминистратором?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string email = labelEmail.Text;
                MySqlCommand command = new MySqlCommand("UPDATE `givemepaw`.`users` SET `role` = '1' WHERE (`email`= '" + email + "');", db.getConnection());
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                refreshUserStatus();
            }
            return;
        }

        private void labelChangeRoleManag_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите назначить этого пользователя\nменеджером?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string email = labelEmail.Text;
                MySqlCommand command = new MySqlCommand("UPDATE `givemepaw`.`users` SET `role` = '2' WHERE (`email`= '" + email + "');", db.getConnection());
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                refreshUserStatus();
            }
        }

        private void labelChangeRoleUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите назначить этого пользователя\nпользователем?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string email = labelEmail.Text;
                MySqlCommand command = new MySqlCommand("UPDATE `givemepaw`.`users` SET `role` = '3' WHERE (`email`= '" + email + "');", db.getConnection());

                db.openConnection();
                command.ExecuteNonQuery();
                refreshUserStatus();
                db.closeConnection();
            }
        }




        private void refreshUserStatus()
        {
            String email = labelEmail.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select roles.description FROM `users` INNER JOIN `roles` ON users.role = roles.id_roles WHERE `email` = '" + email + "'", db.getConnection());
            
            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();

            labelRole.Text = "Роль: " + Convert.ToString(table.Rows[0][0]);
         
        }

        private void labelButtBackText_Click(object sender, EventArgs e)
        {
            panelBackButtBack.Visible = false;
            panelFindUsers.Visible = true;
            panelUser.Visible = false;

        }
    
        public void Display()
        {
            DB.DisplayAndSerachPet("SELECT * FROM pets", dataGridViewPet);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void ForEmployers_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textBoxFindPet_TextChanged(object sender, EventArgs e)
        {
            DB.DisplayAndSerachPet("SELECT * FROM pets WHERE name LIKE'%"+ textBoxFindPet.Text +"%'", dataGridViewPet);
        }

        private void dataGridViewPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == 0)
            {
                //Edit
                if (MessageBox.Show("Вы уверены, что хотите изменить житвотное?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    form.Clear();
                    form.id = dataGridViewPet.Rows[e.RowIndex].Cells[2].Value.ToString();
                    form.pet_type = dataGridViewPet.Rows[e.RowIndex].Cells[3].Value.ToString();
                    form.name = dataGridViewPet.Rows[e.RowIndex].Cells[4].Value.ToString();
                    form.age = dataGridViewPet.Rows[e.RowIndex].Cells[5].Value.ToString();
                    form.wieght = dataGridViewPet.Rows[e.RowIndex].Cells[6].Value.ToString();
                    form.breed = dataGridViewPet.Rows[e.RowIndex].Cells[7].Value.ToString();
                    form.photo = dataGridViewPet.Rows[e.RowIndex].Cells[8].Value.ToString();
                    form.UpdateInfo();
                    form.ShowDialog();
                }
                return;
            }

            else if (e.ColumnIndex == 1)
            {
                //Delete
                if(MessageBox.Show("Вы уверены, что хотите удалить животное?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB.DeletePet(dataGridViewPet.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            ForEmployers.ActiveForm.Hide();
            Account NewForm = new Account();
            NewForm.ShowDialog();
            Close();
        }

        private void ForEmployers_Load(object sender, EventArgs e)
        {
            try
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

                MySqlCommand command_role = new MySqlCommand("SELECT role FROM users WHERE email = @email", db.getConnection());
                MySqlParameter r = new MySqlParameter("@email", SignIn.user_email);
                command_role.Parameters.Add(r);
                string role = Convert.ToString(command_role.ExecuteScalar());
                command_role.ExecuteNonQuery();

                account_button.Text = surname + " " + name.Substring(0, 1) + ".";

                /////////////////////
                Fill_contacts(1);
                Fill_contacts(2);
                Filler_combobox(1);
                Filler_combobox(2);

                if (role == "2")
                {
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panelUserInfo.Location = new Point(130, 55);
                    admin_contact_name.Visible = true;
                    manager_contact_name.Visible = true;
                    admin_combobox.Visible = false;
                    manager_combobox.Visible = false;
                }
                else
                {
                    admin_contact_name.Visible = false;
                    manager_contact_name.Visible = false;
                    admin_combobox.Visible = true;
                    manager_combobox.Visible = true;
                }

                
            }
            catch 
            {
                MessageBox.Show("Ошибка!");
            }
            
        }




        private void Fill_contacts(int role)
        {
            try
            {
                
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DB db = new DB();
                db.openConnection();

                MySqlCommand command = new MySqlCommand("SELECT id FROM users WHERE role = @role AND primacy = '+'", db.getConnection());
                MySqlParameter c2 = new MySqlParameter("@role", role);
                command.Parameters.Add(c2);
                MySqlDataReader Reader = command.ExecuteReader();

                int id = 0;

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        id = Reader.GetInt32(0);
                    }
                }
                Reader.Close();
                command.ExecuteNonQuery();


                MySqlCommand command_fill = new MySqlCommand("SELECT * FROM users WHERE id = @id ", db.getConnection());
                MySqlParameter c3 = new MySqlParameter("@id", id);
                command_fill.Parameters.Add(c3);
                MySqlDataReader Reader_fill = command_fill.ExecuteReader();


                if (Reader_fill.HasRows)
                {
                    while (Reader_fill.Read())
                    {
                        if (role == 1)
                        {
                            admin_contact_name.Text = Reader_fill.GetString(2) + " " + Reader_fill.GetString(1) + " " + Reader_fill.GetString(3);
                            admin_contact_phone.Text = " - " + Reader_fill.GetString(5);
                            admin_contact_email.Text = " - " + Reader_fill.GetString(4);
                            admin_combobox.Text = Reader_fill.GetString(2) + " " + Reader_fill.GetString(1) + " " + Reader_fill.GetString(3);
                        }
                        else if (role == 2)
                        {
                            manager_contact_name.Text = Reader_fill.GetString(2) + " " + Reader_fill.GetString(1) + " " + Reader_fill.GetString(3);
                            manager_contact_phone.Text = " - " + Reader_fill.GetString(5);
                            manager_contact_email.Text = " - " + Reader_fill.GetString(4);
                            manager_combobox.Text = Reader_fill.GetString(2) + " " + Reader_fill.GetString(1) + " " + Reader_fill.GetString(3);
                        }
                    }
                    
                }
                else
                {
                    if (role == 1)
                    {
                        admin_contact_name.Text = "-";
                        admin_contact_phone.Text = "-";
                        admin_contact_email.Text = "-";
                        admin_combobox.Text = "-";
                    }
                    else if (role == 2)
                    {
                        manager_contact_name.Text = "-";
                        manager_contact_phone.Text = "-";
                        manager_contact_email.Text = "-";
                        manager_combobox.Text = "-";
                    }
                }
                Reader_fill.Close();
                command_fill.ExecuteNonQuery();

                db.closeConnection();
            }
            catch (Exception exep)
            {
                if (role == 1)
                {
                    admin_contact_name.Text = "-";
                    admin_contact_phone.Text = "-";
                    admin_contact_email.Text = "-";
                    admin_combobox.Text = "-";
                }
                else if (role == 2)
                {
                    manager_contact_name.Text = "-";
                    manager_contact_phone.Text = "-";
                    manager_contact_email.Text = "-";
                    manager_combobox.Text = "-";
                }
                MessageBox.Show("Оши" + exep);
            }
        }

        private void Fill_combobox(int role, Int32 elem)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            db.openConnection();

            

            int num = elem;


            MySqlCommand command_count = new MySqlCommand("SELECT  COUNT(*) FROM users WHERE role = @role", db.getConnection());
            MySqlParameter c1 = new MySqlParameter("@role", role);
            command_count.Parameters.Add(c1);
            Int32 count = Convert.ToInt32(command_count.ExecuteScalar());
            command_count.ExecuteNonQuery();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE role = @role", db.getConnection());
            MySqlParameter c2 = new MySqlParameter("@role", role);
            command.Parameters.Add(c2);
            MySqlDataReader Reader = command.ExecuteReader();
            Int32[] list = new Int32[count];

            Int32 i = 0;

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    list[i] = Reader.GetInt32(0);
                    i += 1;
                }
            }
            
            Reader.Close();

            int j = 0;

            while (j < count)
            {
                if (j == num)
                {
                    MySqlCommand command_update = new MySqlCommand("UPDATE users SET primacy = '+' WHERE id = @id AND role = @role", db.getConnection());
                    MySqlParameter cu_1 = new MySqlParameter("@id", list[j]);
                    command_update.Parameters.Add(cu_1);
                    MySqlParameter cu_2 = new MySqlParameter("@role", role);
                    command_update.Parameters.Add(cu_2);
                    command_update.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand command_update = new MySqlCommand("UPDATE users SET primacy = '' WHERE id = @id AND role = @role", db.getConnection());
                    MySqlParameter cu_1 = new MySqlParameter("@id", list[j]);
                    command_update.Parameters.Add(cu_1);
                    MySqlParameter cu_2 = new MySqlParameter("@role", role);
                    command_update.Parameters.Add(cu_2);
                    command_update.ExecuteNonQuery();
                }
                j += 1;
            }

            db.closeConnection();
        }

        private void Filler_combobox(int role)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            db.openConnection();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM users WHERE role = @role", db.getConnection());
            MySqlParameter q = new MySqlParameter("@role", role);
            command2.Parameters.Add(q);
            MySqlDataReader Reader2 = command2.ExecuteReader();

            int i = 0;


            if (Reader2.HasRows)
            {
                while (Reader2.Read())
                {
                    if (role == 1)
                    {
                        admin_combobox.Items.Insert(i, Reader2.GetString(2) + " " + Reader2.GetString(1) + " " + Reader2.GetString(3));
                    }
                    else if (role == 2)
                    {
                        manager_combobox.Items.Insert(i, Reader2.GetString(2) + " " + Reader2.GetString(1) + " " + Reader2.GetString(3));
                    }
                    i += 1;
                }
            }
            Reader2.Close();
            command2.ExecuteNonQuery();
            db.closeConnection();
        }



        private void admin_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Fill_combobox(1, admin_combobox.SelectedIndex);
                Fill_contacts(1);
            }
            catch 
            {
            }
            
        }
        private void manager_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Fill_combobox(2, manager_combobox.SelectedIndex);
                Fill_contacts(2);
            }
            catch
            {
            }
        }
    }
}
