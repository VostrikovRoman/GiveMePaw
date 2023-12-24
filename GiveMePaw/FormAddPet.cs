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

        public string pet_type, name, age, wieght, breed, photo, id;

        

        private void FormAddPet_Load(object sender, EventArgs e)
        {

        }

        public FormAddPet(ForEmployers parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            labelTextAddPet.Text = "Изменение животного";
            labelButtSavePet.Text = "Изменить";
        }

        public void Clear()
        {
            NameTxtbx.Text = Pet_typeTxtbx.Text = AgeTxtbx.Text = WeightTxtbx.Text = BreedTxtbx.Text = PhotoTxtbx.Text = string.Empty;
        }

        private void labelButtSavePet_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelButtSavePet.Text == "Добавить")
                {
                    int index = Pet_typeTxtbx.SelectedIndex + 1;
                    Pet std = new Pet(index.ToString().Trim(), NameTxtbx.Text.Trim(), AgeTxtbx.Text.Trim(), WeightTxtbx.Text.Trim(), BreedTxtbx.Text.Trim(), PhotoTxtbx.Text.Trim());
                    DB.AddPet(std);
                    Clear();
                }

                if (labelButtSavePet.Text == "Изменить")
                {
                    int index = Pet_typeTxtbx.SelectedIndex + 1;
                    Pet std = new Pet(index.ToString().Trim(), NameTxtbx.Text.Trim(), AgeTxtbx.Text.Trim(), WeightTxtbx.Text.Trim(), BreedTxtbx.Text.Trim(), PhotoTxtbx.Text.Trim());
                    DB.UpdatePet(std, id);
                }

                _parent.Display();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
