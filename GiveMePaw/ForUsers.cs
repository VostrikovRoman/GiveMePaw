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
            main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            contact_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
        }

        private void main_Tab_button_Click(object sender, EventArgs e)
        {

        }

        private void give_away_Tab_button_Paint(object sender, PaintEventArgs e)
        {

        }

       



        // panel.Visible = true;
        // название панели.Visible = true
    }
}



// label_cat.Parent = pictureBox_Dog;
// label_cat.BackColor = Color.Transparent;