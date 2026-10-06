namespace WinFormsStudentApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label resultLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // studentNameLabel
            //
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(30, 33);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(81, 13);
            this.studentNameLabel.Text = "Student Name:";
            //
            // courseNameLabel
            //
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(30, 78);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(74, 13);
            this.courseNameLabel.Text = "Course Name:";
            //
            // txtStudentName
            //
            this.txtStudentName.Location = new System.Drawing.Point(130, 30);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(238, 20);
            this.txtStudentName.TabIndex = 0;
            //
            // txtCourseName
            //
            this.txtCourseName.Location = new System.Drawing.Point(130, 75);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(238, 20);
            this.txtCourseName.TabIndex = 1;
            //
            // showButton
            //
            this.showButton.Location = new System.Drawing.Point(130, 117);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(108, 30);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Details";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            //
            // resultLabel
            //
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(130, 165);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 230);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.resultLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Student App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
