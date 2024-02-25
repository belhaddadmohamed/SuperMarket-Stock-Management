namespace APP1
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.amtLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sellerNameLbl = new System.Windows.Forms.Label();
            this.BillsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateLbl = new System.Windows.Forms.Label();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.prod1DGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.prodQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billID = new Guna.UI2.WinForms.Guna2TextBox();
            this.billLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod1DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.orderDGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.amtLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sellerNameLbl);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.dateLbl);
            this.panel1.Controls.Add(this.searchCB);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.prod1DGV);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.prodQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prodPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.billID);
            this.panel1.Controls.Add(this.billLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(120, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 532);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // orderDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.orderDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.orderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDGV.BackgroundColor = System.Drawing.Color.White;
            this.orderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.orderDGV.ColumnHeadersHeight = 25;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.orderDGV.EnableHeadersVisualStyles = false;
            this.orderDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.orderDGV.Location = new System.Drawing.Point(333, 60);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.RowHeadersVisible = false;
            this.orderDGV.RowTemplate.Height = 30;
            this.orderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDGV.Size = new System.Drawing.Size(535, 150);
            this.orderDGV.TabIndex = 27;
            this.orderDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.orderDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.orderDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.orderDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.orderDGV.ThemeStyle.ReadOnly = false;
            this.orderDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.orderDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.orderDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.orderDGV.ThemeStyle.RowsStyle.Height = 30;
            this.orderDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.orderDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.orderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDGV_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "prodID";
            this.Id.Name = "Id";
            // 
            // PName
            // 
            this.PName.HeaderText = "prodName";
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(534, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 28);
            this.label7.TabIndex = 26;
            this.label7.Text = "SELLS LIST";
            // 
            // amtLbl
            // 
            this.amtLbl.AutoSize = true;
            this.amtLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLbl.ForeColor = System.Drawing.Color.White;
            this.amtLbl.Location = new System.Drawing.Point(636, 213);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(38, 28);
            this.amtLbl.TabIndex = 25;
            this.amtLbl.Text = "RS";
            this.amtLbl.Click += new System.EventHandler(this.amtLbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(485, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount RS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(68, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "ADD Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellerNameLbl
            // 
            this.sellerNameLbl.AutoSize = true;
            this.sellerNameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNameLbl.ForeColor = System.Drawing.Color.White;
            this.sellerNameLbl.Location = new System.Drawing.Point(85, 26);
            this.sellerNameLbl.Name = "sellerNameLbl";
            this.sellerNameLbl.Size = new System.Drawing.Size(58, 23);
            this.sellerNameLbl.TabIndex = 22;
            this.sellerNameLbl.Text = "seller";
            // 
            // BillsDGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.BillsDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.BillsDGV.EnableHeadersVisualStyles = false;
            this.BillsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.BillsDGV.Location = new System.Drawing.Point(333, 293);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.RowTemplate.Height = 30;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(535, 173);
            this.BillsDGV.TabIndex = 21;
            this.BillsDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.BillsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.BillsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillsDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.BillsDGV.ThemeStyle.ReadOnly = false;
            this.BillsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.BillsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BillsDGV.ThemeStyle.RowsStyle.Height = 30;
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(761, 21);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(54, 23);
            this.dateLbl.TabIndex = 20;
            this.dateLbl.Text = "Date";
            // 
            // searchCB
            // 
            this.searchCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchCB.ForeColor = System.Drawing.Color.DarkBlue;
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.searchCB.Location = new System.Drawing.Point(25, 260);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(183, 27);
            this.searchCB.TabIndex = 19;
            this.searchCB.Text = "Select Category";
            this.searchCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.searchCB.SelectionChangeCommitted += new System.EventHandler(this.searchCB_SelectionChangeCommitted);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button9.Location = new System.Drawing.Point(214, 260);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 27);
            this.button9.TabIndex = 18;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // prod1DGV
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.prod1DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.prod1DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prod1DGV.BackgroundColor = System.Drawing.Color.White;
            this.prod1DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prod1DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prod1DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prod1DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.prod1DGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prod1DGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.prod1DGV.EnableHeadersVisualStyles = false;
            this.prod1DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.prod1DGV.Location = new System.Drawing.Point(25, 293);
            this.prod1DGV.Name = "prod1DGV";
            this.prod1DGV.RowHeadersVisible = false;
            this.prod1DGV.RowTemplate.Height = 30;
            this.prod1DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prod1DGV.Size = new System.Drawing.Size(274, 227);
            this.prod1DGV.TabIndex = 17;
            this.prod1DGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.prod1DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.prod1DGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prod1DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prod1DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prod1DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prod1DGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prod1DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.prod1DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.prod1DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prod1DGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prod1DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prod1DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prod1DGV.ThemeStyle.HeaderStyle.Height = 25;
            this.prod1DGV.ThemeStyle.ReadOnly = false;
            this.prod1DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.prod1DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prod1DGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prod1DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.prod1DGV.ThemeStyle.RowsStyle.Height = 30;
            this.prod1DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.prod1DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.prod1DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prod1DGV_CellContentClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button8.Location = new System.Drawing.Point(695, 483);
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
            this.button7.Location = new System.Drawing.Point(574, 483);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 37);
            this.button7.TabIndex = 15;
            this.button7.Text = "PRINT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddBtn.Location = new System.Drawing.Point(449, 483);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(82, 37);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.prodQty.Location = new System.Drawing.Point(126, 169);
            this.prodQty.Name = "prodQty";
            this.prodQty.PasswordChar = '\0';
            this.prodQty.PlaceholderText = "";
            this.prodQty.SelectedText = "";
            this.prodQty.Size = new System.Drawing.Size(173, 26);
            this.prodQty.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // prodPrice
            // 
            this.prodPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodPrice.DefaultText = "";
            this.prodPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodPrice.Enabled = false;
            this.prodPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodPrice.Location = new System.Drawing.Point(126, 137);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.PasswordChar = '\0';
            this.prodPrice.PlaceholderText = "";
            this.prodPrice.SelectedText = "";
            this.prodPrice.Size = new System.Drawing.Size(173, 26);
            this.prodPrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // prodName
            // 
            this.prodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodName.DefaultText = "";
            this.prodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodName.Enabled = false;
            this.prodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodName.Location = new System.Drawing.Point(126, 105);
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
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ProdName";
            // 
            // billID
            // 
            this.billID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billID.DefaultText = "";
            this.billID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.billID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.billID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.billID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billID.Location = new System.Drawing.Point(126, 73);
            this.billID.Name = "billID";
            this.billID.PasswordChar = '\0';
            this.billID.PlaceholderText = "";
            this.billID.SelectedText = "";
            this.billID.Size = new System.Drawing.Size(173, 26);
            this.billID.TabIndex = 6;
            // 
            // billLbl
            // 
            this.billLbl.AutoSize = true;
            this.billLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLbl.ForeColor = System.Drawing.Color.White;
            this.billLbl.Location = new System.Drawing.Point(21, 80);
            this.billLbl.Name = "billLbl";
            this.billLbl.Size = new System.Drawing.Size(49, 19);
            this.billLbl.TabIndex = 5;
            this.billLbl.Text = "Bill ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selling";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(22, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(971, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 38);
            this.button6.TabIndex = 28;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 574);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod1DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView BillsDGV;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.Button button9;
        private Guna.UI2.WinForms.Guna2DataGridView prod1DGV;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox prodQty;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox prodPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox prodName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox billID;
        private System.Windows.Forms.Label billLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sellerNameLbl;
        private System.Windows.Forms.Label amtLbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView orderDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
    }
}