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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void ShowCourses()
        {
            using (SqlConnection scComputerTrainingCenter =
                    new SqlConnection("Data Source=(local);" +
                                  "Database='ComputerTrainingCenter1';" +
                                  "Integrated Security=Yes"))
            {
                SqlCommand cmdCourses =
                    new SqlCommand("SELECT CourseCode Code, " +
                                   "       CourseName Name, " +
                                   "       CourseLevel Level, " +
                                   "       Notes " +
                                   "FROM Academics.Courses;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataAdapter sdaCourses = new SqlDataAdapter(cmdCourses);
                DataSet dsCourses = new DataSet("CoursesSet");

                sdaCourses.Fill(dsCourses);
                dgvCourses.DataSource = dsCourses.Tables[0];

                //Columns width 
                dgvCourses.Columns[0].Width = 60;
                dgvCourses.Columns[1].Width = 220;
                dgvCourses.Columns[2].Width = 70;
                dgvCourses.Columns[3].Width = 310;


            }
        }


        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            CourseNew cn = new CourseNew();
            //cn.Show();

            using (SqlConnection scComputerTrainingCenter =
            new SqlConnection("Data Source=(local);" +
                              "Database='ComputerTrainingCenter1';" +
                              "Integrated Security=Yes"))
            {
                SqlCommand cmdCourseLevels =
                    new SqlCommand("SELECT ALL * FROM Academics.CourseLevels;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataReader sdrCourseLevels = cmdCourseLevels.ExecuteReader();

                while (sdrCourseLevels.Read())
                {
                    cn.cbxCourseLevels.Items.Add(sdrCourseLevels[0].ToString());
                }
            }
            
            if (cn.ShowDialog() == DialogResult.OK)
            {                
                if (!(string.IsNullOrEmpty(cn.txtCourseCode.Text)))
                {
                    using (SqlConnection scComputerTrainingCenter =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='ComputerTrainingCenter1';" +
                                          "Integrated Security=Yes"))
                    {
                        SqlCommand cmdEmployee =
                            new SqlCommand("INSERT INTO Academics.Courses " +
                                           "VALUES(N'" + cn.txtCourseCode.Text + "', N'" +
                                           cn.txtCourseName.Text + "', N'" +
                                           cn.cbxCourseLevels.Text + "', N'" +
                                           cn.txtDescription.Text + "');",
                                           scComputerTrainingCenter);
                        scComputerTrainingCenter.Open();
                        cmdEmployee.ExecuteNonQuery();

                        MessageBox.Show("The course has been created.",
                                        "Computer Training Center",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ShowCourses();
                }
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            
            CourseUpdate cu = new CourseUpdate();

            if (cu.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(cu.txtCourseCode.Text)))
                {
                    using (SqlConnection scComputerTrainingCenter =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='ComputerTrainingCenter1';" +
                                          "Integrated Security=Yes"))
                    {
                        SqlCommand cmdCourseLevels =
                   new SqlCommand("UPDATE Academics.Courses " +
                                  "SET CourseName = N'" + cu.txtCourseName.Text + "', " +
                                  "    CourseLevel = N'" + cu.cbxCourseLevels.Text + "', " +
                                  "    [Notes] = N'" + cu.txtDescription.Text + "' " +
                                  "WHERE CourseCode = N'" + cu.txtCourseCode.Text + "';",
                                  scComputerTrainingCenter);
                        scComputerTrainingCenter.Open();
                        cmdCourseLevels.ExecuteNonQuery();

                        MessageBox.Show("The course record has been updated.",
                                        "Computer Training Center",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                    ShowCourses();
                }
           

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            CourseDelete cd = new CourseDelete();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(cd.txtCourseCode.Text)))
                {
                    using (SqlConnection scComputerTrainingCenter =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='ComputerTrainingCenter1';" +
                                          "Integrated Security=Yes"))
                    {
                        SqlCommand cmdCourseLevels =
                   new SqlCommand("DELETE Academics.Courses " +                                  
                                  "WHERE CourseCode = N'" + cd.txtCourseCode.Text + "';",
                                  scComputerTrainingCenter);
                        scComputerTrainingCenter.Open();
                        cmdCourseLevels.ExecuteNonQuery();

                        MessageBox.Show("The course record has been deleted.",
                                        "Computer Training Center",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ShowCourses();
            }

        }

        private void btnCourseLevels_Click(object sender, EventArgs e)
        {
            CourseLevels cl = new CourseLevels();
            cl.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            ShowCourses();
        }
    }
}
