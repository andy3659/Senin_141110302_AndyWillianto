using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families.ToArray())
            {
                fontfamilylist.Items.Add(font.Name);
            }
            for (int i = 1; i <= 100; i++)
            {
                fontsizelist.Items.Add(i);
            }
            foreach(KnownColor warna in Enum.GetValues(typeof(KnownColor))){
                fontcolorlist.Items.Add(warna);
            }
            fontfamilylist.SelectedIndex = 0;
            fontsizelist.SelectedIndex = 13;
        }

        private void bold_Click(object sender, EventArgs e)
        {
            Font bold;
            if (isi.SelectionFont == null)
            {
                return;
            }
            if (isi.SelectionFont.Style.ToString().Contains("Bold"))
            {
                bold = new Font(isi.SelectionFont.FontFamily,isi.SelectionFont.Size,isi.SelectionFont.Style &~ FontStyle.Bold);
                bold_button.Checked = false;
            }
            else
            {
                bold = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style | FontStyle.Bold);
                bold_button.Checked = true;
            }
            isi.SelectionFont = bold;
        }

        private void italic_Click(object sender, EventArgs e)
        {
            Font italic;
            if (isi.SelectionFont == null)
            {
                return;
            }
            if (isi.SelectionFont.Style.ToString().Contains("Italic"))
            {
                italic = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style & ~FontStyle.Italic);
                italic_button.Checked = false;
            }
            else
            {
                italic = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style | FontStyle.Italic);
                italic_button.Checked = true;
            }
            isi.SelectionFont = italic;
        }

        private void underline_Click(object sender, EventArgs e)
        {
            Font underline;
            if (isi.SelectionFont == null)
            {
                return;
            }
            if (isi.SelectionFont.Style.ToString().Contains("Underline"))
            {
                underline = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style & ~FontStyle.Underline);
                underline_button.Checked = false;
            }
            else
            {
                underline = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style | FontStyle.Underline);
                underline_button.Checked = true;
            }
            isi.SelectionFont = underline;
        }

        private void fontfamilylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionFont = new System.Drawing.Font(fontfamilylist.Text,isi.SelectionFont.Size,isi.SelectionFont.Style);
        }

        private void fontsizelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionFont = new System.Drawing.Font(isi.SelectionFont.FontFamily, Convert.ToInt32(fontsizelist.Text), isi.SelectionFont.Style);
        }

        private void fontcolorlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionColor = Color.FromName(fontcolorlist.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
