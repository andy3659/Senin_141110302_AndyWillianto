using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5
{
    public partial class Form3 : Form
    {
        Form1 Form1;
        private Form1 form1
        {
            get { return Form1; }
            set { Form1 = value; }
        }
        public Form3()
        {
            InitializeComponent();
            foreach (KnownColor warna in Enum.GetValues(typeof(KnownColor)))
            {
                comboBox1.Items.Add(warna);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.color = Color.FromName(comboBox1.Text);
        }
    }
}
