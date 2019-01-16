using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FIY_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection FIYconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\FIY_Hospital.mdf;Integrated Security=True;");
            SqlDataAdapter FIYadapter = new SqlDataAdapter("Select [ROLE] From [Table] Where [USERNAME]='" + textBox1.Text + "' and [PASSWORD]='" + textBox2.Text + "'", FIYconnection);
            DataTable FIYdata = new DataTable();
            FIYadapter.Fill(FIYdata);
            try
            {
                if (FIYdata.Rows[0][0].ToString() == "Admin")
                {
                    this.Close();
                    Client FIYload = new Client();
                    FIYload.Show();
                }
                else if (FIYdata.Rows[0][0].ToString() == "Doctor")
                {
                    this.Close();
                    MessageBox.Show("You are doctor.");
                }
                else if (FIYdata.Rows[0][0].ToString() == "Nurse")
                {
                    this.Close();
                    MessageBox.Show("You are nurse.");
                }
            }
            catch(IndexOutOfRangeException) { MessageBox.Show("Wrong username or password."); }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "PASSWORD") {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
            }
            if (textBox1.Text == "") { textBox1.Text = "LOGIN"; }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "LOGIN") { textBox1.Text = ""; }
            if (textBox2.Text == "") {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "PASSWORD";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are fired.");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { LOGIN.PerformClick(); }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { LOGIN.PerformClick(); }
        }
    }
}
