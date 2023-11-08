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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void link_to_sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInDisplay.Visible = false;
            SignUpDisplay.Visible = true;

            email_sign_in.Text = "email";
            password_sign_in.Text = "пароль";

        }

        private void link_to_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInDisplay.Visible = true;
            SignUpDisplay.Visible = false;

            surname_sign_up.Text = "фамилия";
            name_sign_up.Text = "имя";
            last_name_sign_up.Text = "отчество";
            phone_sign_up.Text = "телефон";
            email_sign_up.Text = "email";
            password_sign_up.Text = "пароль";
        }

        private void save_button_sign_up_Click(object sender, EventArgs e)
        {
            surname_sign_up.Text = "фамилия";
            name_sign_up.Text = "имя";
            last_name_sign_up.Text = "отчество";
            phone_sign_up.Text = "телефон";
            email_sign_up.Text = "email";
            password_sign_up.Text = "пароль";


            SignIn.ActiveForm.Hide();
            ForUsers NewForm = new ForUsers();
            NewForm.ShowDialog();
            Close();
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            email_sign_in.Text = "email";
            password_sign_in.Text = "пароль";

            SignIn.ActiveForm.Hide();
            ForUsers NewForm = new ForUsers();
            NewForm.ShowDialog();
            Close();
        }


        /////Текст-подсказка для формы входа и регистрации/////
        private void email_sign_in_Enter(object sender, EventArgs e)
        {
           if (email_sign_in.Text == "email")
            {
                email_sign_in.Text = "";
            }
        }
        private void email_sign_in_Leave(object sender, EventArgs e)
        {
            if (email_sign_in.Text == "")
            {
                email_sign_in.Text = "email";
            }
        }

        private void password_sign_in_Enter(object sender, EventArgs e)
        {
            if (password_sign_in.Text == "пароль")
            {
                password_sign_in.Text = "";
                password_sign_in.UseSystemPasswordChar = true;
            }
        }

        private void password_sign_in_Leave(object sender, EventArgs e)
        {
            if (password_sign_in.Text == "")
            {
                password_sign_in.Text = "пароль";
                password_sign_in.UseSystemPasswordChar = false;
            }
            else
            {
                password_sign_in.UseSystemPasswordChar = true;
            }
        }

        private void surname_sign_up_Enter(object sender, EventArgs e)
        {
            if (surname_sign_up.Text == "фамилия")
            {
                surname_sign_up.Text = "";
            }
        }

        private void surname_sign_up_Leave(object sender, EventArgs e)
        {
            if (surname_sign_up.Text == "")
            {
                surname_sign_up.Text = "фамилия";
            }
        }

        private void name_sign_up_Enter(object sender, EventArgs e)
        {
            if (name_sign_up.Text == "имя")
            {
                name_sign_up.Text = "";
            }
        }

        private void name_sign_up_Leave(object sender, EventArgs e)
        {
            if (name_sign_up.Text == "")
            {
                name_sign_up.Text = "имя";
            }
        }

        private void last_name_sign_up_Enter(object sender, EventArgs e)
        {
            if (last_name_sign_up.Text == "отчество")
            {
                last_name_sign_up.Text = "";
            }
        }

        private void last_name_sign_up_Leave(object sender, EventArgs e)
        {
            if (last_name_sign_up.Text == "")
            {
                last_name_sign_up.Text = "отчество";
            }
        }

        private void phone_sign_up_Enter(object sender, EventArgs e)
        {
            if (phone_sign_up.Text == "телефон")
            {
                phone_sign_up.Text = "";
            }
        }

        private void phone_sign_up_Leave(object sender, EventArgs e)
        {
            if (phone_sign_up.Text == "")
            {
                phone_sign_up.Text = "телефон";
            }
        }

        private void email_sign_up_Enter(object sender, EventArgs e)
        {
            if (email_sign_up.Text == "email")
            {
                email_sign_up.Text = "";
            }
        }

        private void email_sign_up_Leave(object sender, EventArgs e)
        {
            if (email_sign_up.Text == "")
            {
                email_sign_up.Text = "email";
            }
        }

        private void password_sign_up_Enter(object sender, EventArgs e)
        {
            if (password_sign_up.Text == "пароль")
            {
                password_sign_up.Text = "";
            }
        }

        private void password_sign_up_Leave(object sender, EventArgs e)
        {
            if (password_sign_up.Text == "")
            {
                password_sign_up.Text = "пароль";
            }
        }
        /////     /////
    }
}
