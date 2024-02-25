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
    public partial class sellerForm : Form
    {
        public sellerForm()
        {
            InitializeComponent();
        }

        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "Database1.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sellerID.Text = sellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            sellerName.Text = sellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            sellerAge.Text = sellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            sellerPhone.Text = sellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            sellerPass.Text = sellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void populate()
        {
            con.Open();
            //put the sql query in adapter to form it
            string query = "select * from sellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //create a dataSet and fill it from sda
            var ds = new DataSet();
            sda.Fill(ds);

            //fill the category data grid view
            sellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "insert into SellerTbl values ('" + sellerID.Text + "','" + sellerName.Text + "'," + sellerAge.Text + "," + sellerPhone.Text + ",'" + sellerPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added successfully");
                con.Close();
                populate();

                //reset the values of inputs
                sellerID.Text = "";
                sellerName.Text = "";
                sellerAge.Text = "";
                sellerPhone.Text = "";
                sellerPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerID.Text == "" || sellerName.Text == "" || sellerAge.Text == "" || sellerPhone.Text == "" || sellerPass.Text == "")
                {
                    MessageBox.Show("Missing Information !");
                }
                else
                {
                    con.Open();
                    string query = "update SellerTbl set sellerName='" + sellerName.Text + "',sellerAge='" + sellerAge.Text + "',sellerPhone='" + sellerPhone.Text + "',sellerPass='" + sellerPass.Text + "' where sellerID=" + sellerID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller successfully updated !");
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
                if (sellerID.Text == "")
                {
                    MessageBox.Show("Select the seller to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from sellerTbl where sellerID=" + sellerID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully !");
                    con.Close();
                    populate();

                    //reset the values of inputs
                    sellerID.Text = "";
                    sellerName.Text = "";
                    sellerAge.Text = "";
                    sellerPhone.Text = "";
                    sellerPass.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productForm prodF = new productForm();
            prodF.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoryForm catF = new categoryForm();
            catF.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
