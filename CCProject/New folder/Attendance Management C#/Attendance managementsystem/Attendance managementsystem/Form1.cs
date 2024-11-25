using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Attendance_managementsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "code" && textBox2.Text == "codeprojects")
            {
                home2 obj1 = new home2();
                obj1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username and password.");
            }
        }
    }
}
