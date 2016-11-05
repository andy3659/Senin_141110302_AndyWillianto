using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4
{
    public partial class Form1 : Form
    {
        public int state;
        public string alamatFile = "";
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
            foreach (KnownColor warna in Enum.GetValues(typeof(KnownColor)))
            {
                fontcolorlist.Items.Add(warna);
            }
            state = 0;
            fontfamilylist.SelectedIndex = 0;
            fontsizelist.SelectedIndex = 13;
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";
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
                bold = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style & ~FontStyle.Bold);
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
            isi.SelectionFont = new System.Drawing.Font(fontfamilylist.Text, isi.SelectionFont.Size, isi.SelectionFont.Style);
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

        private void fungsiSave()
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                isi.SaveFile(saveFileDialog1.FileName);
            }
        }
        private void fungsiLoad()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                isi.LoadFile(openFileDialog1.FileName);
                alamatFile = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alamatFile.Length == 0)
            {
                fungsiSave();
                alamatFile = saveFileDialog1.FileName;
            }
            else
            {
                isi.SaveFile(alamatFile);
            }
            state = 0;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                DialogResult pilihan = MessageBox.Show("Apakah anda ingin melakukan save?", "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (pilihan == (DialogResult.Yes))
                {
                    if (alamatFile.Length == 0)
                    {
                        fungsiSave();
                    }
                    else
                    {
                        isi.SaveFile(alamatFile);
                    }
                    fungsiLoad();
                    state = 0;
                }
                else if (pilihan == (DialogResult.No))
                {
                    fungsiLoad();
                    state = 0;
                }
                else
                {
                    return;
                }
            }
            else
            {
                fungsiLoad();
                state = 0;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                DialogResult pilihan = MessageBox.Show("Apakah anda ingin melakukan save?", "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (pilihan == (DialogResult.Yes))
                {
                    if (alamatFile.Length == 0)
                    {
                        fungsiSave();
                        alamatFile = saveFileDialog1.FileName;
                    }
                    else
                    {
                        isi.SaveFile(alamatFile);
                    }
                    state = 0;
                    isi.ResetText();
                    alamatFile = "";
                }
                else if (pilihan == (DialogResult.No))
                {
                    isi.ResetText();
                    state = 0;
                    alamatFile = "";
                }
                else
                {
                    return;
                }
            }
            else
            {
                isi.ResetText();
                state = 0;
                alamatFile = "";
            }
        }

        private void isi_TextChanged(object sender, EventArgs e)
        {
            state = 1;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                DialogResult pilihan = MessageBox.Show("Apakah anda ingin melakukan save?", "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (pilihan == (DialogResult.Yes))
                {
                    if (alamatFile.Length == 0)
                    {
                        fungsiSave();
                        alamatFile = saveFileDialog1.FileName;
                    }
                    else
                    {
                        isi.SaveFile(alamatFile);
                    }
                    this.Close();
                }
                else if (pilihan == (DialogResult.No))
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
