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
            try
            {
                
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
