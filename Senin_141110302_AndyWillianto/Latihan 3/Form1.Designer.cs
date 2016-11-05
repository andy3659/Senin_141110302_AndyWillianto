namespace Latihan_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bold_button = new System.Windows.Forms.ToolStripButton();
            this.italic_button = new System.Windows.Forms.ToolStripButton();
            this.underline_button = new System.Windows.Forms.ToolStripButton();
            this.fontfamilylist = new System.Windows.Forms.ToolStripComboBox();
            this.fontsizelist = new System.Windows.Forms.ToolStripComboBox();
            this.fontcolorlist = new System.Windows.Forms.ToolStripComboBox();
            this.isi = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bold_button,
            this.italic_button,
            this.underline_button,
            this.fontfamilylist,
            this.fontsizelist,
            this.fontcolorlist});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bold_button
            // 
            this.bold_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bold_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold_button.Image = ((System.Drawing.Image)(resources.GetObject("bold_button.Image")));
            this.bold_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold_button.Name = "bold_button";
            this.bold_button.Size = new System.Drawing.Size(23, 22);
            this.bold_button.Text = "B";
            this.bold_button.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic_button
            // 
            this.italic_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italic_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic_button.Image = ((System.Drawing.Image)(resources.GetObject("italic_button.Image")));
            this.italic_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic_button.Name = "italic_button";
            this.italic_button.Size = new System.Drawing.Size(23, 22);
            this.italic_button.Text = "I";
            this.italic_button.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline_button
            // 
            this.underline_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underline_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline_button.Image = ((System.Drawing.Image)(resources.GetObject("underline_button.Image")));
            this.underline_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(23, 22);
            this.underline_button.Text = "U";
            this.underline_button.Click += new System.EventHandler(this.underline_Click);
            // 
            // fontfamilylist
            // 
            this.fontfamilylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontfamilylist.Name = "fontfamilylist";
            this.fontfamilylist.Size = new System.Drawing.Size(121, 25);
            this.fontfamilylist.SelectedIndexChanged += new System.EventHandler(this.fontfamilylist_SelectedIndexChanged);
            // 
            // fontsizelist
            // 
            this.fontsizelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontsizelist.Name = "fontsizelist";
            this.fontsizelist.Size = new System.Drawing.Size(75, 25);
            this.fontsizelist.SelectedIndexChanged += new System.EventHandler(this.fontsizelist_SelectedIndexChanged);
            // 
            // fontcolorlist
            // 
            this.fontcolorlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontcolorlist.Name = "fontcolorlist";
            this.fontcolorlist.Size = new System.Drawing.Size(121, 25);
            this.fontcolorlist.SelectedIndexChanged += new System.EventHandler(this.fontcolorlist_SelectedIndexChanged);
            // 
            // isi
            // 
            this.isi.Location = new System.Drawing.Point(12, 28);
            this.isi.Name = "isi";
            this.isi.Size = new System.Drawing.Size(679, 354);
            this.isi.TabIndex = 1;
            this.isi.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 394);
            this.Controls.Add(this.isi);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bold_button;
        private System.Windows.Forms.ToolStripButton italic_button;
        private System.Windows.Forms.ToolStripButton underline_button;
        private System.Windows.Forms.ToolStripComboBox fontfamilylist;
        private System.Windows.Forms.ToolStripComboBox fontsizelist;
        private System.Windows.Forms.ToolStripComboBox fontcolorlist;
        private System.Windows.Forms.RichTextBox isi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

