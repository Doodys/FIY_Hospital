using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Employees_Space;

namespace FIY_Hospital
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            Show();
            Employee._Convert();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen InitializeData = new LoginScreen();
            InitializeData.Show();
        }

        private void WelcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
