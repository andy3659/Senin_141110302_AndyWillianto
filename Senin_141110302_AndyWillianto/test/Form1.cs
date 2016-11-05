using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 baru = new Form2();
            baru.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
