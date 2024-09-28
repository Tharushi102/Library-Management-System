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
    public partial class Form1 : Form
        
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUserName_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textUserName.Text == "User Name")
            {
                textUserName.Clear();
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textPassword.Text == "Password") 
            {
                textPassword.Clear();
                textPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;port=3306;username=root;password=;database=library_management_system";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string username = textUserName.Text;
                    string password = textPassword.Text;

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `log_in` WHERE `User_Name`= @usn AND `Password`= @pass", con);

                    command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    // Check if the user exists
                    if (table.Rows.Count > 0)
                    {
                        Form3 main = new Form3();
                        this.Hide();
                        main.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 registerform = new Form2();
                this.Hide();
                registerform.ShowDialog();
                this.Show(); // This line executes after registerform is closed
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
