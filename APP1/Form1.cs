using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string sellerName = "";

        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "Database1.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {

            if (uNameTb.Text == "" || passTb.Text == "")
            {
                MessageBox.Show("Enter the username and the password !");
            }
            else
            {
                if (roleCB.SelectedIndex > -1)
                {
                    if (roleCB.SelectedItem.ToString() == "ADMIN")
                    {
                        if (uNameTb.Text == "admin" && passTb.Text == "admin")
                        {
                            productForm prodF = new productForm();
                            prodF.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("if you are the Admin Enter the correct username and password !!");
                        }
                    }
                    else
                    {
                        con.Open();
                        string query = "select count(8) from sellerTbl where sellerName='" + uNameTb .Text + "' and sellerPass='" + passTb.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query , con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            //OPEN Seller Form
                            sellerName = uNameTb.Text.ToString();
                            this.Hide();
                            SellingForm sellerForm = new SellingForm();
                            sellerForm.Show();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password");
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("choose a role !!");
                }

            }
        }

        private void passTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            uNameTb.Text = "";
            passTb.Text = "";
        }
    }
}
