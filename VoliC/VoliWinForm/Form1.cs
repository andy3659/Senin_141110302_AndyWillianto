using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoliWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        static int M = 1000000007;
        static private long Combin(int x, int y)
        {
            long result = 1;
            for (int i = 0; i < y; i++)
            {
                result = result * (x - i) / (i + 1);
            }
            return result % M;
        }
        static long pow(long x, long y)
        {
            if (y == 0)
            {
                return 1;
            }
            if (y == 1)
            {
                return x;
            }
            if (x == 0)
            {
                return 0;
            }
            long setengah = pow(x, y / 2);
            if (y % 2 == 0)
            {
                return (setengah * setengah) % M;
            }
            else
            {
                return (((setengah * setengah) % M) * x) % M;
            }
        }
        static long hasil(int a, int b)
        {
            int temp = 0;
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < 25)
            {
                return 0;
            }
            if (a == 25)
            {
                if (b >= 24)
                {
                    return 0;
                }
                else
                {
                    return Combin(a + b - 1, b);
                }
            }
            if (a - b != 2)
            {
                return 0;
            }
            else
            {
                return Combin(48, 24) * pow(2, a - 26) % M;
            }
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(Txt2.Text);
            int text2 = Convert.ToInt32(Txt1.Text);
            TxtHasil.Text = hasil(text1,text2).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
