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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            treeView1.Nodes.Add("Theme");
            treeView1.Nodes[0].Nodes.Add("Background Color");
            theme.MdiParent = this;
        }
        public Form3 theme = new Form3();
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes[0].Nodes[0].IsSelected)
            {
                theme.Show();
                theme.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
