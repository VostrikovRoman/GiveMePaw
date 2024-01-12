using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace GiveMePaw
{
    public partial class Lost_Internet : Form
    {
        public Lost_Internet()
        {
            InitializeComponent();
        }

        private void adain_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
