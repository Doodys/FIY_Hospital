using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeClassLibrary;

namespace FIY_Hospital
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        public void WelcomeScreen_Load(object sender, EventArgs e)
        {
            Show();
            Employee._Convert();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 InitializeData = new Form1();
            InitializeData.Show();
        }

        private void WelcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
