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

        private void ForUsers_Load(object sender, EventArgs e)
        {
            main_Tab_button.BackColor = Color.FromArgb(164, 123, 81);
            give_away_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            info_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
            about_Tab_button.BackColor = Color.FromArgb(92, 65, 48);
        }
    }
}



// label_cat.Parent = pictureBox_Dog;
// label_cat.BackColor = Color.Transparent;