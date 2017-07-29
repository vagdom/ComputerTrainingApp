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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void ShowEmployees()
        {
            using (SqlConnection scComputerTrainingCenter =
                    new SqlConnection("Data Source=(local);" +
                                  "Database='ComputerTrainingCenter1';" +
                                  "Integrated Security=Yes"))
            {
                // Sorry for this situation. We are going to use a sub-query although we haven't studied them.
                SqlCommand cmdEmployees =
                    new SqlCommand("SELECT empls.EmployeeNumber [Empl #], " +
                                   "       empls.FirstName [First Name], " +
                                   "       empls.LastName [Last Name], " +
                                   "       empls.Title [Title], " +
                                   "       (SELECT CONCAT(managers.EmployeeNumber, N' - ', managers.EmployeeName) " +
                                   "        FROM Administration.Employees managers " +
                                   "       WHERE managers.EmployeeNumber = empls.Supervisor) Manager, " +
                                   "       depts.Department " +
                                   "FROM Administration.Employees empls " +
                                   "	 INNER JOIN Administration.Departments depts " +
                                   "    	ON empls.DeptCode = depts.DeptCode;",
                                   scComputerTrainingCenter);
                scComputerTrainingCenter.Open();

                SqlDataAdapter sdaEmployees = new SqlDataAdapter(cmdEmployees);
                DataSet dsEmployees = new DataSet("DepartmentsSet");

                sdaEmployees.Fill(dsEmployees);
               
                dgvEmployees.DataSource = dsEmployees.Tables[0];
                dgvEmployees.Columns[5].Width = 200;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            ShowEmployees();
        }
    }
}
