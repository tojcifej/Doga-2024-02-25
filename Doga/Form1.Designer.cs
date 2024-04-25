
namespace Doga
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
            this.dataGridView_base = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Kereses = new System.Windows.Forms.Button();
            this.textBox_Kereses_ID = new System.Windows.Forms.TextBox();
            this.label_Kereses_ID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_save_id = new System.Windows.Forms.Label();
            this.label_save_orszag = new System.Windows.Forms.Label();
            this.label_save_honap = new System.Windows.Forms.Label();
            this.label_save_nap = new System.Windows.Forms.Label();
            this.label_save_hossz = new System.Windows.Forms.Label();
            this.label_save_ar = new System.Windows.Forms.Label();
            this.label_save_ellatas = new System.Windows.Forms.Label();
            this.textBox_save_ID = new System.Windows.Forms.TextBox();
            this.textBox_save_orszag = new System.Windows.Forms.TextBox();
            this.textBox_save_Honap = new System.Windows.Forms.TextBox();
            this.textBox_save_nap = new System.Windows.Forms.TextBox();
            this.textBox_save_hossz = new System.Windows.Forms.TextBox();
            this.textBox_save_ar = new System.Windows.Forms.TextBox();
            this.comboBox_save_ellatas = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_base)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_base
            // 
            this.dataGridView_base.AllowUserToAddRows = false;
            this.dataGridView_base.AllowUserToDeleteRows = false;
            this.dataGridView_base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_base.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_base.Name = "dataGridView_base";
            this.dataGridView_base.ReadOnly = true;
            this.dataGridView_base.Size = new System.Drawing.Size(784, 426);
            this.dataGridView_base.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_save);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_save_ellatas);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_save_ar);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_save_hossz);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_save_nap);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_save_Honap);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_save_orszag);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_save_ID);
            this.splitContainer1.Panel1.Controls.Add(this.label_save_ellatas);
            this.splitContainer1.Panel1.Controls.Add(this.label_save_ar);
            this.splitContainer1.Panel1.Controls.Add(this.label_save_hossz);
            this.splitContainer1.Panel1.Controls.Add(this.label_save_nap);
            this.splitContainer1.Panel1.Controls.Add(this.label_save_honap);
            this.splitContainer1.Panel1.Controls.Add(this.label_save_orszag);
            this.splitContainer1.Panel1.Controls.Add(this.label_save_id);
            this.splitContainer1.Panel1.Controls.Add(this.label_Kereses_ID);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Kereses_ID);
            this.splitContainer1.Panel1.Controls.Add(this.Kereses);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_base);
            this.splitContainer1.Size = new System.Drawing.Size(989, 426);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 2;
            // 
            // Kereses
            // 
            this.Kereses.Location = new System.Drawing.Point(12, 51);
            this.Kereses.Name = "Kereses";
            this.Kereses.Size = new System.Drawing.Size(75, 23);
            this.Kereses.TabIndex = 0;
            this.Kereses.Text = "Kereses";
            this.Kereses.UseVisualStyleBackColor = true;
            this.Kereses.Click += new System.EventHandler(this.Kereses_Click);
            // 
            // textBox_Kereses_ID
            // 
            this.textBox_Kereses_ID.Location = new System.Drawing.Point(82, 28);
            this.textBox_Kereses_ID.Name = "textBox_Kereses_ID";
            this.textBox_Kereses_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kereses_ID.TabIndex = 1;
            // 
            // label_Kereses_ID
            // 
            this.label_Kereses_ID.AutoSize = true;
            this.label_Kereses_ID.Location = new System.Drawing.Point(12, 28);
            this.label_Kereses_ID.Name = "label_Kereses_ID";
            this.label_Kereses_ID.Size = new System.Drawing.Size(18, 13);
            this.label_Kereses_ID.TabIndex = 2;
            this.label_Kereses_ID.Text = "ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_save_id
            // 
            this.label_save_id.AutoSize = true;
            this.label_save_id.Location = new System.Drawing.Point(15, 115);
            this.label_save_id.Name = "label_save_id";
            this.label_save_id.Size = new System.Drawing.Size(18, 13);
            this.label_save_id.TabIndex = 3;
            this.label_save_id.Text = "ID";
            // 
            // label_save_orszag
            // 
            this.label_save_orszag.AutoSize = true;
            this.label_save_orszag.Location = new System.Drawing.Point(15, 148);
            this.label_save_orszag.Name = "label_save_orszag";
            this.label_save_orszag.Size = new System.Drawing.Size(40, 13);
            this.label_save_orszag.TabIndex = 4;
            this.label_save_orszag.Text = "Ország";
            // 
            // label_save_honap
            // 
            this.label_save_honap.AutoSize = true;
            this.label_save_honap.Location = new System.Drawing.Point(15, 181);
            this.label_save_honap.Name = "label_save_honap";
            this.label_save_honap.Size = new System.Drawing.Size(39, 13);
            this.label_save_honap.TabIndex = 5;
            this.label_save_honap.Text = "Honap";
            // 
            // label_save_nap
            // 
            this.label_save_nap.AutoSize = true;
            this.label_save_nap.Location = new System.Drawing.Point(12, 216);
            this.label_save_nap.Name = "label_save_nap";
            this.label_save_nap.Size = new System.Drawing.Size(27, 13);
            this.label_save_nap.TabIndex = 6;
            this.label_save_nap.Text = "Nap";
            // 
            // label_save_hossz
            // 
            this.label_save_hossz.AutoSize = true;
            this.label_save_hossz.Location = new System.Drawing.Point(12, 252);
            this.label_save_hossz.Name = "label_save_hossz";
            this.label_save_hossz.Size = new System.Drawing.Size(36, 13);
            this.label_save_hossz.TabIndex = 7;
            this.label_save_hossz.Text = "Hossz";
            // 
            // label_save_ar
            // 
            this.label_save_ar.AutoSize = true;
            this.label_save_ar.Location = new System.Drawing.Point(12, 286);
            this.label_save_ar.Name = "label_save_ar";
            this.label_save_ar.Size = new System.Drawing.Size(17, 13);
            this.label_save_ar.TabIndex = 6;
            this.label_save_ar.Text = "Ar";
            // 
            // label_save_ellatas
            // 
            this.label_save_ellatas.AutoSize = true;
            this.label_save_ellatas.Location = new System.Drawing.Point(12, 319);
            this.label_save_ellatas.Name = "label_save_ellatas";
            this.label_save_ellatas.Size = new System.Drawing.Size(38, 13);
            this.label_save_ellatas.TabIndex = 8;
            this.label_save_ellatas.Text = "Ellátás";
            // 
            // textBox_save_ID
            // 
            this.textBox_save_ID.Location = new System.Drawing.Point(82, 112);
            this.textBox_save_ID.Name = "textBox_save_ID";
            this.textBox_save_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_save_ID.TabIndex = 9;
            // 
            // textBox_save_orszag
            // 
            this.textBox_save_orszag.Location = new System.Drawing.Point(82, 145);
            this.textBox_save_orszag.Name = "textBox_save_orszag";
            this.textBox_save_orszag.Size = new System.Drawing.Size(100, 20);
            this.textBox_save_orszag.TabIndex = 10;
            // 
            // textBox_save_Honap
            // 
            this.textBox_save_Honap.Location = new System.Drawing.Point(82, 178);
            this.textBox_save_Honap.Name = "textBox_save_Honap";
            this.textBox_save_Honap.Size = new System.Drawing.Size(100, 20);
            this.textBox_save_Honap.TabIndex = 11;
            // 
            // textBox_save_nap
            // 
            this.textBox_save_nap.Location = new System.Drawing.Point(82, 213);
            this.textBox_save_nap.Name = "textBox_save_nap";
            this.textBox_save_nap.Size = new System.Drawing.Size(100, 20);
            this.textBox_save_nap.TabIndex = 12;
            // 
            // textBox_save_hossz
            // 
            this.textBox_save_hossz.Location = new System.Drawing.Point(82, 249);
            this.textBox_save_hossz.Name = "textBox_save_hossz";
            this.textBox_save_hossz.Size = new System.Drawing.Size(100, 20);
            this.textBox_save_hossz.TabIndex = 13;
            // 
            // textBox_save_ar
            // 
            this.textBox_save_ar.Location = new System.Drawing.Point(82, 283);
            this.textBox_save_ar.Name = "textBox_save_ar";
            this.textBox_save_ar.Size = new System.Drawing.Size(100, 20);
            this.textBox_save_ar.TabIndex = 14;
            // 
            // comboBox_save_ellatas
            // 
            this.comboBox_save_ellatas.FormattingEnabled = true;
            this.comboBox_save_ellatas.Items.AddRange(new object[] {
            "",
            "reggeli",
            "félpanzió",
            "all inclusive"});
            this.comboBox_save_ellatas.Location = new System.Drawing.Point(82, 319);
            this.comboBox_save_ellatas.Name = "comboBox_save_ellatas";
            this.comboBox_save_ellatas.Size = new System.Drawing.Size(100, 21);
            this.comboBox_save_ellatas.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 362);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "Mentes";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_base)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_base;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_Kereses_ID;
        private System.Windows.Forms.TextBox textBox_Kereses_ID;
        private System.Windows.Forms.Button Kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_save_ellatas;
        private System.Windows.Forms.TextBox textBox_save_ar;
        private System.Windows.Forms.TextBox textBox_save_hossz;
        private System.Windows.Forms.TextBox textBox_save_nap;
        private System.Windows.Forms.TextBox textBox_save_Honap;
        private System.Windows.Forms.TextBox textBox_save_orszag;
        private System.Windows.Forms.TextBox textBox_save_ID;
        private System.Windows.Forms.Label label_save_ellatas;
        private System.Windows.Forms.Label label_save_ar;
        private System.Windows.Forms.Label label_save_hossz;
        private System.Windows.Forms.Label label_save_nap;
        private System.Windows.Forms.Label label_save_honap;
        private System.Windows.Forms.Label label_save_orszag;
        private System.Windows.Forms.Label label_save_id;
    }
}

