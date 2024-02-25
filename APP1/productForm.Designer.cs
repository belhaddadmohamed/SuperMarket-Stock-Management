namespace APP1
{
    partial class productForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.prodDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.catCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prodPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(717, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(12, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Categories";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.searchCB);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.prodDGV);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.catCB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.prodPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prodQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prodID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(125, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 532);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // searchCB
            // 
            this.searchCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchCB.ForeColor = System.Drawing.Color.DarkBlue;
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.searchCB.Location = new System.Drawing.Point(471, 92);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(189, 27);
            this.searchCB.TabIndex = 19;
            this.searchCB.Text = "Select Category";
            this.searchCB.SelectedIndexChanged += new System.EventHandler(this.searchCB_SelectedIndexChanged);
            this.searchCB.SelectionChangeCommitted += new System.EventHandler(this.searchCB_SelectionChangeCommitted);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button9.Location = new System.Drawing.Point(682, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 27);
            this.button9.TabIndex = 18;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // prodDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.prodDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.prodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodDGV.BackgroundColor = System.Drawing.Color.White;
            this.prodDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.prodDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.prodDGV.EnableHeadersVisualStyles = false;
            this.prodDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.prodDGV.Location = new System.Drawing.Point(338, 135);
            this.prodDGV.Name = "prodDGV";
            this.prodDGV.RowHeadersVisible = false;
            this.prodDGV.RowTemplate.Height = 30;
            this.prodDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDGV.Size = new System.Drawing.Size(538, 372);
            this.prodDGV.TabIndex = 17;
            this.prodDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.prodDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.prodDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prodDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.prodDGV.ThemeStyle.ReadOnly = false;
            this.prodDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.prodDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prodDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.prodDGV.ThemeStyle.RowsStyle.Height = 30;
            this.prodDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.prodDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.prodDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button8.Location = new System.Drawing.Point(201, 432);
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
            this.button7.Location = new System.Drawing.Point(110, 432);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 37);
            this.button7.TabIndex = 15;
            this.button7.Text = "EDIT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddBtn.Location = new System.Drawing.Point(22, 432);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(82, 37);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // catCB
            // 
            this.catCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.catCB.ForeColor = System.Drawing.Color.DarkBlue;
            this.catCB.FormattingEnabled = true;
            this.catCB.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.catCB.Location = new System.Drawing.Point(126, 339);
            this.catCB.Name = "catCB";
            this.catCB.Size = new System.Drawing.Size(173, 27);
            this.catCB.TabIndex = 14;
            this.catCB.Text = "Select Category";
            this.catCB.SelectedIndexChanged += new System.EventHandler(this.catCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "CATEGORY";
            // 
            // prodPrice
            // 
            this.prodPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodPrice.DefaultText = "";
            this.prodPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodPrice.Location = new System.Drawing.Point(126, 287);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.PasswordChar = '\0';
            this.prodPrice.PlaceholderText = "";
            this.prodPrice.SelectedText = "";
            this.prodPrice.Size = new System.Drawing.Size(173, 26);
            this.prodPrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRICE";
            // 
            // prodQty
            // 
            this.prodQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodQty.DefaultText = "";
            this.prodQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodQty.Location = new System.Drawing.Point(126, 229);
            this.prodQty.Name = "prodQty";
            this.prodQty.PasswordChar = '\0';
            this.prodQty.PlaceholderText = "";
            this.prodQty.SelectedText = "";
            this.prodQty.Size = new System.Drawing.Size(173, 26);
            this.prodQty.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUANTUTY";
            // 
            // prodName
            // 
            this.prodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodName.DefaultText = "";
            this.prodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodName.Location = new System.Drawing.Point(126, 170);
            this.prodName.Name = "prodName";
            this.prodName.PasswordChar = '\0';
            this.prodName.PlaceholderText = "";
            this.prodName.SelectedText = "";
            this.prodName.Size = new System.Drawing.Size(173, 26);
            this.prodName.TabIndex = 8;
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
            // prodID
            // 
            this.prodID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodID.DefaultText = "";
            this.prodID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodID.Location = new System.Drawing.Point(126, 110);
            this.prodID.Name = "prodID";
            this.prodID.PasswordChar = '\0';
            this.prodID.PlaceholderText = "";
            this.prodID.SelectedText = "";
            this.prodID.Size = new System.Drawing.Size(173, 26);
            this.prodID.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(247, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(978, -7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(27, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1013, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productForm";
            this.Load += new System.EventHandler(this.productForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox prodPrice;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox prodQty;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox prodName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox prodID;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox catCB;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.Button button9;
        private Guna.UI2.WinForms.Guna2DataGridView prodDGV;
        private System.Windows.Forms.Label label7;
    }
}