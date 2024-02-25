namespace APP1
{
    partial class categoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.catDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.catDescTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.catNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catIDtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(8, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(8, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.catDGV);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.catDescTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.catNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.catIDtb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(120, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 532);
            this.panel1.TabIndex = 11;
            // 
            // catDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.catDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.catDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catDGV.BackgroundColor = System.Drawing.Color.White;
            this.catDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.catDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.catDGV.ColumnHeadersHeight = 25;
            this.catDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.catDGV.EnableHeadersVisualStyles = false;
            this.catDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.catDGV.Location = new System.Drawing.Point(343, 117);
            this.catDGV.Name = "catDGV";
            this.catDGV.RowHeadersVisible = false;
            this.catDGV.RowTemplate.Height = 30;
            this.catDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catDGV.Size = new System.Drawing.Size(538, 372);
            this.catDGV.TabIndex = 17;
            this.catDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.catDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.catDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.catDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.catDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.catDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.catDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.catDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.catDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.catDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.catDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.catDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.catDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.catDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.catDGV.ThemeStyle.ReadOnly = false;
            this.catDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.catDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.catDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.catDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.catDGV.ThemeStyle.RowsStyle.Height = 30;
            this.catDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.catDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.catDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellContentClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button8.Location = new System.Drawing.Point(214, 315);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 37);
            this.button8.TabIndex = 16;
            this.button8.Text = "DELETE";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(123, 315);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 37);
            this.button7.TabIndex = 15;
            this.button7.Text = "EDIT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(35, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // catDescTb
            // 
            this.catDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catDescTb.DefaultText = "";
            this.catDescTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.catDescTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.catDescTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catDescTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catDescTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catDescTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catDescTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catDescTb.Location = new System.Drawing.Point(133, 229);
            this.catDescTb.Name = "catDescTb";
            this.catDescTb.PasswordChar = '\0';
            this.catDescTb.PlaceholderText = "";
            this.catDescTb.SelectedText = "";
            this.catDescTb.Size = new System.Drawing.Size(173, 26);
            this.catDescTb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "DESCRIPTION";
            // 
            // catNameTb
            // 
            this.catNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catNameTb.DefaultText = "";
            this.catNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.catNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.catNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catNameTb.Location = new System.Drawing.Point(133, 170);
            this.catNameTb.Name = "catNameTb";
            this.catNameTb.PasswordChar = '\0';
            this.catNameTb.PlaceholderText = "";
            this.catNameTb.SelectedText = "";
            this.catNameTb.Size = new System.Drawing.Size(173, 26);
            this.catNameTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAME";
            // 
            // catIDtb
            // 
            this.catIDtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catIDtb.DefaultText = "";
            this.catIDtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.catIDtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.catIDtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catIDtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catIDtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catIDtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catIDtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catIDtb.Location = new System.Drawing.Point(133, 110);
            this.catIDtb.Name = "catIDtb";
            this.catIDtb.PasswordChar = '\0';
            this.catIDtb.PlaceholderText = "";
            this.catIDtb.SelectedText = "";
            this.catIDtb.Size = new System.Drawing.Size(173, 26);
            this.catIDtb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGE CATEGORIES";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(971, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(19, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // categoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 574);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryForm";
            this.Load += new System.EventHandler(this.categoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView catDGV;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2TextBox catDescTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox catNameTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox catIDtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
    }
}