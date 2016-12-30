using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Latihan_POS
{
    public partial class Form2 : Form
    {
        /*static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=latihan_pos;";
        public MySqlConnection conn=new MySqlConnection(connectionString);
        public MySqlCommand command;*/
        DataBarang barang = new DataBarang();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*using (conn)
            {
                conn.Open();
                command = new MySqlCommand("SELECT * FROM dbstokbarang", conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    txtBoxId.Text = "1";
                }
                else
                {
                    reader.Close();
                    command.CommandText = "SELECT MAX(id) FROM dbstokbarang";
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtBoxId.Text = (reader.GetInt32(0) + 1).ToString();
                        reader.Close();
                    }
                }
                conn.Close();
            }*/
            txtBoxId.Text = barang.cekID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxKode.Text) && !string.IsNullOrWhiteSpace(txtBoxNama.Text) && !string.IsNullOrWhiteSpace(txtBoxJumlahAwal.Text) && !string.IsNullOrWhiteSpace(txtBoxHargaHPP.Text) && !string.IsNullOrWhiteSpace(txtBoxHargaJual.Text))
            {
                barang.addBarang(txtBoxKode.Text, txtBoxNama.Text, txtBoxJumlahAwal.Text, txtBoxHargaHPP.Text, txtBoxHargaJual.Text);
                /*
                command.CommandText = ("INSERT INTO dbstokbarang (kode,nama,jumlah_awal,harga_hpp,harga_jual,created_at,updated_at) VALUES(@kode,@nama,@jumlahawal,@hargahpp,@hargajual,@createdat,@updatedat)");
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@kode", txtBoxKode.Text);
                command.Parameters.AddWithValue("@nama", txtBoxNama.Text);
                command.Parameters.AddWithValue("@jumlahawal", txtBoxJumlahAwal.Text);
                command.Parameters.AddWithValue("@hargahpp", txtBoxHargaHPP.Text);
                command.Parameters.AddWithValue("@hargajual", txtBoxHargaJual.Text);
                command.Parameters.AddWithValue("@createdat", DateTime.Now);
                command.Parameters.AddWithValue("@updatedat", DateTime.Now);
                txtBoxId.Text = (Convert.ToInt32(txtBoxId.Text) + 1).ToString();
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                command.Parameters.Clear();*/
                txtBoxId.Text = (Convert.ToInt32(txtBoxId.Text) + 1).ToString();
                foreach (Control txtbox in this.Controls)
                {
                    if (txtbox is TextBox && txtbox.Name!="txtBoxId")
                    {
                        ((TextBox)txtbox).Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
