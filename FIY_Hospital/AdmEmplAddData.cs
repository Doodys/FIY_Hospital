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
    public partial class AdmEmplAddData : Form
    {
        public AdmEmplAddData()
        {
            InitializeComponent();
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
            }
        }

        private void AdmEmplAddData_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Doctor");
            comboBox1.Items.Add("Nurse");

            comboBox2.Items.Add("Urologist");
            comboBox2.Items.Add("Neurologist");
            comboBox2.Items.Add("Cardiologist");
            comboBox2.Items.Add("Laryngologist");

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Doctor");
            comboBox2.SelectedIndex = comboBox1.Items.IndexOf("Urologist");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checker = true;
            if (textBox1.Text.Contains(" ") ||
                textBox2.Text.Contains(" ") ||
                !textBox1.Text.Equals("") ||
                !textBox2.Text.Equals(""))
            {
                checker = false;
                MessageBox.Show("You can not use spaces in USERNAME or PASSWORD!");
            }
            else if (!Regex.IsMatch(textBox3.Text, @"^[\p{L}\p{M}' ]+$") ||
                !Regex.IsMatch(textBox4.Text, @"^[\p{L}\p{M}' ]+$") ||
                textBox3.Text.Contains(" ") ||
                textBox4.Text.Contains(" ") ||
                Validator.UpperOrLower(textBox3.Text) == false ||
                Validator.UpperOrLower(textBox4.Text) == false ||
                !textBox3.Text.Equals("") ||
                !textBox4.Text.Equals(""))
            {
                checker = false;
                MessageBox.Show("Wrong NAME or SURNAME format!");
            }
            else if (Validator.ValidatePesel(Employee.EmployeesData[AdmEditEmployee.SelectedId - 1].Pesel) == false)
            {
                checker = false;
                MessageBox.Show("Wrong PESEL!");
            }
            else if (comboBox2.Visible == true)
            {
                if (!textBox7.Text.Length.Equals(7))
                {
                    checker = false;
                    MessageBox.Show("Wrong PWD format!");
                }
            }

            if (checker == true) { UpdData(); }
        }

        private void UpdData()
        {
            if (comboBox2.Visible == true)
            {
                Employee.EmployeesData.Add(new Employee()
                {
                    Username = textBox1.Text,
                    Password = textBox2.Text,
                    Role = comboBox1.Items[comboBox1.SelectedIndex].ToString(),
                    Name = textBox3.Text,
                    Surname = textBox4.Text,
                    Pesel = textBox5.Text,
                    PWD = textBox7.Text,
                    Specialization = comboBox2.Items[comboBox2.SelectedIndex].ToString()
                });
            }
            else if (comboBox2.Visible == false)
            {
                Employee.EmployeesData.Add(new Employee()
                {
                    Username = textBox1.Text,
                    Password = textBox2.Text,
                    Role = comboBox1.Items[comboBox1.SelectedIndex].ToString(),
                    Name = textBox3.Text,
                    Surname = textBox4.Text,
                    Pesel = textBox5.Text,
                    PWD = "",
                    Specialization = ""
                });
            }

            MessageBox.Show("Employee " + textBox3.Text + " " + textBox4.Text + " added!");

            this.Hide();
            Client InitializeData = new Client();
            InitializeData.Show();
        }
    }
}
