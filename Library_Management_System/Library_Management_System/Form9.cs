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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnSearch_Student_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM `ir_book` WHERE `Student_Enroll`='" + textEnrollment_No.Text + "' AND `Book_Return_Date`='NULL'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            textEnrollment_No.Clear();
        }

        String bname;
        String bdate;
        int rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                rowid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            textBook_Name.Text=bname;
            textBook_Issue_Date.Text=bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE `ir_book` SET `Book_Return_Date`='" + dateTimePicker.Text + "' WHERE `Student_Enroll`='" + textEnrollment_No.Text + "' AND `ID`='"+rowid+"'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Succesful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Form9_Load(this,null);

        }

        private void textEnrollment_No_TextChanged(object sender, EventArgs e)
        {
            if (textEnrollment_No.Text=="")
            {
                panel3.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textEnrollment_No.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
