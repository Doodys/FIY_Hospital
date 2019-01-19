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
    public partial class SchCard : Form
    {
        static string Spec, Role;
        static int EmplCounter = 0;
        public static List<int> Index = new List<int>();
        static int i1 = 0;
        static int i2 = 2;
        static int i3 = 4;

        public SchCard()
        {
            InitializeComponent();
        }

        private void SchCard_Load(object sender, EventArgs e)
        {
            Spec = Client.Specialization;
            Role = Client.Role;

            if (Role == "Nurse")
            {
                for (int i = 0; i < Employee.EmployeesData.Count; i++)
                {
                    if (Employee.EmployeesData[i].Role == "Nurse")
                    {
                        Index.Add(i);
                        EmplCounter++;
                    }
                }
            }
            else
            {
                Role = "none";
                for (int i = 0; i < Employee.EmployeesData.Count; i++)
                {
                    if (Employee.EmployeesData[i].Specialization == Spec)
                    {
                        Index.Add(i);
                        EmplCounter++;
                    }
                }
            }

            GenerateEmployeeTable(EmplCounter + 1);
            GenerateSchedule(Role);

        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client InitializeData = new Client();
            InitializeData.Show();
        }

        private void SchCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Client InitializeData = new Client();
            InitializeData.Show();
        }

        private void GenerateEmployeeTable(int rowCount)
        {
            int columnCount = 3;

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = rowCount;
            tableLayoutPanel1.MaximumSize = new Size(rowCount * 200, Screen.PrimaryScreen.Bounds.Height - 500);

            for (int x = 0; x < columnCount; x++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
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
                        lb.Text = string.Format(Employee.HeadersSchedule[x]);
                        tableLayoutPanel1.Controls.Add(lb, x, y);
                    }
                    else
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
                                lb0.Text = Index[y - 1].ToString();
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
                                lb1.Text = Employee.EmployeesData[Index[y - 1]].Name;
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
                                lb2.Text = Employee.EmployeesData[Index[y - 1]].Surname;
                                tableLayoutPanel1.Controls.Add(lb2, x, y);
                                break;
                            default: break;
                        }
                    }
                }
            }
        }

        private void GenerateSchedule(string Role)
        {
            int columnCount = 7;
            int rowCount = 5;

            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();

            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.RowCount = rowCount;
            tableLayoutPanel2.MaximumSize = new Size(rowCount * 200, Screen.PrimaryScreen.Bounds.Height - 500);

            for (int x = 0; x < columnCount; x++)
            {
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    if (x == 0) { tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize)); }
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
                        lb.Text = string.Format(Employee.Days[x]);
                        tableLayoutPanel2.Controls.Add(lb, x, y);
                    }
                }
            }

            int p1 = 0, p3 = 1, p5 = 2;
            int p2, p4, p6;

            for (int i = 1; i < rowCount; i++)
            {
                if (p1 > 3 && i == 3) { p2 = 3 - (p1 - 2); p1 = p2; }
                if (i == 4) { p1 = 0; }

                for (int j = p1; j < columnCount; j += 3)
                {
                    if (Role == "Nurse")
                    {
                        Label lb = new Label()
                        {
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.None
                        };
                        lb.BackColor = Color.LightGray;
                        lb.Text = Index[i1].ToString() + " and " + Index[i1 + 1].ToString();
                        tableLayoutPanel2.Controls.Add(lb, j, i);
                    }
                    else
                    {
                        Label lb = new Label()
                        {
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.None
                        };
                        lb.BackColor = Color.LightGray;
                        lb.Text = Index[i1].ToString();
                        tableLayoutPanel2.Controls.Add(lb, j, i);
                    }
                }

                if (p3 > 3 && i == 4) { p4 = 3 - (p3 - 2); p3 = p4; }
                if (i == 2) { p3 = 0; }
                for (int j = p3; j < columnCount; j += 3)
                {
                    if (Role == "Nurse")
                    {
                        Label lb = new Label()
                        {
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.None
                        };
                        lb.BackColor = Color.LightGray;
                        lb.Text = Index[i2].ToString() + " and " + Index[i2 + 1].ToString();
                        tableLayoutPanel2.Controls.Add(lb, j, i);
                    }
                    else
                    {
                        Label lb = new Label()
                        {
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.None
                        };
                        lb.BackColor = Color.LightGray;
                        lb.Text = Index[i1 + 1].ToString();
                        tableLayoutPanel2.Controls.Add(lb, j, i);
                    }
                }

                if (p5 > 3 && i == 2) { p6 = 3 - (p5 - 2); p5 = p6; }
                if (i == 3) { p5 = 0; }
                for (int j = p5; j < columnCount; j += 3)
                {

                    if (Role == "Nurse")
                    {
                        Label lb = new Label()
                        {
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.None
                        };
                        lb.BackColor = Color.LightGray;
                        lb.Text = Index[i3].ToString() + " and " + Index[i3 + 1].ToString();
                        tableLayoutPanel2.Controls.Add(lb, j, i);
                    }
                    else
                    {
                        Label lb = new Label()
                        {
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.None
                        };
                        lb.BackColor = Color.LightGray;
                        lb.Text = Index[i1 + 2].ToString();
                        tableLayoutPanel2.Controls.Add(lb, j, i);
                    }
                }
                p1 += 2;
                p3 += 2;
                p5 += 2;
            }           
        }
    }
}
