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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "Database1.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        private void populate()
        {
            con.Open();
            //put the sql query in adapter to form it
            string query = "select prodName,prodPrice from productTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //create a dataSet and fill it from sda
            var ds = new DataSet();
            sda.Fill(ds);

            //fill the category data grid view
            prod1DGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void populateBills()
        {
            con.Open();
            //put the sql query in adapter to form it
            string query = "select * from billTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //create a dataSet and fill it from sda
            var ds = new DataSet();
            sda.Fill(ds);

            //fill the category data grid view
            BillsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void fillCombo()
        {
            //this method will bind the combobox with the database
            con.Open();
            SqlCommand cmd = new SqlCommand("select catName from categoryTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catName", typeof(string));
            dt.Load(rdr);
            searchCB.ValueMember = "catName";
            searchCB.DataSource = dt;
            con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            populate();
            populateBills();
            sellerNameLbl.Text = Form1.sellerName;
        }

        private void prod1DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodName.Text = prod1DGV.SelectedRows[0].Cells[0].Value.ToString();
            prodPrice.Text = prod1DGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dateLbl.Text = DateTime.Today.Day.ToString() + " / " + DateTime.Today.Month.ToString() + " / " + DateTime.Today.Year.ToString();


        }

        private void catCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        double grdTotal = 0;
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (prodName.Text == "" || prodQty.Text == "" || prodPrice.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                //create a Row
                DataGridViewRow newRow = new DataGridViewRow();

                double totale = Convert.ToDouble(prodPrice.Text) * Convert.ToInt32(prodQty.Text);
                //Create Cells
                newRow.CreateCells(orderDGV);
                newRow.Cells[0].Value = ++n;
                newRow.Cells[1].Value = prodName.Text;
                newRow.Cells[2].Value = prodPrice.Text;
                newRow.Cells[3].Value = prodQty.Text;
                newRow.Cells[4].Value = totale;

                //add newRow to DGV
                orderDGV.Rows.Add(newRow);

                //TOTAL
                grdTotal = grdTotal + totale;
                amtLbl.Text = "" + grdTotal;

            }
            
            
        }

        private void orderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (billLbl.Text == "")
            {
                MessageBox.Show("Missing Bill ID");
            }
            else
            {
                try
                {
                    con.Open();

                    //Parametrized Query
                    using (var cmd = new SqlCommand(@"INSERT INTO billTbl VALUES (@ID, @Name, @Date, @Variable)", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", billID.Text);
                        cmd.Parameters.AddWithValue("@Name", sellerNameLbl.Text);
                        cmd.Parameters.AddWithValue("@Date", dateLbl.Text);
                        cmd.Parameters.AddWithValue("@Variable", Convert.ToDouble(amtLbl.Text));
                        cmd.ExecuteNonQuery();
                    }

                    //normal query
                    /*String query = "insert into billTbl values (" + billID.Text + ",'" + sellerNameLbl.Text + "','" + dateLbl.Text + "'," + amtLbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();*/

                    MessageBox.Show("Order added successfully");
                    con.Close();
                    populateBills();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILY SUPERMARKET" , new Font("Century Gothic" , 25 , FontStyle.Bold) , Brushes.Red , new Point(230));
            e.Graphics.DrawString("Bill ID: " +BillsDGV.SelectedRows[0].Cells[0].Value.ToString() , new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100 , 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(280 , 230));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select prodName,prodQty from productTbl where prodCat='" + searchCB.SelectedValue + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);

            prod1DGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                    con.Open();
                    string query = "delete from billTbl where billId=" + BillsDGV.SelectedRows[0].Cells[0].Value.ToString() + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Deleted Successfully !");
                    con.Close();
                    populateBills();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void amtLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
