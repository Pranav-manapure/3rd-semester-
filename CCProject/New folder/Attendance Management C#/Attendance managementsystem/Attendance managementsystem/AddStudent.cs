﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Attendance_managementsystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\Attendance managementsystem\Attendance managementsystem\Attendance.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            string str = "Insert into student(roll_no,name,class,address) values('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"');";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();

            string str1 = "select max(roll_no) from student ;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("" + textBox2.Text + "'s Details is Inserted Successfully.. " , "Important Message");
                this.Hide();

            }
            this.Close();
        }
    }
}
