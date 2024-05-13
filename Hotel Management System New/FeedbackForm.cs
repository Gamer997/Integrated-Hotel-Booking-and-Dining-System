using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_New
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string formUrl = "https://docs.google.com/forms/d/1zwZyEpitchO1HO7ffnaGJtOhJ5U7KPOr9OfM4W0gmYg/edit";
            Process.Start(formUrl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string formUrl = "https://docs.google.com/forms/d/e/1FAIpQLSeGWvwn5qpXLt8fahkhHLZMwjymmJuKkBPVRmxV9YAfhMv2vQ/viewform";
            Process.Start(formUrl);
        }


        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }
    }
}
