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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                panel2.Visible = false;
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_student`", con);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string en;
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    en = dataGridView1.Rows[e.RowIndex].Cells[0].ToString();
                }
                panel2.Visible = true;
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_student`", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                textStudent_Name.Text = ds.Tables[0].Rows[e.RowIndex][0].ToString();
                textEnrollment_No.Text = ds.Tables[0].Rows[e.RowIndex][1].ToString();
                textDepartment.Text = ds.Tables[0].Rows[e.RowIndex][2].ToString();
                textStudent_Semester.Text = ds.Tables[0].Rows[e.RowIndex][3].ToString();
                textStudent_Contact.Text = ds.Tables[0].Rows[e.RowIndex][4].ToString();
                textStudent_Email.Text = ds.Tables[0].Rows[e.RowIndex][5].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_student` WHERE `Student_Name` LIKE'" + textBox1.Text + "%' OR `Enrollment_No` LIKE'" + textBox1.Text + "%' OR `Department` LIKE'" + textBox1.Text + "%' OR `Student_Semester` LIKE'" + textBox1.Text + "%'OR `Student_Contact` LIKE'" + textBox1.Text + "%'OR `Student_Email` LIKE'" + textBox1.Text + "%'", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
                con.Open();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `add_student`", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be UPDATED. Confirm ?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String sname = textStudent_Name.Text;
                    String senrollment = textEnrollment_No.Text;
                    String department = textDepartment.Text;
                    String ssemester = textStudent_Semester.Text;
                    String scontact = textStudent_Contact.Text;
                    String semail = textStudent_Email.Text;

                    using (MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system"))
                    {
                        con.Open();

                        MySqlCommand command = new MySqlCommand("UPDATE `add_student` SET `Student_Name` = @sname, `Department` = @department, `Student_Semester` = @ssemester, `Student_Contact` = @scontact, `Student_Email` = @semail WHERE `Enrollment_No` = @senrollment", con);

                        command.Parameters.AddWithValue("@sname", sname);
                        command.Parameters.AddWithValue("@senrollment", senrollment);
                        command.Parameters.AddWithValue("@department", department);
                        command.Parameters.AddWithValue("@ssemester", ssemester);
                        command.Parameters.AddWithValue("@scontact", scontact);
                        command.Parameters.AddWithValue("@semail", semail);

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
                    String enrollment = textEnrollment_No.Text;

                    using (MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system"))
                    {
                        con.Open();

                        MySqlCommand command = new MySqlCommand("DELETE FROM `add_student` WHERE `Enrollment_No` = @enrollment", con);

                        command.Parameters.AddWithValue("@enrollment", enrollment);

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
