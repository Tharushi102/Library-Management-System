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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void btnSave_Info_Click(object sender, EventArgs e)
        {
            try
            {
                if (textStudent_Name.Text != "" && textEnrollment_No.Text != "" && textDepartment.Text != "" && textStudent_Semester.Text != "" && textStudent_Contact.Text != "" && textStudent_Email.Text!="")
                {
                    MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");

                    MySqlCommand command = new MySqlCommand("INSERT INTO `add_student`(`Student_Name`, `Enrollment_No`, `Department`, `Student_Semester`, `Student_Contact`, `Student_Email`) VALUES (@sn,@en,@d,@ss,@sc,@se)", con);
                    //open the connection
                    con.Open();

                    command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = textStudent_Name.Text;
                    command.Parameters.Add("@en", MySqlDbType.VarChar).Value = textEnrollment_No.Text;
                    command.Parameters.Add("@d", MySqlDbType.VarChar).Value = textDepartment.Text;
                    command.Parameters.Add("@ss", MySqlDbType.VarChar).Value = textStudent_Semester.Text;
                    command.Parameters.Add("@sc", MySqlDbType.VarChar).Value = textStudent_Contact.Text;
                    command.Parameters.Add("@se", MySqlDbType.VarChar).Value = textStudent_Email.Text;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Saved");
                        
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved");
                        
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Empty Fields are not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
