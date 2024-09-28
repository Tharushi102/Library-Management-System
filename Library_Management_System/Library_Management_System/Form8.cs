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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd = new MySqlCommand("SELECT `Book_Name` FROM `add_book`", con);
                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        comboBoxBooks_Name.Items.Add(sdr.GetString(i));
                    }
                }
                sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int count;

        private void btnSearch_Student_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEnrollment_No.Text != "")
                {
                    String eid = textEnrollment_No.Text;
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = cmd.CommandText = "SELECT * FROM `add_student` WHERE`Enrollment_No`='" + eid + "'";
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);


                    

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        textStudent_Name.Text = DS.Tables[0].Rows[0][0].ToString();
                        textDepartment.Text = DS.Tables[0].Rows[0][2].ToString();
                        textStudent_Semester.Text = DS.Tables[0].Rows[0][3].ToString();
                        textStudent_Contact.Text = DS.Tables[0].Rows[0][4].ToString();
                        textStudent_Email.Text = DS.Tables[0].Rows[0][5].ToString();
                    }
                    else
                    {
                        textStudent_Name.Clear();
                        textDepartment.Clear();
                        textStudent_Semester.Clear();
                        textStudent_Contact.Clear();
                        textStudent_Email.Clear();
                        MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIssue_Book_Click(object sender, EventArgs e)
        {
            try
            {
                if (textStudent_Name.Text != "")
                {
                    MySqlConnection con2 = new MySqlConnection();
                    con2.ConnectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.Connection = con2;
                    //-------------------------------------------------------------------------------------------
                    // Code to Count how many book issued on this enrollment number

                    cmd2.CommandText = "SELECT COUNT(`Student_Enroll`) FROM `ir_book` WHERE `Student_Enroll`='" + textEnrollment_No.Text + "' AND `Book_Return_Date`= 'NULL'";
                    MySqlDataAdapter DA2 = new MySqlDataAdapter(cmd2);
                    DataSet DS2 = new DataSet();
                    DA2.Fill(DS2);

                    count = int.Parse(DS2.Tables[0].Rows[0][0].ToString());

                    //-------------------------------------------------------------------------------------------

                    if (comboBoxBooks_Name.SelectedIndex != -1 && count <= 2)
                    {
                        String sname = textStudent_Name.Text;
                        String sdep = textDepartment.Text;
                        String sem = textStudent_Semester.Text;
                        String contact = textStudent_Contact.Text;
                        String email = textStudent_Email.Text;
                        String bookname = comboBoxBooks_Name.Text;
                        String bookIssueDate = dateTimePicker.Text;
                        String bookReturnDate = "NULL";

                        String eid = textEnrollment_No.Text;

                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = con;

                        con.Open();
                        cmd.CommandText = "INSERT INTO `ir_book`(`Student_Enroll`, `Student_Name`, `Student_Department`, `Student_Semester`, `Student_Contact`, `Student_Email`, `Book_Name`, `Book_Issue_Date`,`Book_Return_Date`) VALUES ('" + eid + "','" + sname + "','" + sdep + "','" + sem + "','" + contact + "','" + email + "','" + bookname + "','" + bookIssueDate + "','" + bookReturnDate + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Book Issued .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Select Book. OR Maximum number of book has been ISSUED", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Enrollment No ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textEnrollment_No_TextChanged(object sender, EventArgs e)
        {
            if (textEnrollment_No.Text == "")
            {
                textStudent_Name.Clear();
                textDepartment.Clear();
                textStudent_Semester.Clear();
                textStudent_Contact.Clear();
                textStudent_Email.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textEnrollment_No.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
