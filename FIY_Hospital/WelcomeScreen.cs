using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
            try
            {
                Employee._Convert();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("There is no Employees.csv file inf /bin/Debug/ folder!\n" +
                    "Create file with proper headers:\n" +
                    "USERNAME, PASSWORD, ROLE, NAME, SURNAME, PESEL, PWD and SPECIALIZATION\n" +
                    "and values separated with comma.");
                Application.Exit();
            }
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
