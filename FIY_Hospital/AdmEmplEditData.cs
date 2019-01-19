using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Space;

namespace FIY_Hospital
{
    public partial class AdmEmplEditData : Form
    {
        public AdmEmplEditData()
        {
            InitializeComponent();
        }

        private void AdmEmplEditData_Load(object sender, EventArgs e)
        {
            if (!Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Role.Equals("Doctor"))
            {
                textBox7.Visible = false;
                comboBox2.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }

            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Doctor");
            comboBox1.Items.Add("Nurse");

            comboBox2.Items.Add("Urologist");
            comboBox2.Items.Add("Neurologist");
            comboBox2.Items.Add("Cardiologist");
            comboBox2.Items.Add("Laryngologist");

            textBox1.Text = Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Username;
            textBox2.Text = Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Password;
            textBox3.Text = Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Name;
            textBox4.Text = Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Surname;
            textBox5.Text = Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Pesel;

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Role); ;

            if (comboBox1.SelectedIndex.Equals(1))
            {
                textBox7.Visible = true;
                comboBox2.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox7.Text = Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].PWD;
                comboBox2.SelectedIndex = comboBox2.Items.IndexOf(Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Specialization);
            }
        }

        private void AdmEmplEditData_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AdmEditEmployee InitializeData = new AdmEditEmployee();
            InitializeData.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedIndex.Equals(1))
            {
                textBox7.Text = "";
                comboBox2.Text = "";
                textBox7.Visible = false;
                comboBox2.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
            else
            {
                textBox7.Visible = true;
                comboBox2.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox7.Text = Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].PWD;
                comboBox2.SelectedIndex = comboBox2.Items.IndexOf(Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Specialization);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(" ") ||
                textBox2.Text.Contains(" "))
            {
                MessageBox.Show("You can not use spaces in USERNAME or PASSWORD!");
            }
            else if (!Regex.IsMatch(textBox3.Text, @"^[\p{L}\p{M}' ]+$") ||
                !Regex.IsMatch(textBox4.Text, @"^[\p{L}\p{M}' ]+$") ||
                textBox3.Text.Contains(" ") ||
                textBox4.Text.Contains(" ") ||
                Validator.UpperOrLower(textBox3.Text) == false ||
                Validator.UpperOrLower(textBox4.Text) == false)
            {
                MessageBox.Show("Wrong NAME or SURNAME format!");
            }
            else if (Validator.ValidatePesel(Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Pesel) == false)
            {
                MessageBox.Show("Wrong PESEL!");
            }
            else if (comboBox2.Visible == true) { if (!textBox7.Text.Length.Equals(7)) { MessageBox.Show("Wrong PWD format!"); } }
            else
            {
                Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Username = textBox1.Text;
                Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Password = textBox2.Text;
                Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Name = textBox3.Text;
                Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Surname = textBox4.Text;
                Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Pesel = textBox5.Text;
                Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Role = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                if (comboBox2.Visible == true)
                {
                    Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].PWD = textBox7.Text;
                    Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Username = comboBox2.Items[comboBox2.SelectedIndex].ToString();
                }
            }
        }
    }
}
