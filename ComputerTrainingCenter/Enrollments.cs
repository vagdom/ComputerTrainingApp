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
    public partial class Enrollments : Form
    {
        public Enrollments()
        {
            InitializeComponent();
        }

        private void ShowEnrollments()
        {
            using (SqlConnection scComputerTrainingCenter =
                    new SqlConnection("Data Source=(local);" +
                                  "Database='ComputerTrainingCenter1';" +
                                  "Integrated Security=Yes"))
            {
                SqlCommand cmdEnrollments =
                    new SqlCommand("SELECT nrl.EnrollmentID [Enroll ID], " +
                                   "       CONCAT(stds.StudentNumber, N': ', stds.StudentName) AS Student, " +
                                   "       CONCAT(crs.CourseLevel, N': ', crs.CourseCode, N' - ', crs.CourseName) AS Course, " +
                                   "       CONCAT(tch.TeacherNumber, N': ', tch.TeacherName) AS Teacher, " +
                                   "       css.DaysTaught Days, " +
                                   "       css.TimeTaught [Time], " +
                                   "       css.StartDate [Start Date], " +
                                   "       css.EndDate [End Date], " +
                                   "       css.RoomNumber [Rm #]" +
                                   "FROM   Academics.Enrollments nrl " +
                                   "INNER JOIN Academics.CoursesSchedules css " +
                                   "       ON nrl.ScheduleID = css.ScheduleID " +
                                   "INNER JOIN Administration.Students stds " +
                                   "       ON nrl.StudentNumber = stds.StudentNumber " +
                                   "INNER JOIN Academics.Courses crs " +
                                   "       ON css.CourseCode = crs.CourseCode " +
                                   "INNER JOIN Administration.Teachers tch " +
                                   "       ON css.TeacherNumber = tch.TeacherNumber;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataAdapter sdaEnrollments = new SqlDataAdapter(cmdEnrollments);
                DataSet dsEnrollments = new DataSet("CoursesSet");

                sdaEnrollments.Fill(dsEnrollments);
                dgvEnrollments.DataSource = dsEnrollments.Tables[0];
            }
        }
        
        private void Enrollments_Load(object sender, EventArgs e)
        {
            ShowEnrollments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
