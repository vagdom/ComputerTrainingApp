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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void ShowStudents()
        {
            using (SqlConnection scComputerTrainingCenter =
                    new SqlConnection("Data Source=(local);" +
                                  "Database='ComputerTrainingCenter1';" +
                                  "Integrated Security=Yes"))
            {
                SqlCommand cmdStudents =
                    new SqlCommand("SELECT std.StudentID     [Std ID], " +
                                   "       std.StudentNumber [Std #], " +
                                   "       std.FirstName     [First Name], " +
                                   "       std.MiddleName    [Middle Name], " +
                                   "       std.LastName      [Last Name], " +
                                   "       std.StudentName   [Student Name], " +
                                   "       std.PhoneNumber   [Phone #], " +
                                   "       std.EmailAddress  [Email Address] " +
                                   "FROM   Administration.Students std;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataAdapter sdaStudents = new SqlDataAdapter(cmdStudents);
                DataSet dsStudents = new DataSet("StudentsSet");

                sdaStudents.Fill(dsStudents);
                dgvStudents.DataSource = dsStudents.Tables[0];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }
    }
}
