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
    public partial class home2 : Form
    {
        public home2()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent obj1 = new AddStudent();
            obj1.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home obj2 = new Home();
            obj2.Show();
        }

        private void showAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAttendance obj3 = new ShowAttendance();
            obj3.Show();
        }
    }
}
