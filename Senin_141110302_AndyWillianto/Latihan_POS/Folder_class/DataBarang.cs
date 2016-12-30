using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Latihan_POS
{
    class DataBarang
    {
        public MySqlCommand command;
        static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=latihan_pos;";
        public MySqlConnection conn=new MySqlConnection(connectionString);

        public string cekID()
        {
            using (conn)
            {
                conn.Open();
                command = new MySqlCommand("SELECT * FROM dbstokbarang", conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    return "1";
                }
                else
                {
                    reader.Close();
                    command.CommandText = "SELECT MAX(id) FROM dbstokbarang";
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return (reader.GetInt32(0) + 1).ToString();
                    }
                    else{
                        return "";
                    }
                }
                reader.Close();
                conn.Close();
            }
        }

        public void addBarang(string kode, string nama, string jlhAwal, string hargaHpp, string hargaJual)
        {
            command.CommandText = ("INSERT INTO dbstokbarang (kode,nama,jumlah_awal,harga_hpp,harga_jual,created_at,updated_at) VALUES(@kode,@nama,@jumlahawal,@hargahpp,@hargajual,@createdat,@updatedat)");
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@kode", kode);
            command.Parameters.AddWithValue("@nama", nama);
            command.Parameters.AddWithValue("@jumlahawal", jlhAwal);
            command.Parameters.AddWithValue("@hargahpp", hargaHpp);
            command.Parameters.AddWithValue("@hargajual", hargaJual);
            command.Parameters.AddWithValue("@createdat", DateTime.Now);
            command.Parameters.AddWithValue("@updatedat", DateTime.Now);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            command.Parameters.Clear();
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control txtbox in this.Controls)
            {
                if (txtbox is TextBox && txtbox.Name != "txtBoxId")
                {
                    ((TextBox)txtbox).Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
        }*/
    }
}
