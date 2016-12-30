namespace Latihan_POS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.txtNamaCustomer = new System.Windows.Forms.TextBox();
            this.txtAlamatCustomer = new System.Windows.Forms.TextBox();
            this.txtTelpCustomer = new System.Windows.Forms.TextBox();
            this.txtHpCustomer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInputDataCustomer = new System.Windows.Forms.Button();
            this.btnEditDataCustomer = new System.Windows.Forms.Button();
            this.btnHapusDataCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreatedAtCustomer = new System.Windows.Forms.TextBox();
            this.txtUpdatedAtCustomer = new System.Windows.Forms.TextBox();
            this.btnSimpanDataCustomer = new System.Windows.Forms.Button();
            this.btnBatalDataCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HP";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(85, 47);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.ReadOnly = true;
            this.txtIdCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtIdCustomer.TabIndex = 6;
            this.txtIdCustomer.TabStop = false;
            // 
            // txtNamaCustomer
            // 
            this.txtNamaCustomer.Location = new System.Drawing.Point(85, 76);
            this.txtNamaCustomer.Name = "txtNamaCustomer";
            this.txtNamaCustomer.ReadOnly = true;
            this.txtNamaCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtNamaCustomer.TabIndex = 8;
            // 
            // txtAlamatCustomer
            // 
            this.txtAlamatCustomer.Location = new System.Drawing.Point(85, 107);
            this.txtAlamatCustomer.Multiline = true;
            this.txtAlamatCustomer.Name = "txtAlamatCustomer";
            this.txtAlamatCustomer.ReadOnly = true;
            this.txtAlamatCustomer.Size = new System.Drawing.Size(296, 89);
            this.txtAlamatCustomer.TabIndex = 9;
            // 
            // txtTelpCustomer
            // 
            this.txtTelpCustomer.Location = new System.Drawing.Point(281, 47);
            this.txtTelpCustomer.Name = "txtTelpCustomer";
            this.txtTelpCustomer.ReadOnly = true;
            this.txtTelpCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtTelpCustomer.TabIndex = 10;
            // 
            // txtHpCustomer
            // 
            this.txtHpCustomer.Location = new System.Drawing.Point(281, 76);
            this.txtHpCustomer.Name = "txtHpCustomer";
            this.txtHpCustomer.ReadOnly = true;
            this.txtHpCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtHpCustomer.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(875, 247);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnInputDataCustomer
            // 
            this.btnInputDataCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnInputDataCustomer.Name = "btnInputDataCustomer";
            this.btnInputDataCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnInputDataCustomer.TabIndex = 13;
            this.btnInputDataCustomer.Text = "New";
            this.btnInputDataCustomer.UseVisualStyleBackColor = true;
            this.btnInputDataCustomer.Click += new System.EventHandler(this.inputDataCustomer_Click);
            // 
            // btnEditDataCustomer
            // 
            this.btnEditDataCustomer.Location = new System.Drawing.Point(93, 12);
            this.btnEditDataCustomer.Name = "btnEditDataCustomer";
            this.btnEditDataCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEditDataCustomer.TabIndex = 14;
            this.btnEditDataCustomer.Text = "Edit";
            this.btnEditDataCustomer.UseVisualStyleBackColor = true;
            this.btnEditDataCustomer.Click += new System.EventHandler(this.btnEditDataCustomer_Click);
            // 
            // btnHapusDataCustomer
            // 
            this.btnHapusDataCustomer.Location = new System.Drawing.Point(174, 12);
            this.btnHapusDataCustomer.Name = "btnHapusDataCustomer";
            this.btnHapusDataCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnHapusDataCustomer.TabIndex = 15;
            this.btnHapusDataCustomer.Text = "Delete";
            this.btnHapusDataCustomer.UseVisualStyleBackColor = true;
            this.btnHapusDataCustomer.Click += new System.EventHandler(this.btnHapusDataCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Created at";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Updated at";
            // 
            // txtCreatedAtCustomer
            // 
            this.txtCreatedAtCustomer.Location = new System.Drawing.Point(478, 47);
            this.txtCreatedAtCustomer.Name = "txtCreatedAtCustomer";
            this.txtCreatedAtCustomer.ReadOnly = true;
            this.txtCreatedAtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCreatedAtCustomer.TabIndex = 18;
            this.txtCreatedAtCustomer.TabStop = false;
            // 
            // txtUpdatedAtCustomer
            // 
            this.txtUpdatedAtCustomer.Location = new System.Drawing.Point(478, 76);
            this.txtUpdatedAtCustomer.Name = "txtUpdatedAtCustomer";
            this.txtUpdatedAtCustomer.ReadOnly = true;
            this.txtUpdatedAtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatedAtCustomer.TabIndex = 19;
            this.txtUpdatedAtCustomer.TabStop = false;
            // 
            // btnSimpanDataCustomer
            // 
            this.btnSimpanDataCustomer.Location = new System.Drawing.Point(255, 12);
            this.btnSimpanDataCustomer.Name = "btnSimpanDataCustomer";
            this.btnSimpanDataCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanDataCustomer.TabIndex = 20;
            this.btnSimpanDataCustomer.Text = "Save";
            this.btnSimpanDataCustomer.UseVisualStyleBackColor = true;
            this.btnSimpanDataCustomer.Click += new System.EventHandler(this.btnSimpanDataCustomer_Click);
            // 
            // btnBatalDataCustomer
            // 
            this.btnBatalDataCustomer.Location = new System.Drawing.Point(336, 12);
            this.btnBatalDataCustomer.Name = "btnBatalDataCustomer";
            this.btnBatalDataCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnBatalDataCustomer.TabIndex = 21;
            this.btnBatalDataCustomer.Text = "Cancel";
            this.btnBatalDataCustomer.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 471);
            this.Controls.Add(this.btnBatalDataCustomer);
            this.Controls.Add(this.btnSimpanDataCustomer);
            this.Controls.Add(this.txtUpdatedAtCustomer);
            this.Controls.Add(this.txtCreatedAtCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHapusDataCustomer);
            this.Controls.Add(this.btnEditDataCustomer);
            this.Controls.Add(this.btnInputDataCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHpCustomer);
            this.Controls.Add(this.txtTelpCustomer);
            this.Controls.Add(this.txtAlamatCustomer);
            this.Controls.Add(this.txtNamaCustomer);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.TextBox txtNamaCustomer;
        private System.Windows.Forms.TextBox txtAlamatCustomer;
        private System.Windows.Forms.TextBox txtTelpCustomer;
        private System.Windows.Forms.TextBox txtHpCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInputDataCustomer;
        private System.Windows.Forms.Button btnEditDataCustomer;
        private System.Windows.Forms.Button btnHapusDataCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCreatedAtCustomer;
        private System.Windows.Forms.TextBox txtUpdatedAtCustomer;
        private System.Windows.Forms.Button btnSimpanDataCustomer;
        private System.Windows.Forms.Button btnBatalDataCustomer;
    }
}