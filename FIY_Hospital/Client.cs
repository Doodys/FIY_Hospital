using Employees_Space;
using System;
using System.Windows.Forms;

namespace FIY_Hospital
{
    public partial class Client : Form
    {
        public static string Role; 

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Doctor";
            this.Hide();
            EmployeesList InitializeData = new EmployeesList();
            InitializeData.Show();
        }

        private void nursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Nurse";
            this.Hide();
            EmployeesList InitializeData = new EmployeesList();
            InitializeData.Show();
        }

        private void administratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Admin";
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
