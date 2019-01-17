using System;
using System.Windows.Forms;
using Employees_Space;

namespace FIY_Hospital
{
    public partial class EmployeesList : Form
    {
        public EmployeesList()
        {
            InitializeComponent();
        }

        private void EmloyeesList_Load(object sender, EventArgs e)
        {

        }

        private void EmloyeesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
