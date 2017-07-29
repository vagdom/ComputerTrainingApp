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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void ShowTeachers()
        {
            using (SqlConnection scComputerTrainingCenter =
                    new SqlConnection("Data Source=(local);" +
                                  "Database='ComputerTrainingCenter1';" +
                                  "Integrated Security=Yes"))
            {
                SqlCommand cmdCourses =
                    new SqlCommand("SELECT TeacherNumber, " +
                                   "       TeacherName Name, " +
                                   "       PhoneNumber Phone, " +
                                   "       EmailAddress Email " +
                                   "FROM Administration.Teachers;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataAdapter sdaCourses = new SqlDataAdapter(cmdCourses);
                DataSet dsCourses = new DataSet("TeachersSet");

                sdaCourses.Fill(dsCourses);
                dgvTeachers.DataSource = dsCourses.Tables[0];

            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            ShowTeachers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
