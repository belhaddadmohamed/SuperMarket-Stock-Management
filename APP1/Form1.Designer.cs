namespace APP1
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
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.uNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.passTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.loginBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-109, -20);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(284, 304);
            this.guna2CircleButton1.TabIndex = 0;
            // 
            // uNameTb
            // 
            this.uNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uNameTb.DefaultText = "";
            this.uNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.uNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.uNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uNameTb.Location = new System.Drawing.Point(286, 126);
            this.uNameTb.Name = "uNameTb";
            this.uNameTb.PasswordChar = '\0';
            this.uNameTb.PlaceholderText = "";
            this.uNameTb.SelectedText = "";
            this.uNameTb.Size = new System.Drawing.Size(189, 26);
            this.uNameTb.TabIndex = 1;
            this.uNameTb.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // passTb
            // 
            this.passTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTb.DefaultText = "";
            this.passTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTb.Location = new System.Drawing.Point(286, 169);
            this.passTb.MaxLength = 14;
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.PlaceholderText = "";
            this.passTb.SelectedText = "";
            this.passTb.Size = new System.Drawing.Size(189, 26);
            this.passTb.TabIndex = 2;
            this.passTb.TextChanged += new System.EventHandler(this.passTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(337, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(190, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(187, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            // 
            // roleCB
            // 
            this.roleCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.roleCB.ForeColor = System.Drawing.Color.DarkBlue;
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.roleCB.Location = new System.Drawing.Point(286, 70);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(189, 27);
            this.roleCB.TabIndex = 6;
            this.roleCB.Text = "Select Role";
            // 
            // loginBTN
            // 
            this.loginBTN.ActiveBorderThickness = 1;
            this.loginBTN.ActiveCornerRadius = 20;
            this.loginBTN.ActiveFillColor = System.Drawing.Color.MintCream;
            this.loginBTN.ActiveForecolor = System.Drawing.Color.DarkSlateGray;
            this.loginBTN.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.loginBTN.BackColor = System.Drawing.SystemColors.Control;
            this.loginBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBTN.BackgroundImage")));
            this.loginBTN.ButtonText = "LOGIN";
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.loginBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBTN.IdleBorderThickness = 1;
            this.loginBTN.IdleCornerRadius = 20;
            this.loginBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBTN.IdleForecolor = System.Drawing.Color.White;
            this.loginBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBTN.Location = new System.Drawing.Point(329, 207);
            this.loginBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(98, 37);
            this.loginBTN.TabIndex = 8;
            this.loginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "SUPPERMARKET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "WELCOME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "APPLICATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(494, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(351, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "CLEAR";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 276);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.roleCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.uNameTb);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox uNameTb;
        private Guna.UI2.WinForms.Guna2TextBox passTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleCB;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

