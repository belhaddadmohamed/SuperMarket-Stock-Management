using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APP1
{
    public partial class categoryForm : Form
    {

        public categoryForm()
        {
            InitializeComponent();
        }


        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "Database1.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "insert into CategoryTbl values ('" + catIDtb.Text + "','" + catNameTb.Text + "','" + catDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("category added successfully");
                con.Close();
                populate();

                //reset
                catIDtb.Text = "";
                catNameTb.Text = "";
                catDescTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void populate()
        {
            con.Open();
            //put the sql query in adapter to form it
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query , con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //create a dataSet and fill it from sda
            var ds = new DataSet();
            sda.Fill(ds);

            //fill the category data grid view
            catDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void categoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catIDtb.Text = catDGV.SelectedRows[0].Cells[0].Value.ToString();
            catNameTb.Text = catDGV.SelectedRows[0].Cells[1].Value.ToString();
            catDescTb.Text = catDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (catIDtb.Text == "")
                {
                    MessageBox.Show("Select the category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from CategoryTbl where catId=" + catIDtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query , con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully !");
                    con.Close();
                    populate();

                    //reset
                    catIDtb.Text = "";
                    catNameTb.Text = "";
                    catDescTb.Text = "";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (catIDtb.Text == "" || catNameTb.Text == "" || catDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information !");
                }
                else
                {
                    con.Open();
                    string query = "update CategoryTbl set catName='" + catNameTb.Text + "',catDesc='" + catDescTb.Text + "' where catId=" + catIDtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully updated !");
                    con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productForm prodF = new productForm();
            prodF.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellerForm selF = new sellerForm();
            selF.Show();
            this.Hide();        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
