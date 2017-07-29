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
    public partial class CourseLevels : Form
    {
        public CourseLevels()
        {
            InitializeComponent();
        }

        private void ShowCourseLevels()
        {
            using (SqlConnection scComputerTrainingCenter =
                    new SqlConnection("Data Source=(local);" +
                                  "Database='ComputerTrainingCenter1';" +
                                  "Integrated Security=Yes"))
            {
                SqlCommand cmdCourseLevels =
                    new SqlCommand("SELECT ALL * FROM Academics.CourseLevels;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataAdapter sdaCourseLevels = new SqlDataAdapter(cmdCourseLevels);
                DataSet dsCourseLevels = new DataSet("CourseLevelsSet");

                sdaCourseLevels.Fill(dsCourseLevels);
                
                dgvCourseLevels.DataSource = dsCourseLevels.Tables[0];
                dgvCourseLevels.Columns[1].Width = 900;

            }
        }

        private void CourseLevels_Load(object sender, EventArgs e)
        {
            ShowCourseLevels();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtNewCourseLevel.Text)))
            {
                using (SqlConnection scComputerTrainingCenter =
                        new SqlConnection("Data Source=(local);" +
                                      "Database='ComputerTrainingCenter1';" +
                                      "Integrated Security=Yes"))
                {
                    SqlCommand cmdEmployee =
                        new SqlCommand("INSERT INTO Academics.CourseLevels(CourseLevel, Notes) " +
                                       "VALUES(N'" + txtNewCourseLevel.Text + "', N'" +
                                       txtNewDescription.Text + "');",
                                       scComputerTrainingCenter);
                    scComputerTrainingCenter.Open();
                    cmdEmployee.ExecuteNonQuery();

                    txtNewCourseLevel.Text = "";
                    txtNewDescription.Text = "";
                    ShowCourseLevels();
                }
            }
        }

        private void btnFindEditCourseLevel_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtEditCourseLevel.Text)))
            {
                using (SqlConnection scComputerTrainingCenter =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='ComputerTrainingCenter1';" +
                                          "Integrated Security=Yes"))
                {
                    SqlCommand cmdCourseLevels =
                        new SqlCommand("SELECT [Notes] " +
                                       "FROM Academics.CourseLevels " +
                                       "WHERE CourseLevel = N'" + txtEditCourseLevel.Text + "';",
                                       scComputerTrainingCenter);
                    scComputerTrainingCenter.Open();

                    SqlDataReader sdrCourseLevels = cmdCourseLevels.ExecuteReader();

                    while (sdrCourseLevels.Read())
                    {
                        txtEditDescription.Text = sdrCourseLevels[0].ToString();
                    }
                }
            }
        }

        private void btnUpdateCourseLevel_Click(object sender, EventArgs e)
        {
            using (SqlConnection scComputerTrainingCenter =
            new SqlConnection("Data Source=(local);" +
                              "Database='ComputerTrainingCenter1';" +
                              "Integrated Security=Yes"))
            {
                SqlCommand cmdEmployee =
                        new SqlCommand("UPDATE Academics.CourseLevels " +
                                       "SET [Description] = N'" + txtEditDescription.Text + "' " +
                                       "WHERE CourseLevel = N'" + txtEditCourseLevel.Text + "';",
                                       scComputerTrainingCenter);
                scComputerTrainingCenter.Open();
                cmdEmployee.ExecuteNonQuery();

                MessageBox.Show("The course level has been updated.",
                                "Computer Training Center",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtEditCourseLevel.Text = "";
            txtEditDescription.Text = "";
            ShowCourseLevels();
        }

        private void btnFindDeleteCourseLevel_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtDeleteCourseLevel.Text)))
            {
                using (SqlConnection scComputerTrainingCenter =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='ComputerTrainingCenter1';" +
                                          "Integrated Security=Yes"))
                {
                    SqlCommand cmdCourseLevels =
                        new SqlCommand("SELECT [Description] " +
                                       "FROM Academics.CourseLevels " +
                                       "WHERE CourseLevel = N'" + txtDeleteCourseLevel.Text + "';",
                                       scComputerTrainingCenter);
                    scComputerTrainingCenter.Open();

                    SqlDataReader sdrCourseLevels = cmdCourseLevels.ExecuteReader();

                    while (sdrCourseLevels.Read())
                    {
                        txtDeleteDescription.Text = sdrCourseLevels[0].ToString();
                    }
                }
            }
        }

        private void btnDeleteCourseLevel_Click(object sender, EventArgs e)
        {
            using (SqlConnection scComputerTrainingCenter =
            new SqlConnection("Data Source=(local);" +
                              "Database='ComputerTrainingCenter1';" +
                              "Integrated Security=Yes"))
            {
                SqlCommand cmdEmployee =
                        new SqlCommand("DELETE FROM Academics.CourseLevels " +
                                       "WHERE CourseLevel = N'" + txtDeleteCourseLevel.Text + "';",
                                       scComputerTrainingCenter);
                scComputerTrainingCenter.Open();
                cmdEmployee.ExecuteNonQuery();

                MessageBox.Show("The course level has been deleted.",
                                "Computer Training Center",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtEditCourseLevel.Text = "";
            txtEditDescription.Text = "";
            ShowCourseLevels();
        }
    }
}
