namespace ComputerTrainingCenter
{
    partial class CourseLevels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseLevels));
            this.dgvCourseLevels = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcCoursesLevels = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewDescription = new System.Windows.Forms.TextBox();
            this.txtNewCourseLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateCourseLevel = new System.Windows.Forms.Button();
            this.btnFindEditCourseLevel = new System.Windows.Forms.Button();
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.txtEditCourseLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteCourseLevel = new System.Windows.Forms.Button();
            this.txtDeleteDescription = new System.Windows.Forms.TextBox();
            this.btnFindDeleteCourseLevel = new System.Windows.Forms.Button();
            this.txtDeleteCourseLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseLevels)).BeginInit();
            this.tcCoursesLevels.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCourseLevels
            // 
            this.dgvCourseLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseLevels.Location = new System.Drawing.Point(13, 13);
            this.dgvCourseLevels.Name = "dgvCourseLevels";
            this.dgvCourseLevels.Size = new System.Drawing.Size(1046, 178);
            this.dgvCourseLevels.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(984, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcCoursesLevels
            // 
            this.tcCoursesLevels.Controls.Add(this.tabPage1);
            this.tcCoursesLevels.Controls.Add(this.tabPage2);
            this.tcCoursesLevels.Controls.Add(this.tabPage3);
            this.tcCoursesLevels.Location = new System.Drawing.Point(13, 227);
            this.tcCoursesLevels.Name = "tcCoursesLevels";
            this.tcCoursesLevels.SelectedIndex = 0;
            this.tcCoursesLevels.Size = new System.Drawing.Size(1046, 175);
            this.tcCoursesLevels.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtNewDescription);
            this.tabPage1.Controls.Add(this.txtNewCourseLevel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Course Level";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(868, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewDescription
            // 
            this.txtNewDescription.Location = new System.Drawing.Point(101, 34);
            this.txtNewDescription.Multiline = true;
            this.txtNewDescription.Name = "txtNewDescription";
            this.txtNewDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNewDescription.Size = new System.Drawing.Size(872, 67);
            this.txtNewDescription.TabIndex = 3;
            // 
            // txtNewCourseLevel
            // 
            this.txtNewCourseLevel.Location = new System.Drawing.Point(101, 7);
            this.txtNewCourseLevel.Name = "txtNewCourseLevel";
            this.txtNewCourseLevel.Size = new System.Drawing.Size(131, 20);
            this.txtNewCourseLevel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Level: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateCourseLevel);
            this.tabPage2.Controls.Add(this.btnFindEditCourseLevel);
            this.tabPage2.Controls.Add(this.txtEditDescription);
            this.tabPage2.Controls.Add(this.txtEditCourseLevel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Course Level";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCourseLevel
            // 
            this.btnUpdateCourseLevel.Location = new System.Drawing.Point(463, 108);
            this.btnUpdateCourseLevel.Name = "btnUpdateCourseLevel";
            this.btnUpdateCourseLevel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCourseLevel.TabIndex = 5;
            this.btnUpdateCourseLevel.Text = "Update";
            this.btnUpdateCourseLevel.UseVisualStyleBackColor = true;
            this.btnUpdateCourseLevel.Click += new System.EventHandler(this.btnUpdateCourseLevel_Click);
            // 
            // btnFindEditCourseLevel
            // 
            this.btnFindEditCourseLevel.Location = new System.Drawing.Point(321, 5);
            this.btnFindEditCourseLevel.Name = "btnFindEditCourseLevel";
            this.btnFindEditCourseLevel.Size = new System.Drawing.Size(75, 23);
            this.btnFindEditCourseLevel.TabIndex = 4;
            this.btnFindEditCourseLevel.Text = "Find";
            this.btnFindEditCourseLevel.UseVisualStyleBackColor = true;
            this.btnFindEditCourseLevel.Click += new System.EventHandler(this.btnFindEditCourseLevel_Click);
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Location = new System.Drawing.Point(88, 36);
            this.txtEditDescription.Multiline = true;
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditDescription.Size = new System.Drawing.Size(450, 66);
            this.txtEditDescription.TabIndex = 3;
            // 
            // txtEditCourseLevel
            // 
            this.txtEditCourseLevel.Location = new System.Drawing.Point(88, 9);
            this.txtEditCourseLevel.Name = "txtEditCourseLevel";
            this.txtEditCourseLevel.Size = new System.Drawing.Size(209, 20);
            this.txtEditCourseLevel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course Level: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteCourseLevel);
            this.tabPage3.Controls.Add(this.txtDeleteDescription);
            this.tabPage3.Controls.Add(this.btnFindDeleteCourseLevel);
            this.tabPage3.Controls.Add(this.txtDeleteCourseLevel);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1038, 149);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Course level";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourseLevel
            // 
            this.btnDeleteCourseLevel.Location = new System.Drawing.Point(344, 92);
            this.btnDeleteCourseLevel.Name = "btnDeleteCourseLevel";
            this.btnDeleteCourseLevel.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteCourseLevel.TabIndex = 5;
            this.btnDeleteCourseLevel.Text = "Delete";
            this.btnDeleteCourseLevel.UseVisualStyleBackColor = true;
            this.btnDeleteCourseLevel.Click += new System.EventHandler(this.btnDeleteCourseLevel_Click);
            // 
            // txtDeleteDescription
            // 
            this.txtDeleteDescription.Location = new System.Drawing.Point(119, 55);
            this.txtDeleteDescription.Multiline = true;
            this.txtDeleteDescription.Name = "txtDeleteDescription";
            this.txtDeleteDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeleteDescription.Size = new System.Drawing.Size(316, 20);
            this.txtDeleteDescription.TabIndex = 4;
            // 
            // btnFindDeleteCourseLevel
            // 
            this.btnFindDeleteCourseLevel.Location = new System.Drawing.Point(344, 12);
            this.btnFindDeleteCourseLevel.Name = "btnFindDeleteCourseLevel";
            this.btnFindDeleteCourseLevel.Size = new System.Drawing.Size(91, 23);
            this.btnFindDeleteCourseLevel.TabIndex = 3;
            this.btnFindDeleteCourseLevel.Text = "Find";
            this.btnFindDeleteCourseLevel.UseVisualStyleBackColor = true;
            this.btnFindDeleteCourseLevel.Click += new System.EventHandler(this.btnFindDeleteCourseLevel_Click);
            // 
            // txtDeleteCourseLevel
            // 
            this.txtDeleteCourseLevel.Location = new System.Drawing.Point(119, 12);
            this.txtDeleteCourseLevel.Name = "txtDeleteCourseLevel";
            this.txtDeleteCourseLevel.Size = new System.Drawing.Size(219, 20);
            this.txtDeleteCourseLevel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Description: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Course Level: ";
            // 
            // CourseLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 471);
            this.Controls.Add(this.tcCoursesLevels);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCourseLevels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Training Center - Course Levels";
            this.Load += new System.EventHandler(this.CourseLevels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseLevels)).EndInit();
            this.tcCoursesLevels.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourseLevels;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcCoursesLevels;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewDescription;
        private System.Windows.Forms.TextBox txtNewCourseLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateCourseLevel;
        private System.Windows.Forms.Button btnFindEditCourseLevel;
        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.TextBox txtEditCourseLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDeleteCourseLevel;
        private System.Windows.Forms.TextBox txtDeleteDescription;
        private System.Windows.Forms.Button btnFindDeleteCourseLevel;
        private System.Windows.Forms.TextBox txtDeleteCourseLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}