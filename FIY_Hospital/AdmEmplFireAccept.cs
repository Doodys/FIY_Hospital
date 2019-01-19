using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Space;

namespace FIY_Hospital
{
    public partial class AdmEmplFireAccept : Form
    {
        public AdmEmplFireAccept()
        {
            InitializeComponent();
        }

        private void AdmEmplFireAccept_Load(object sender, EventArgs e)
        {

        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee.EmployeesData.RemoveAt(AdmEmplFire.SelectedId - 1);
            AdmEmplFire InitializeData = new AdmEmplFire();
            this.Hide();
            InitializeData.Hide();
        }
    }
}
