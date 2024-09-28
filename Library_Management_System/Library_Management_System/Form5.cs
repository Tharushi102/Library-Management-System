using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                panel2.Visible = false;
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_book`", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string bn;
                    bn = dataGridView1.Rows[e.RowIndex].Cells[0].ToString();
                    //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                panel2.Visible = true;
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_book`", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


                textBook_Name.Text = ds.Tables[0].Rows[e.RowIndex][1].ToString();
                textBook_Author_Name.Text = ds.Tables[0].Rows[e.RowIndex][2].ToString();
                textBook_Publication.Text = ds.Tables[0].Rows[e.RowIndex][3].ToString();
                textBook_Purchase_Date.Text = ds.Tables[0].Rows[e.RowIndex][4].ToString();
                textBook_Price.Text = ds.Tables[0].Rows[e.RowIndex][5].ToString();
                textBook_Quantity.Text = ds.Tables[0].Rows[e.RowIndex][6].ToString();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBName_TextChanged(object sender, EventArgs e)
        {
            if (textBName.Text!="")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_book` WHERE `Book_Name` LIKE'" + textBName.Text + "%' OR `Book_Author_Name` LIKE'" + textBName.Text + "%' OR `Book_Publication` LIKE'" + textBName.Text + "%' OR `Book_Purchase_Date` LIKE'" + textBName.Text + "%'OR `Book_Price` LIKE'" + textBName.Text + "%'OR `Book_Quantity` LIKE'" + textBName.Text + "%'", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_book`", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBName.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be UPDATED. Confirm ?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String bname = textBook_Name.Text;
                    String bauthor = textBook_Author_Name.Text;
                    String bpublication = textBook_Publication.Text;
                    String bpdate = textBook_Purchase_Date.Text;
                    String bprice = textBook_Price.Text;
                    String bquantity = textBook_Quantity.Text;

                    using (MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system"))
                    {
                        con.Open();

                        MySqlCommand command = new MySqlCommand("UPDATE `add_book` SET `Book_Author_Name` = @author, `Book_Publication` = @publication, `Book_Purchase_Date` = @pdate, `Book_Price` = @price, `Book_Quantity` = @quantity WHERE `Book_Name` = @name", con);

                        command.Parameters.AddWithValue("@name", bname);
                        command.Parameters.AddWithValue("@author", bauthor);
                        command.Parameters.AddWithValue("@publication", bpublication);
                        command.Parameters.AddWithValue("@pdate", bpdate);
                        command.Parameters.AddWithValue("@price", bprice);
                        command.Parameters.AddWithValue("@quantity", bquantity);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be DELETED. Confirm ?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String bname = textBook_Name.Text;

                    using (MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system"))
                    {
                        con.Open();

                        MySqlCommand command = new MySqlCommand("DELETE FROM `add_book` WHERE `Book_Name` = @name", con);

                        command.Parameters.AddWithValue("@name", bname);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}