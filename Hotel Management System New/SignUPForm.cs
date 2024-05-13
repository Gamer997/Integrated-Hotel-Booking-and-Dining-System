using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Hotel_Management_System_New
{
    public partial class SignUPForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUPForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (signup_email.Text=="" || signup_username.Text=="" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    String checkUserName = "SELECT * FROM admin WHERE username = '" + signup_username.Text.Trim()+ "'";

                    using(SqlCommand checkUser =  new SqlCommand(checkUserName,connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        if (table.Rows.Count >=1) {
                            MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string Insertdata = "INSERT INTO admin (email, username, passowrd, date_created)  " +
                                "VALUES(@email,@username,@pass,@date)";
                            DateTime date = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(Insertdata, connect))
                            {
                                cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);
                                
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Sucessfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginPage loginform = new LoginPage();
                                loginform.Show();
                                this.Hide();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally { 
                connect.Close();
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }

        private void SignUPForm_Load(object sender, EventArgs e)
        {

        }
    }
}
