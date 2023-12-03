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
    public partial class FormAddPet : Form
    {
        private readonly ForEmployers _parent;
        
        public FormAddPet(ForEmployers parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            NameTxtbx.Text = Pet_typeTxtbx.Text = AgeTxtbx.Text = WeightTxtbx.Text = BreedTxtbx.Text = PhotoTxtbx.Text = string.Empty;
        }

        private void labelButtSavePet_Click(object sender, EventArgs e)
        {
            DB bd = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `pets` (`pet_type`, `name`, `age`, `weight`, `breed`, `photo`) VALUES (@PT, @NAME, @AGE, @WEIGHT, @BREED, @PHOTO)", bd.getConnection());
            command.Parameters.Add("@PT", MySqlDbType.Int32).Value = Pet_typeTxtbx.Text;
            command.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = NameTxtbx.Text;
            command.Parameters.Add("@AGE", MySqlDbType.Int32).Value = AgeTxtbx.Text;
            command.Parameters.Add("@WEIGHT", MySqlDbType.Int32).Value = WeightTxtbx.Text;
            command.Parameters.Add("@BREED", MySqlDbType.VarChar).Value = BreedTxtbx.Text;
            command.Parameters.Add("@PHOTO", MySqlDbType.VarChar).Value = PhotoTxtbx.Text;
            bd.openConnection();
            command.ExecuteNonQuery();
            bd.closeConnection();
            Clear();
            _parent.Display();




        }
    }
}
