using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DateTime sekarang;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
            label2.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            sekarang = DateTime.Today;
            label1.Text = vScrollBar1.Value.ToString();
            textBox1.Text = (vScrollBar1.Value + vScrollBar2.Value).ToString();
            sekarang = new DateTime(sekarang.Year + vScrollBar1.Value + vScrollBar2.Value, sekarang.Month, sekarang.Day);
            dateTimePicker1.MaxDate = sekarang;
            textBox3.Text = sekarang.ToString("dd/MM/yy");
            sekarang = DateTime.Today;
            sekarang = new DateTime(Math.Abs(sekarang.Year - (vScrollBar1.Value + vScrollBar2.Value)), sekarang.Month, sekarang.Day);
            dateTimePicker1.MinDate = sekarang;
            textBox2.Text = sekarang.ToString("dd/MM/yy");
            
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            sekarang = DateTime.Today;
            label2.Text = vScrollBar2.Value.ToString();
            textBox1.Text = (vScrollBar1.Value + vScrollBar2.Value).ToString();
            sekarang = new DateTime(sekarang.Year + vScrollBar1.Value + vScrollBar2.Value, sekarang.Month, sekarang.Day);
            textBox3.Text = sekarang.ToString("dd/MM/yy");
            dateTimePicker1.MaxDate = sekarang;
            sekarang = DateTime.Today;
            sekarang = new DateTime(Math.Abs(sekarang.Year - (vScrollBar1.Value + vScrollBar2.Value)), sekarang.Month, sekarang.Day);
            textBox2.Text = sekarang.ToString("dd/MM/yy");
            dateTimePicker1.MinDate = sekarang;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
