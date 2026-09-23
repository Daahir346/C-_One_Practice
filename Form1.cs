using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;namespace abdirahman
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            txtStudentId.Text = string.Empty;
            txtSemester.Text = string.Empty;
            txtname.Text = string.Empty;
            txtdepartment.Text = string.Empty;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string name, dept;
            int semester, studentId;
            name = txtname.Text;
            dept = txtdepartment.Text;
            studentId = int.Parse(txtStudentId.Text);
            semester = int.Parse((string)txtSemester.Text);

            lbloutput.Text =
                "Student Name: " + name + " Student ID: "
                + studentId + " Department: "
                + dept + " Semester: " + semester;
        }
    }
}
