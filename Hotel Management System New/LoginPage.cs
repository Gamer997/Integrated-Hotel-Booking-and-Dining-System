using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System_New
{
    
    public partial class LoginPage : Form
    {
        public static class ControlID
        {
            public static string TextData { get; set; }
        }
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30");


        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignUPForm sform = new SignUPForm();
            sform.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(login_page_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_username.Text=="" || login_password.Text=="" || login_gmail.Text=="")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State!=ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
/*                      String selectData = " SELECT * FROM WHERE username = @username AND passowrd = @pass";*/
                        String selectData = "SELECT * FROM admin WHERE username = @username AND passowrd = @pass AND email = @gmail";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            cmd.Parameters.AddWithValue("@gmail", login_gmail.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfull "  , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 mainform = new Form1(login_username.Text, login_gmail.Text);
                                mainform.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect UserName/Password" , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                    catch (Exception ex){
                        MessageBox.Show("Error Connecting: "+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connect.Close(); }
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
