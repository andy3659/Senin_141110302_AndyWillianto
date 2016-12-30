using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        //static string connectionString = "Server=127.0.0.1;Database=latihan_pos;Uid=root;Pwd=;";
        //public MySqlConnection conn = new MySqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formTambahBarang = new Form2();
            formTambahBarang.MdiParent = this;
            formTambahBarang.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formDataCustomer = new Form3();
            formDataCustomer.MdiParent = this;
            formDataCustomer.Show();
        }
    }
}
