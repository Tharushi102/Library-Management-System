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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textfirstName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textfirstName.Text == "First Name")
            {
                textfirstName.Clear();
                textfirstName.ForeColor = Color.Black;
            }
        }

        private void textlastName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textlastName.Text == "Last Name")
            {
                textlastName.Clear();
                textlastName.ForeColor = Color.Black;
            }
        }

        private void textUserName2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textUserName2.Text == "User Name")
            {
                textUserName2.Clear();
                textUserName2.ForeColor = Color.Black;
            }
        }

        private void textEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                textEmail.Clear();
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textPassword2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textPassword2.Text == "Password")
            {
                textPassword2.Clear();
                textPassword2.PasswordChar = '*';
                textPassword2.ForeColor = Color.Black;
            }
        }

        private void textConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textConfirmPassword.Text == "Confirm Password")
            {
                textConfirmPassword.Clear();
                textConfirmPassword.PasswordChar = '*';
                textConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void btncreatAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO `log_in`(`First_Name`, `Last_Name`, `Email`, `User_Name`, `Password`) VALUES (@fn, @ln, @email, @usn, @pass)";
                    MySqlCommand command = new MySqlCommand(query, con);

                    command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textfirstName.Text;
                    command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textlastName.Text;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textEmail.Text;
                    command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textUserName2.Text;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textPassword2.Text;

                    con.Open();

                    if (checkUserName())
                    {
                        MessageBox.Show("This User Name Already Exists");
                    }
                    else
                    {
                        if (textPassword2.Text != textConfirmPassword.Text)
                        {
                            MessageBox.Show("Your Password is incorrect");
                        }
                        else if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account created successfully");
                            Form3 main = new Form3();
                            this.Hide();
                            main.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the account");
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //check user name already exists
        public Boolean checkUserName()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");
            String username = textUserName2.Text;
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM `log_in` WHERE `User_Name`= @usn", con);

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            //check if the username already exit or not
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
