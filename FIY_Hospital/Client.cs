using Employees_Space;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FIY_Hospital
{
    public partial class Client : Form
    {
        public static string Role;
        public static string Specialization;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            if (!LoginScreen.Rola.Equals("Admin")) { menuStrip.Items[3].Available = false; }
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
            SaveToCsv.ExportCsv(Employee.EmployeesData);
            Process.GetCurrentProcess().Kill(); //brutal, but with no System.Colletions exception, which seems unable to fix.
        }

        private void cardiologistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Doctor";
            Specialization = "Cardiologist";
            this.Hide();
            EmployeesListSpec InitializeData = new EmployeesListSpec();
            InitializeData.Show();
        }

        private void urologistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Doctor";
            Specialization = "Urologist";
            this.Hide();
            EmployeesListSpec InitializeData = new EmployeesListSpec();
            InitializeData.Show();
        }

        private void neurologistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Doctor";
            Specialization = "Neurologist";
            this.Hide();
            EmployeesListSpec InitializeData = new EmployeesListSpec();
            InitializeData.Show();
        }

        private void laryngologistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Doctor";
            Specialization = "Laryngologist";
            this.Hide();
            EmployeesListSpec InitializeData = new EmployeesListSpec();
            InitializeData.Show();
        }

        private void nurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role = "Nurse";
            this.Hide();
            EmployeesList InitializeData = new EmployeesList();
            InitializeData.Show();
        }

        private void editEmployeeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmEditEmployee InitializeData = new AdmEditEmployee();
            InitializeData.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmEmplAddData InitializeData = new AdmEmplAddData();
            InitializeData.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmEmplFire InitializeData = new AdmEmplFire();
            InitializeData.Show();
        }
    }
}
