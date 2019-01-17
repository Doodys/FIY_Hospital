using Employees_Space;
using System;
using System.Windows.Forms;

namespace FIY_Hospital
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesList InitializeData = new EmployeesList();
            InitializeData.Show();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
