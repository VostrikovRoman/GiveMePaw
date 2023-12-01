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
        public ForEmployers()
        {
            InitializeComponent();
        }
        
       
        private void labelButtUsersText_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtUsersText.ForeColor = Color.FromArgb(92, 65, 48);
            Users_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            pictureButtUsers.Image = new Bitmap(Properties.Resources.home_Active);
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
            pictureButtPet.Image = new Bitmap(Properties.Resources.hand_Active);
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
            pictureButtContact.Image = new Bitmap(Properties.Resources.vibrating_phone_Active);
            panelPet.Visible = false;
            panelContact.Visible = true;
            panelUsersFind.Visible = false;
            panelInfo.Visible = false;
        }

        private void labelButInfo_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButInfo.ForeColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            picturePaw.Image = new Bitmap(Properties.Resources.paw_Active);
            panelPet.Visible = false;
            panelContact.Visible = false;
            panelUsersFind.Visible = false;
            panelInfo.Visible = true;
        }


        private void defoult_color()
        {
            labelButtUsersText.ForeColor = Color.FromArgb(164, 123, 81);
            Users_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtPetText.ForeColor = Color.FromArgb(164, 123, 81);
            Pet_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtContactText.ForeColor = Color.FromArgb(164, 123, 81);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButInfo.ForeColor = Color.FromArgb(164, 123, 81);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);



            pictureButtUsers.Image = new Bitmap(Properties.Resources.home_Passive);

            pictureButtPet.Image = new Bitmap(Properties.Resources.hand_Passive);

            pictureButtContact.Image = new Bitmap(Properties.Resources.vibrating_phone_Passive);

            picturePaw.Image = new Bitmap(Properties.Resources.paw_Passive);

        }

        private void labelButtFindUser_Click(object sender, EventArgs e)
        {
            String email = emailFindUser.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * FROM `users` INNER JOIN `roles` ON users.role = roles.id_roles WHERE `email` = @eU", db.getConnection());
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

                labelEmail.Text = Convert.ToString(table.Rows[0][4]);
                labelSecondName.Text = "Фамилия: " + Convert.ToString(table.Rows[0][2]);
                labelName.Text = "Имя: " + Convert.ToString(table.Rows[0][1]);
                labelPatronomic.Text = "Отчество: " + Convert.ToString(table.Rows[0][3]);
                labelPhoneNum.Text = "Номер телефона: " + Convert.ToString(table.Rows[0][5]);
                labelRole.Text = "Роль: " + Convert.ToString(table.Rows[0][9]);
            }
            else
            {
                MessageBox.Show("Пользователя с таким email, не существует!");
            }
        }

        private void labelChangeRoleAdmin_Click(object sender, EventArgs e)
        {
            panelUserInfo.Visible = false;
            panelConfirmAdmin.Visible = true;
            labelButtBackText.Enabled = false;
            labelConfirmAdmin.Text = "Вы уверены что хотите назначить пользователя "+labelEmail.Text + " адиминистратором?";

        }

        private void labelChangeRoleManag_Click(object sender, EventArgs e)
        {
            panelUserInfo.Visible = false;
            panelConfirmManager.Visible = true;
            labelButtBackText.Enabled = false;
            labelConfirmManager.Text = "Вы уверены что хотите назначить пользователя "+labelEmail.Text+" менеджером?";

        }

        private void labelChangeRoleUser_Click(object sender, EventArgs e)
        {
            panelUserInfo.Visible = false;
            panelConfirmUser.Visible = true;
            labelButtBackText.Enabled = false;
            labelConfirmUser.Text = "Вы уверены что хотите назначить пользователя "+labelEmail.Text+" пользователем?";

        }

        private void refreshUserStatus()
        {
            String email = labelEmail.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * FROM `users` INNER JOIN `roles` ON users.role = roles.id_roles WHERE `email` = '" + email + "'", db.getConnection());
            
            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();

            labelRole.Text = "Роль: " + Convert.ToString(table.Rows[0][9]);
         
        }

        private void labelButtBackText_Click(object sender, EventArgs e)
        {
            panelBackButtBack.Visible = false;
            panelFindUsers.Visible = true;
            panelUser.Visible = false;

        }

        private void labelButConfirmAdminY_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string email = labelEmail.Text; 
            MySqlCommand command = new MySqlCommand("UPDATE `givemepaw`.`users` SET `role` = '1' WHERE (`email`= '" + email + "');", db.getConnection());
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            refreshUserStatus();
            panelUserInfo.Visible = true;
            panelConfirmAdmin.Visible = false;
            labelButtBackText.Enabled = true;

        }

        private void labelButConfirmAdminN_Click(object sender, EventArgs e)
        {
            panelUserInfo.Visible = true;
            panelConfirmAdmin.Visible = false;
            labelButtBackText.Enabled = true;
        }

        private void labelButConfirmManagerY_Click(object sender, EventArgs e)
        {
           DB db = new DB();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           string email = labelEmail.Text;
           MySqlCommand command = new MySqlCommand("UPDATE `givemepaw`.`users` SET `role` = '2' WHERE (`email`= '" + email + "');", db.getConnection());
           db.openConnection();
           command.ExecuteNonQuery();
           db.closeConnection();
           refreshUserStatus();
           panelUserInfo.Visible = true;
           panelConfirmManager.Visible = false;
           labelButtBackText.Enabled = true;
        }

        private void labelButConfirmManagerN_Click(object sender, EventArgs e)
        {
            panelUserInfo.Visible = true;
            panelConfirmManager.Visible = false;
            labelButtBackText.Enabled = true;
        }

        private void labelButConfirmUserY_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string email = labelEmail.Text;
            MySqlCommand command = new MySqlCommand("UPDATE `givemepaw`.`users` SET `role` = '3' WHERE (`email`= '" + email + "');", db.getConnection());
            
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            refreshUserStatus();
            panelUserInfo.Visible = true;
            panelConfirmUser.Visible = false;
            labelButtBackText.Enabled = true;
        }

        private void labelButConfirmUserN_Click(object sender, EventArgs e)
        {
            panelUserInfo.Visible = true;
            panelConfirmUser.Visible = false;
            labelButtBackText.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormAddPet form = new FormAddPet();
            form.ShowDialog();
        }
    }
}
