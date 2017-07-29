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


namespace ComputerTrainingCenter
{
    public partial class CourseDelete : Form
    {
        public CourseDelete()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCourseCode.Text)))
            {
                using (SqlConnection scComputerTrainingCenter =
                        new SqlConnection("Data Source=(local);" +
                                      "Database='ComputerTrainingCenter1';" +
                                      "Integrated Security=Yes"))
                {
                    SqlCommand cmdCourseLevels =
                    new SqlCommand("SELECT CourseName, CourseLevel, Notes " +
                                   "FROM Academics.Courses " +
                                   "WHERE CourseCode = N'" + txtCourseCode.Text + "';",
                                   scComputerTrainingCenter);
                    scComputerTrainingCenter.Open();

                    SqlDataReader sdrCourseLevels = cmdCourseLevels.ExecuteReader();

                    while (sdrCourseLevels.Read())
                    {
                        txtCourseName.Enabled = true;
                        cbxCourseLevels.Enabled = true;
                        txtDescription.Enabled = true;
                        txtCourseName.Text = sdrCourseLevels[0].ToString();
                        cbxCourseLevels.Text = sdrCourseLevels[1].ToString();
                        txtDescription.Text = sdrCourseLevels[2].ToString();
                    }

                    if (txtCourseName.Text == "")
                    {
                        MessageBox.Show("Invalid Course Code.",
                                "Computer Training Center",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Course Code.",
                                "Computer Training Center",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
