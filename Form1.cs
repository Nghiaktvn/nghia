using System;
using System.Windows.Forms;

namespace WinFormsStudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string courseName = txtCourseName.Text.Trim();

            if (studentName.Length == 0 || courseName.Length == 0)
            {
                MessageBox.Show("Please enter both the student name and course name.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            resultLabel.Text = "Student: " + studentName + Environment.NewLine
                + "Course: " + courseName;
        }
    }
}
