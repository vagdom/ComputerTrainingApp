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
    public partial class CourseNew : Form
    {
        public CourseNew()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            txtCourseCode.Text = "";
            txtCourseName.Text = "";

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
                    cbxCourseLevels.Items.Add(sdrCourseLevels[0].ToString());
                }
            }

            txtDescription.Text = "";
        }


        private void CourseNew_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        
    }
}
