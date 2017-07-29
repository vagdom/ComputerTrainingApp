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
    public partial class CoursesSchedules : Form
    {
        public CoursesSchedules()
        {
            InitializeComponent();
        }

        private void ShowCoursesSchedules()
        {
            using (SqlConnection scComputerTrainingCenter =
                    new SqlConnection("Data Source=(local);" +
                                  "Database='ComputerTrainingCenter1';" +
                                  "Integrated Security=Yes"))
            {
                SqlCommand cmdSchedules =
                    new SqlCommand("SELECT ScheduleID    [Schd ID], " +
                                   "       CourseCode    Code, " +
                                   "       TeacherNumber [Teacher #], " +
                                   "       DaysTaught    [Days Taught], " +
                                   "       TimeTaught    [Time Taught], " +
                                   "       StartDate     [Start Date], " +
                                   "       EndDate       [End Date], " +
                                   "       RoomNumber    [Room #] " +
                                   "FROM Academics.CoursesSchedules;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataAdapter sdaSchedules = new SqlDataAdapter(cmdSchedules);
                DataSet dsSchedules = new DataSet("CoursesSet");

                sdaSchedules.Fill(dsSchedules);
                dgvCoursesSchedules.DataSource = dsSchedules.Tables[0];

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CoursesSchedules_Load(object sender, EventArgs e)
        {
            ShowCoursesSchedules();
        }
    }
}
