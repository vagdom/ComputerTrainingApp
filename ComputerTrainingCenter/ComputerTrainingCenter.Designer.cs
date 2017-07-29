namespace ComputerTrainingCenter
{
    partial class ComputerTrainingCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerTrainingCenter));
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCoursesSchedules = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnEnrollments = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(13, 13);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(226, 81);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnCoursesSchedules
            // 
            this.btnCoursesSchedules.Location = new System.Drawing.Point(260, 13);
            this.btnCoursesSchedules.Name = "btnCoursesSchedules";
            this.btnCoursesSchedules.Size = new System.Drawing.Size(226, 81);
            this.btnCoursesSchedules.TabIndex = 1;
            this.btnCoursesSchedules.Text = "Courses Schedules";
            this.btnCoursesSchedules.UseVisualStyleBackColor = true;
            this.btnCoursesSchedules.Click += new System.EventHandler(this.btnCoursesSchedules_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(13, 100);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(226, 81);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnEnrollments
            // 
            this.btnEnrollments.Location = new System.Drawing.Point(260, 100);
            this.btnEnrollments.Name = "btnEnrollments";
            this.btnEnrollments.Size = new System.Drawing.Size(226, 81);
            this.btnEnrollments.TabIndex = 3;
            this.btnEnrollments.Text = "Enrollments";
            this.btnEnrollments.UseVisualStyleBackColor = true;
            this.btnEnrollments.Click += new System.EventHandler(this.btnEnrollments_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(13, 187);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(226, 81);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(260, 187);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(226, 81);
            this.btnTeachers.TabIndex = 5;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Location = new System.Drawing.Point(13, 274);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(226, 81);
            this.btnDepartments.TabIndex = 6;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(260, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(226, 81);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ComputerTrainingCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 365);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDepartments);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnEnrollments);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnCoursesSchedules);
            this.Controls.Add(this.btnStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComputerTrainingCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Training Center";
            this.Load += new System.EventHandler(this.ComputerTrainingCenter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCoursesSchedules;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnEnrollments;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnClose;
    }
}

