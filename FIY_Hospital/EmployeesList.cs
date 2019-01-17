using System;
using System.Drawing;
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
            string Role = LoginData.Role(LoginScreen.Username);
            int ColumnCount = 0;

            if (Role == "Admin") { ColumnCount = 7; }
            else ColumnCount = 4;

            GenerateEmployeeTable(Employee.EmployeesData.Count + 1, ColumnCount, Role);
        }

        private void EmloyeesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Client InitializeData = new Client();
            InitializeData.Show();
        }

        private void GenerateEmployeeTable(int rowCount, int columnCount, string Role)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;
            tableLayoutPanel1.MaximumSize = new Size(rowCount * 20, Screen.PrimaryScreen.Bounds.Height - 200);

            for (int x = 0; x < columnCount; x++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    if (x == 0) { tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize)); }
                    if (y == 0)
                    {
                        if (Role != "Admin")
                        {
                            Label lb = new Label();
                            lb.Font = new Font(lb.Font, FontStyle.Bold);
                            lb.Text = string.Format(Employee.HeadersEmployee[x]);
                            tableLayoutPanel1.Controls.Add(lb, x, y);
                        }
                        else
                        {
                            Label lb = new Label();
                            lb.Font = new Font(lb.Font, FontStyle.Bold);
                            lb.Text = string.Format(Employee.HeadersAdmin[x]);
                            tableLayoutPanel1.Controls.Add(lb, x, y);
                        }
                    }
                    else
                    {
                        if ((Role == "Admin"))
                        {
                            GenerateAdminCells(x, y);
                        }
                        else
                        {
                            GenerateCells(x, y);
                        }
                    }
                }
            }
        }

        private void GenerateAdminCells(int x, int y)
        {
            switch (x)
            {
                case 0:
                    Label lb1 = new Label();
                    lb1.Text = Employee.EmployeesData[y - 1].Username.ToString();
                    tableLayoutPanel1.Controls.Add(lb1, x, y);
                    break;
                case 1:
                    Label lb2 = new Label();
                    lb2.Text = Employee.EmployeesData[y - 1].Password.ToString();
                    tableLayoutPanel1.Controls.Add(lb2, x, y);
                    break;
                case 2:
                    Label lb4 = new Label();
                    lb4.Text = Employee.EmployeesData[y - 1].Name.ToString();
                    tableLayoutPanel1.Controls.Add(lb4, x, y);
                    break;
                case 3:
                    Label lb5 = new Label();
                    lb5.Text = Employee.EmployeesData[y - 1].Surname.ToString();
                    tableLayoutPanel1.Controls.Add(lb5, x, y);
                    break;
                case 4:
                    Label lb6 = new Label();
                    lb6.Text = Employee.EmployeesData[y - 1].Pesel.ToString();
                    tableLayoutPanel1.Controls.Add(lb6, x, y);
                    break;
                case 5:
                    Label lb7 = new Label();
                    lb7.Text = Employee.EmployeesData[y - 1].PWD.ToString();
                    tableLayoutPanel1.Controls.Add(lb7, x, y);
                    break;
                case 6:
                    Label lb8 = new Label();
                    lb8.Text = Employee.EmployeesData[y - 1].Specialization.ToString();
                    tableLayoutPanel1.Controls.Add(lb8, x, y);
                    break;
                default: break;
            }
        }

        private void GenerateCells(int x, int y)
        {
            switch (x)
            {
                case 0:
                    Label lb1 = new Label();
                    lb1.Text = Employee.EmployeesData[y - 1].Name.ToString();
                    tableLayoutPanel1.Controls.Add(lb1, x, y);
                    break;
                case 1:
                    Label lb2 = new Label();
                    lb2.Text = Employee.EmployeesData[y - 1].Surname.ToString();
                    tableLayoutPanel1.Controls.Add(lb2, x, y);
                    break;
                case 2:
                    Label lb3 = new Label();
                    lb3.Text = Employee.EmployeesData[y - 1].PWD.ToString();
                    tableLayoutPanel1.Controls.Add(lb3, x, y);
                    break;
                case 3:
                    Label lb4 = new Label();
                    lb4.Text = Employee.EmployeesData[y - 1].Specialization.ToString();
                    tableLayoutPanel1.Controls.Add(lb4, x, y);
                    break;
                default: break;
            }
        }
    }
}