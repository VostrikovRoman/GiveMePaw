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


        }

        private void link_to_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInDisplay.Visible = true;
            SignUpDisplay.Visible = false;
        }

        private void save_button_sign_up_Click(object sender, EventArgs e)
        {
            SignIn.ActiveForm.Hide();
            ForUsers NewForm = new ForUsers();
            NewForm.ShowDialog();
            Close();
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            SignIn.ActiveForm.Hide();
            ForUsers NewForm = new ForUsers();
            NewForm.ShowDialog();
            Close();
        }
    }
}
