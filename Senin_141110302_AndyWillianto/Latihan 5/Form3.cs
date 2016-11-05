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
        private Form1 form1;
        
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
            form1.isi.BackColor = Color.FromName(comboBox1.Text);
        }
    }
}
