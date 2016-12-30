using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Form3 : Form
    {
        DataCustomer customer = new DataCustomer();
        DataTable dt = new DataTable();
        bool newstate = false;
        bool editstate = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void inputDataCustomer_Click(object sender, EventArgs e)
        {
            txtIdCustomer.Text = customer.cekID();
            txtNamaCustomer.Clear();
            txtAlamatCustomer.Clear();
            txtHpCustomer.Clear();
            txtTelpCustomer.Clear();

            txtNamaCustomer.ReadOnly = false;
            txtAlamatCustomer.ReadOnly = false;
            txtHpCustomer.ReadOnly = false;
            txtTelpCustomer.ReadOnly = false;
            txtNamaCustomer.Focus();
            btnInputDataCustomer.Enabled = false;
            newstate = true;
        }
         public void dgvrefresh()
         {
             if (dataGridView1.SelectedRows.Count == 0 || newstate == true)
             {
                 btnEditDataCustomer.Enabled = false;
                 btnHapusDataCustomer.Enabled = false;
             }
             else
             {
                 btnEditDataCustomer.Enabled = true;
                 btnHapusDataCustomer.Enabled = true;
             }
             dt = customer.tabelCustomer();
             dataGridView1.DataSource = dt;
             dataGridView1.Refresh();
         }
        private void Form3_Load(object sender, EventArgs e)
        {
            dgvrefresh();
        }

        private void btnSimpanDataCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNamaCustomer.Text) && !string.IsNullOrWhiteSpace(txtAlamatCustomer.Text) && !string.IsNullOrWhiteSpace(txtTelpCustomer.Text) && !string.IsNullOrWhiteSpace(txtHpCustomer.Text))
            {
                if (newstate == true && editstate==false)
                {
                    customer.inputDataCustomer(txtNamaCustomer.Text, txtAlamatCustomer.Text, txtTelpCustomer.Text, txtHpCustomer.Text);
                    newstate = false;
                    txtNamaCustomer.ReadOnly = true;
                    txtAlamatCustomer.ReadOnly = true;
                    txtHpCustomer.ReadOnly = true;
                    txtTelpCustomer.ReadOnly = true;
                    btnInputDataCustomer.Enabled = true;
                    dgvrefresh();
                }
                else if (editstate == true && newstate == false)
                {
                    customer.editDataCustomer(Convert.ToInt32(txtIdCustomer.Text), txtNamaCustomer.Text, txtAlamatCustomer.Text, txtTelpCustomer.Text, txtHpCustomer.Text);
                    dgvrefresh();
                }
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;

            if (dataGridView1.SelectedRows.Count == 0 || newstate==true)
            {
                btnEditDataCustomer.Enabled = false;
                btnHapusDataCustomer.Enabled = false;
            }
            else
            {
                btnEditDataCustomer.Enabled = true;
                btnHapusDataCustomer.Enabled = true;
            }
            if (newstate == false)
            {
                txtIdCustomer.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtNamaCustomer.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtAlamatCustomer.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtTelpCustomer.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtHpCustomer.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtCreatedAtCustomer.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtUpdatedAtCustomer.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnHapusDataCustomer_Click(object sender, EventArgs e)
        {
            customer.hapusDataCustomer(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dgvrefresh();
            btnEditDataCustomer.Enabled = false;
            btnHapusDataCustomer.Enabled = false;
        }

        private void btnEditDataCustomer_Click(object sender, EventArgs e)
        {
            txtNamaCustomer.ReadOnly = false;
            txtAlamatCustomer.ReadOnly = false;
            txtHpCustomer.ReadOnly = false;
            txtTelpCustomer.ReadOnly = false;
            txtNamaCustomer.Focus();
            btnInputDataCustomer.Enabled = false;
            
        }
    }
}
