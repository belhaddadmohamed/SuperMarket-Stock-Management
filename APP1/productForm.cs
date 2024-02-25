using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APP1
{
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
        }

        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "Database1.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillCombos()
        {
            //this method will bind the combobox with the database
            con.Open();
            SqlCommand cmd = new SqlCommand("select catName from categoryTbl" , con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catName", typeof(string));
            dt.Load(rdr);
            catCB.ValueMember = "catName";
            catCB.DataSource = dt;
            searchCB.ValueMember = "catName";
            searchCB.DataSource = dt;
            con.Close();
        }

        private void populate()
        {
            con.Open();
            //put the sql query in adapter to form it
            string query = "select * from productTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //create a dataSet and fill it from sda
            var ds = new DataSet();
            sda.Fill(ds);

            //fill the category data grid view
            prodDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void productForm_Load(object sender, EventArgs e)
        {
            fillCombos();
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodID.Text = prodDGV.SelectedRows[0].Cells[0].Value.ToString();
            prodName.Text = prodDGV.SelectedRows[0].Cells[1].Value.ToString();
            prodQty.Text = prodDGV.SelectedRows[0].Cells[2].Value.ToString();
            prodPrice.Text = prodDGV.SelectedRows[0].Cells[3].Value.ToString();
            catCB.SelectedValue = prodDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoryForm catF = new categoryForm();
            catF.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "insert into productTbl values ('" + prodID.Text + "','" + prodName.Text + "'," + prodQty.Text + "," + prodPrice.Text + ",'" + catCB.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                con.Close();
                populate();

                //reset the values of inputs
                prodID.Text = "";
                prodName.Text = "";
                prodQty.Text = "";
                prodPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodID.Text == "" || prodName.Text == "" || prodQty.Text == "" || prodPrice.Text == "")
                {
                    MessageBox.Show("Missing Information !");
                }
                else
                {
                    con.Open();
                    string query = "update productTbl set prodName='" + prodName.Text + "',prodQty='" + prodQty.Text + "',prodPrice='" + prodPrice.Text + "',prodcat='" + catCB.SelectedValue.ToString() + "' where prodId=" + prodID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfully updated !");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                if (prodID.Text == "")
                {
                    MessageBox.Show("Select the product to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from productTbl where prodId=" + prodID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully !");
                    con.Close();
                    populate();

                    //reset the values of inputs
                    prodID.Text = "";
                    prodName.Text = "";
                    prodQty.Text = "";
                    prodPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellerForm sellerF = new sellerForm();
            sellerF.Show();
            this.Hide();
        }

        private void searchCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from productTbl where prodCat='" + searchCB.SelectedValue + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);

            prodDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void catCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
