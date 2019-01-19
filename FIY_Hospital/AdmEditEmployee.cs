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
    public partial class AdmEditEmployee : Form
    {
        public AdmEditEmployee()
        {
            InitializeComponent();
        }

        private void AdmEditEmployee_Load(object sender, EventArgs e)
        {
            GenerateEmployeeTable(Employee.EmployeesData.Count + 1);
        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client GoBack = new Client();
            GoBack.Show();
        }

        private void AdmEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Client InitializeData = new Client();
            InitializeData.Show();
        }

        private void GenerateEmployeeTable(int rowCount)
        {
            int columnCount = 8;

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.RowCount = rowCount;
            tableLayoutPanel1.MaximumSize = new Size(rowCount * 20, Screen.PrimaryScreen.Bounds.Height - 500);

            for (int x = 0; x < columnCount; x++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    int CountId = y;
                    if (x == 0) { tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize)); }
                    if (y == 0)
                    {
                        Label lb = new Label()
                        {
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.None
                        };
                        lb.Font = new Font(lb.Font, FontStyle.Bold);
                        lb.BackColor = Color.FromArgb(192, 192, 0);
                        lb.Text = string.Format(Employee.HeadersAdminCheck[x]);
                        tableLayoutPanel1.Controls.Add(lb, x, y);
                    }
                    else { GenerateAdminCells(x, y); }
                }
            }
        }

        private void GenerateAdminCells(int x, int y)
        {
            switch (x)
            {
                case 0:
                    Label lb0 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb0.BackColor = Color.LightGray;
                    lb0.Text = y.ToString();
                    comboBox1.Items.Add(y);
                    tableLayoutPanel1.Controls.Add(lb0, x, y);
                    break;
                case 1:
                    Label lb1 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb1.BackColor = Color.LightGray;
                    lb1.Text = Employee.EmployeesData[y - 1].Username.ToString();
                    tableLayoutPanel1.Controls.Add(lb1, x, y);
                    break;
                case 2:
                    Label lb2 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb2.BackColor = Color.LightGray;
                    lb2.Text = Employee.EmployeesData[y - 1].Password.ToString();
                    tableLayoutPanel1.Controls.Add(lb2, x, y);
                    break;
                case 3:
                    Label lb4 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb4.BackColor = Color.LightGray;
                    lb4.Text = Employee.EmployeesData[y - 1].Name.ToString();
                    tableLayoutPanel1.Controls.Add(lb4, x, y);
                    break;
                case 4:
                    Label lb5 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb5.BackColor = Color.LightGray;
                    lb5.Text = Employee.EmployeesData[y - 1].Surname.ToString();
                    tableLayoutPanel1.Controls.Add(lb5, x, y);
                    break;
                case 5:
                    Label lb6 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb6.BackColor = Color.LightGray;
                    lb6.Text = Employee.EmployeesData[y - 1].Pesel.ToString();
                    tableLayoutPanel1.Controls.Add(lb6, x, y);
                    break;
                case 6:
                    Label lb7 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb7.BackColor = Color.LightGray;
                    lb7.Text = Employee.EmployeesData[y - 1].PWD.ToString();
                    tableLayoutPanel1.Controls.Add(lb7, x, y);
                    break;
                case 7:
                    Label lb8 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.None
                    };
                    lb8.BackColor = Color.LightGray;
                    lb8.Text = Employee.EmployeesData[y - 1].Specialization.ToString();
                    tableLayoutPanel1.Controls.Add(lb8, x, y);
                    break;
                default: break;
            }
        }
    }
}
