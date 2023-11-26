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
            Users_Tab_button.BackColor = Color.FromArgb(228, 164, 84);
            pictureButtUsers.Image = new Bitmap(Properties.Resources.home_Active);
            panelPet.Visible = false;
            panelContact.Visible = false;
            panelUsers.Visible = true;
        }

        private void labelButtPetText_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtPetText.ForeColor = Color.FromArgb(92, 65, 48);
            Pet_Tab_button.BackColor = Color.FromArgb(228, 164, 84);
            pictureButtPet.Image = new Bitmap(Properties.Resources.hand_Active);
            panelPet.Visible = true;
            panelContact.Visible = false;
            panelUsers.Visible = false;
        }

        private void labelButtContactText_Click(object sender, EventArgs e)
        {
            defoult_color();
            labelButtContactText.ForeColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(228, 164, 84);
            pictureButtContact.Image = new Bitmap(Properties.Resources.vibrating_phone_Active);
            panelPet.Visible = false;
            panelContact.Visible = true;
            panelUsers.Visible = false;
        }

        private void defoult_color()
        {
            labelButtUsersText.ForeColor = Color.FromArgb(228, 164, 84);
            Users_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtPetText.ForeColor = Color.FromArgb(228, 164, 84);
            Pet_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            labelButtContactText.ForeColor = Color.FromArgb(228, 164, 84);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);

            pictureButtUsers.Image = new Bitmap(Properties.Resources.home_Passive);

            pictureButtPet.Image = new Bitmap(Properties.Resources.hand_Passive);

            pictureButtContact.Image = new Bitmap(Properties.Resources.vibrating_phone_Passive);

        }

    }
}
