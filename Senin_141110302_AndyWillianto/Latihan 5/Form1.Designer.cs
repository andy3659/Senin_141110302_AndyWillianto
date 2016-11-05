namespace Latihan_5
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
            this.isi = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bold_button = new System.Windows.Forms.ToolStripButton();
            this.italic_button = new System.Windows.Forms.ToolStripButton();
            this.underline_button = new System.Windows.Forms.ToolStripButton();
            this.fontfamilylist = new System.Windows.Forms.ToolStripComboBox();
            this.fontsizelist = new System.Windows.Forms.ToolStripComboBox();
            this.fontcolorlist = new System.Windows.Forms.ToolStripComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isi
            // 
            this.isi.Location = new System.Drawing.Point(0, 49);
            this.isi.Name = "isi";
            this.isi.Size = new System.Drawing.Size(703, 344);
            this.isi.TabIndex = 2;
            this.isi.Text = "";
            this.isi.TextChanged += new System.EventHandler(this.isi_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 25);
            this.toolStrip1.TabIndex = 4;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "&Setting";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editorToolStripMenuItem.Text = "&Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 394);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.isi);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bold_button;
        private System.Windows.Forms.ToolStripButton italic_button;
        private System.Windows.Forms.ToolStripButton underline_button;
        private System.Windows.Forms.ToolStripComboBox fontfamilylist;
        private System.Windows.Forms.ToolStripComboBox fontsizelist;
        private System.Windows.Forms.ToolStripComboBox fontcolorlist;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        public System.Windows.Forms.RichTextBox isi;
    }
}

