using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_New
{
    public partial class FoodForm : Form
    {
        private string username;
        private string email;
        public FoodForm(string name, string email_)
        {
            InitializeComponent();
            this.username = name;
            this.email = email_;
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FoodFormItems foodItemsForm = new FoodFormItems(username, email);

            // Show the FoodFormItems
            foodItemsForm.Show();
        }
    }
}
