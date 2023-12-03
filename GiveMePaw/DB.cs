using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiveMePaw
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=26.102.87.80; port=3306;username=1;password=pet14521;database=givemepaw");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public static void AddPet(Pet std)
        {
            DB db = new DB();
            string sql = "INSERT INTO `pets` VALUES ('null', '@pet_type', '@name,' '@age', '@weight', '@breed', @photo)";
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@pet_type", MySqlDbType.Int32).Value = std.Pet_type;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@age", MySqlDbType.Int32).Value = std.Age;
            cmd.Parameters.Add("@Weight", MySqlDbType.Int32).Value = std.Weight;
            cmd.Parameters.Add("@breed", MySqlDbType.VarChar).Value = std.Breed;
            cmd.Parameters.Add("@photo", MySqlDbType.VarChar).Value = std.Photo;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Добовление прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить животное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdatePet(Pet std, string id)
        {
            DB db = new DB();
            string sql = "UPDATE `pets` SET pet_type = @pet_type, name = @name, age = @age, weight = @weight, breed = @breed, photo = @photo WHERE id = @id";
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@pet_type", MySqlDbType.Int32).Value = std.Pet_type;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@age", MySqlDbType.Int32).Value = std.Age;
            cmd.Parameters.Add("@Weight", MySqlDbType.Int32).Value = std.Weight;
            cmd.Parameters.Add("@breed", MySqlDbType.VarChar).Value = std.Breed;
            cmd.Parameters.Add("@photo", MySqlDbType.VarChar).Value = std.Photo;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Изменение прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось изменить животное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeletePet(string id)
        {
            DB db = new DB();
            string sql = "DELETE FROM pets WHERE id = @id";
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить животное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSerachPet(String query, DataGridView dvg)
        {
            DB db = new DB();
            string sql = query;
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dvg.DataSource = tbl;
            con.Close();  


        }
    }
}

