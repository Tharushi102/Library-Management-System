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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBook_Name.Text != "" && textBook_Author_Name.Text != "" && textBook_Publication.Text != "" && textBook_Price.Text != "" && textBook_Quantity.Text!="")
                {
                    MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_management_system");

                    MySqlCommand command2 = new MySqlCommand("INSERT INTO `add_book`(`Book_Name`, `Book_Author_Name`, `Book_Publication`, `Book_Purchase_Date`, `Book_Price`, `Book_Quantity`) VALUES (@bn,@ban,@bpu,@bpd,@bpr,@bq)", con);
                    //open the connection
                    con.Open();

                    command2.Parameters.Add("@bn", MySqlDbType.VarChar).Value = textBook_Name.Text;
                    command2.Parameters.Add("@ban", MySqlDbType.VarChar).Value = textBook_Author_Name.Text;
                    command2.Parameters.Add("@bpu", MySqlDbType.VarChar).Value = textBook_Publication.Text;
                    command2.Parameters.Add("@bpd", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command2.Parameters.Add("@bpr", MySqlDbType.VarChar).Value = textBook_Price.Text;
                    command2.Parameters.Add("@bq", MySqlDbType.VarChar).Value = textBook_Quantity.Text;

                    if (command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Saved");
                        this.Controls.Clear();
                        InitializeComponent();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved");
                        this.Controls.Clear();
                        InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your unsaved DATA", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
