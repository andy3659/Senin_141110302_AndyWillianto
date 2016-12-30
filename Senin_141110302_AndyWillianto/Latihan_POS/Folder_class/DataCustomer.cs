using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Latihan_POS
{
    class DataCustomer
    {
        static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=latihan_pos;";
        static MySqlConnection conn = new MySqlConnection(connectionString);
        public MySqlCommand command = new MySqlCommand("", conn);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public string cekID()
        {
            conn.Open();
            command = new MySqlCommand("SELECT * FROM dbcustomer", conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows == false)
            {
                reader.Close();
                conn.Close();
                return "1";
            }
            else
            {
                reader.Close();
                command.CommandText = "SELECT MAX(CustomerID) FROM dbcustomer";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string hasil = (reader.GetInt32(0) + 1).ToString();
                    reader.Close();
                    conn.Close();
                    return hasil;
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return "";
                }
            }
            
        }
        public DataTable tabelCustomer()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM dbcustomer",conn);
            DataTable dt = new DataTable("dbcustomer");
            da.Fill(dt);
            return dt;
        }
        public void inputDataCustomer(string nama, string alamat, string telp, string hp)
        {
            command.CommandText = "INSERT INTO dbcustomer (Nama,Alamat,Telp,Hp,CreatedAt,UpdatedAt) VALUES(@nama,@alamat,@telp,@hp,@createdat,@updatedat)";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@nama", nama);
            command.Parameters.AddWithValue("@alamat", alamat);
            command.Parameters.AddWithValue("@telp", telp);
            command.Parameters.AddWithValue("@hp", hp);
            command.Parameters.AddWithValue("@createdat", DateTime.Now);
            command.Parameters.AddWithValue("@updatedat", DateTime.Now);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            command.Parameters.Clear();
        }
        public void hapusDataCustomer(int id)
        {
            command.CommandText = "DELETE FROM dbcustomer WHERE CustomerID = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            command.Parameters.Clear();
        }
        public void editDataCustomer(int id,string nama, string alamat,string telp,string hp)
        {
            command.CommandText = "UPDATE dbcustomer SET Nama=@nama,Alamat=@alamat,Telp=@telp,Hp=@hp,UpdatedAt=@updatedat WHERE CustomerID=@id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@nama", nama);
            command.Parameters.AddWithValue("@alamat", alamat);
            command.Parameters.AddWithValue("@telp", telp);
            command.Parameters.AddWithValue("@hp", hp);
            command.Parameters.AddWithValue("@updatedat", DateTime.Now);
            command.Parameters.AddWithValue("@id", id);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            command.Parameters.Clear();
        }
    }
}
