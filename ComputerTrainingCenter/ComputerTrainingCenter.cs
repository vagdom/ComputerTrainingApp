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
    public partial class ComputerTrainingCenter : Form
    {
        public ComputerTrainingCenter()
        {
            InitializeComponent();
        }

        private void CreateDatabase()
        {
            // Here We Go

            using (SqlConnection cntComputerTrainingCenter =
                            new SqlConnection("Data Source=(local);Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("IF  EXISTS ( " +
                                                        "      SELECT name " +
                                                        "		FROM sys.databases " +
                                                        "		WHERE name = N'ComputerTrainingCenter1' " +
                                                        ")" +
                                                        "DROP DATABASE ComputerTrainingCenter1; " +
                                                        "CREATE DATABASE ComputerTrainingCenter1;",
                                   cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();

                MessageBox.Show("The ComputerTrainingCenter1 database has been created.",
                                "Computer Training Center",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE SCHEMA Administration;", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }

            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE SCHEMA Academics;", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }

            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Academics.CourseLevels " +
                                                        "( " +
                                                        "	CourseLevel nvarchar(20) not null, " +
                                                        "	Notes nvarchar(max), " +
                                                        "	Constraint PK_CourseLevels Primary Key(CourseLevel) " +
                                                        ");", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }
            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Academics.Courses " +
                                                        "( " +
                                                        "	CourseCode nvarchar(10) not null, " +
                                                        "	CourseName nvarchar(60) not null, " +
                                                        "	CourseLevel nvarchar(20), " +
                                                        "	Notes nvarchar(max), " +
                                                        "	Constraint PK_Courses Primary Key(CourseCode), " +
                                                        "	Constraint FK_CourseLevels Foreign Key(CourseLevel) References Academics.CourseLevels(CourseLevel) " +
                                                        ");", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }
            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Administration.Students " +
                                                        "( " +
                                                        "    StudentID	   int identity(1, 1), " +
                                                        "    StudentNumber nvarchar(10) not null, " +
                                                        "    FirstName     nvarchar(25), " +
                                                        "    MiddleName    nvarchar(25), " +
                                                        "    LastName      nvarchar(25), " +
                                                        "    StudentName   AS CONCAT(LastName, N', ', FirstName), " +
                                                        "    PhoneNumber   nvarchar(20), " +
                                                        "    EmailAddress  nvarchar(50), " +
                                                        "    Constraint PK_Students Primary Key(StudentNumber) " +
                                                        ");", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }
            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Administration.Teachers " +
                                                        "( " +
                                                        "    TeacherID	   int identity(1, 1), " +
                                                        "    TeacherNumber nchar(7) not null, " +
                                                        "    FirstName	   nvarchar(25), " +
                                                        "    MiddleName	   nvarchar(25), " +
                                                        "    LastName	   nvarchar(25), " +
                                                        "    TeacherName   AS CONCAT(LastName, N', ', FirstName), " +
                                                        "    StartDate	   date, " +
                                                        "    PhoneNumber   nvarchar(20), " +
                                                        "    EmailAddress  nvarchar(50), " +
                                                        "    Constraint PK_Teachers Primary Key(TeacherNumber) " +
                                                        ");", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }
            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Academics.CoursesSchedules " +
                                                        "( " +
                                                        "	ScheduleID    int identity(1, 1), " +
                                                        "	CourseCode    nvarchar(10), " +
                                                        "	TeacherNumber nchar(7), " +
                                                        "	DaysTaught    nvarchar(20), " +
                                                        "   	TimeTaught    nvarchar(20), " +
                                                        "	StartDate     date, " +
                                                        "	EndDate	      date, " +
                                                        "	RoomNumber    nvarchar(10), " +
                                                        "	Constraint PK_CoursesSchedules Primary Key(ScheduleID), " +
                                                        "	Constraint FK_CoursesCodesSchedules Foreign Key(CourseCode) References Academics.Courses(CourseCode), " +
                                                        "	Constraint FK_CoursesTeachers Foreign Key(TeacherNumber) References Administration.Teachers(TeacherNumber) " +
                                                        ");", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }

            //
            //
            //
            using (SqlConnection cntComputerTrainingCenter =
            new SqlConnection("Data Source=(local);" +
                               "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Administration.Departments " +
                                                        "( " +
                                                        "	DeptCode   nchar(5) not null, " +
                                                        "	Department nvarchar(50), " +
                                                        "   Manager    nchar(10), " +
                                                        "	Constraint PK_Departments Primary Key(DeptCode) " +
                                                        "); " +
                                                        "CREATE TABLE Administration.Employees " +
                                                        "( " +
                                                        "	EmployeeID        int identity(1, 1), " +
                                                        "	EmployeeNumber nchar(10) not null, " +
                                                        "	FirstName nvarchar(25), " +
                                                        "	LastName nvarchar(25), " +
                                                        "	EmployeeName AS CONCAT(LastName, N', ', FirstName), " +
                                                        "	Title nvarchar(50), " +
                                                        "   ManagerID         int, " +
                                                        "	HourlySalary      money, " + 
                                                        "	Supervisor nchar(7) null, " +
                                                        "	DeptCode nchar(5), " +
                                                        "	Constraint PK_Employees Primary Key(EmployeeNumber), " +
                                                        "	Constraint FK_Departments Foreign Key(DeptCode) " +
                                                        "		References Administration.Departments(DeptCode) " +
                                                        ");",
                                                        cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();

                MessageBox.Show("The Departments and the Employees tables have been added to the ComputerTrainingCenter1 database.",
                                "Computer Training Center",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            ///
            ///Delete this and add managerID to the create statement above
            ///
            /*
            MessageBox.Show("here..");
            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Administration.Employees " +
                                                        "( " +
                                                        "	EmployeeID        int identity(1, 1), " +
                                                        "	EmployeeNumber    nchar(10) not null, " +
                                                        "	FirstName         nvarchar(20), " +
                                                        "	LastName          nvarchar(20) not null, " +
                                                        "   Title             nvarchar(50), " +
                                                        "   ManagerID         int  Constraint FK_Employees References Administration.Employees(EmployeeID), " +                                                          
                                                        "	HourlySalary      money, " +
                                                        "	Constraint PK_Employees Primary Key(EmployeeID)" + 
                                                        ");", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }

    */

              
            //Create Enrollment Table
            ///// Here
            using (SqlConnection cntComputerTrainingCenter =
                 new SqlConnection("Data Source=(local);" +
                                    "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Academics.Enrollments " +
                                                        "( " +
                                                        "	EnrollmentID        int identity(1, 1), " +
                                                        "	StudentNumber       nvarchar(10) not null, " +
                                                        "	ScheduleID          int, " +
                                                         "	Constraint PK_Enrollments Primary Key(EnrollmentID)," +
                                                        "   Constraint FK_StudentsEnrolled Foreign Key(StudentNumber) References Administration.Students(StudentNumber), " +
                                                        "	Constraint FK_SchedulesEnrollments Foreign Key(ScheduleID) References Academics.CoursesSchedules(ScheduleID) " +
                                                       
                                                        ");", cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();
            }






            //////////////////////////////////////////////
            // GENERATE DATA                            //
            //////////////////////////////////////////////
            using (SqlConnection cntComputerTrainingCenter =
                new SqlConnection("Data Source=(local);" +
                                   "Database='ComputerTrainingCenter1';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("INSERT INTO Academics.CourseLevels " +
                                                        "VALUES(N'Beginning', N'This is an introductory class for which the student is not supposed to know anything about the subject.'), " +
                                                        "      (N'Intermediate', N'The student is supposed to be familiar with introductory material. Some parts are used as a refresher. Some some other parts, it is assumed that the student meets the necessary pre-requisites.'), " +
                                                        "      (N'Advanced', N'This level is for those who master the fundamentals and need knowledge beyond the regular use of the application.'); " +
                                                        "INSERT INTO Academics.Courses " +
                                                        "VALUES(N'BGNKBD', N'Introduction to Keyboarding', N'Beginning', N'The course assumes no heavy use of the computer keyboard. The, student will be introduced to the keys on the keyboard, the categories of letters, and the special keys.'), " +
                                                        "      (N'BGNWDP', N'Introduction to Text and Word Processing', N'Beginning', N'This is an introduction to all types of text manipulations, including text styles, the various characteristics of paragraphs, fonts, and paging. This course assumes no prior knowledge of word processing. Still, the student is supposed to be familiar with computers, namely the use of the keyboard, the mouse, the objects on the screen, and basic ways to use text.'), " +
                                                        "      (N'BGNSPS', N'Introduction to Electronic Spreadsheets', N'Beginning', N'This course introduces the students to paper and electronic spreadsheets, the use of columns, rows, and cells. This course assumes no prior knowledge of spreadsheets or computer calculations. The student is supposed to be familiar with computers, namely the use of the keyboard, the mouse, and the objects on the screen.'), " +
                                                        "      (N'BGNPRS', N'Introduction to Computer Presentations', N'Beginning', N'This course assumes no prior knowledge of presentations using the computer. The student will learn how to create slides and apply aesthetic features to text. Applications used are Google Presentation, Microsoft PowerPoint, and OpenOffice.org.'); " +
                                                        "INSERT INTO Academics.Courses(CourseCode, CourseName, CourseLevel) " +
                                                        "VALUES(N'BGNMKT', N'Introduction to Marketing', N'Beginning'); " +
                                                        "INSERT INTO Academics.Courses " +
                                                        "VALUES(N'BGNRSC', N'Introduction to Research', N'Beginning', N'This course presents different types of research, including paper and the Web. Techniques of writing scholar papers, quoting, and creating references are reviewed.'); " +
                                                        "INSERT INTO Academics.Courses(CourseCode, CourseName, CourseLevel) " +
                                                        "VALUES(N'BGNSMB', N'Starting a Small Business', N'Beginning'); " +
                                                        "INSERT INTO Academics.Courses " +
                                                        "VALUES(N'BGNWDS', N'Introduction to Web Design', N'Beginning', N'This course introduces the student to the web, the concept of a web site, the appearance and layout of a web page, and a critique to web sites. The student is then introduced to HTML and other scripting languages with light (minimal) programming.'), " +
                                                        "      (N'BGNDBS', N'Introduction to Computer Databases', N'Beginning', N'This course introduces the students to difference types of computer databases, including historical paper spreadsheets, electronic spreadsheets, and desktop databases. After the introduction, the student will start creating databases. The exercises are done using Microsoft Access, Oracle Express, Microsoft SQL Server Express, and MySQL.'), " +
                                                        "      (N'BGNGRD', N'Introduction to Graphic Design', N'Beginning', N'This course introduces the student to various modern means of creating graphics, including paper and electronic. The student will learn to use create own graphics, to use own pictures, to use other pictures, and to manipulate all types of graphics in the environment.'), " +
                                                        "      (N'NTMKBD', N'Intermediate Keyboarding', N'Intermediate', N'This is a continuation to introduction to keyboarding. The student must be familiar with the keyboard to know the letter-based keys, the positions of the control, shift, and other special keys. The student will learn to type fast.'), " +
                                                        "      (N'NTMWDP', N'Intermediate Word Processing', N'Intermediate', N'This course teaches advanced techniques of producing text to create industrial papers. The student will get familiar with various features of Microsoft Word, WordPerfect, and OpenOffice.org Writer, including embedding objects, performing calculations in tables, etc.'), " +
                                                        "      (N'NTMPRS', N'Intermediate and Graphic Presentations', N'Intermediate', N'This course advances the techniques of delivering a presentation, including optical media presentation, screen recording and production, tutorial productions, and web presentation.'), " +
                                                        "      (N'NTMSPS', N'Spreadsheets and Data Analysis', N'Intermediate', N'This course presents various ways of using statistics, functions, graphs, and other techniques of electronically analyzing data. Macros and programming are introduced.'); " +
                                                        "INSERT INTO Academics.Courses(CourseCode, CourseName, CourseLevel) " +
                                                        "VALUES(N'NTMSMB', N'Running and Growing a Small Business', N'Intermediate'); " +
                                                        "INSERT INTO Academics.Courses " +
                                                        "VALUES(N'NTMDBS', N'Database Design and Implementation', N'Intermediate', N'In this course, the student will learn to create a complete database, distribute, and maintain it. Intermediate to advanced techniques of using the SQL are used to further create and manipulate queries.'), " +
                                                        "      (N'NTMGRD', N'Intermediate Graphic Design', N'Intermediate', N'This course shows various ways of using both traditional (static) graphics and animations. The course also including sessions on advanced photo manipulation, commercial billboards, and TV announcements.'); " +
                                                        "INSERT INTO Academics.Courses(CourseCode, CourseName, CourseLevel) " +
                                                        "VALUES(N'NTMMKT', N'Marketing and New Technologies', N'Intermediate'); " +
                                                        "INSERT INTO Academics.Courses " +
                                                        "VALUES(N'NTMWDS', N'Introduction to Web Development', N'Advanced', N'In this course, the student will create, publish, and maintain a web site accessed from the Internet. The student will also learn to create interactive web sites using a scripting language such as PHP and a database such as MySQL and/or Microsoft Access.'), " +
                                                        "      (N'ADVGRD', N'Advanced Graphic Design and Production', N'Advanced', N'In this course, the student will learn to produce industrial graphics for advertisement, both paper and TV. The student will also learn to create short animations, using static pictures, moving objects, and film.'), " +
                                                        "      (N'ADVWDP', N'Advanced Word Processing and Publishing', N'Advanced', N'This course is for people who use Microsoft Word intensely, such as in a production environment. The student will learn to produce business papers, catalogues, and newspapers. The student will also learn how Microsoft Word can interact with other aplications.'), " +
                                                        "      (N'ADVDBS', N'Databases Distribution and Maintenance', N'Advanced', N'This course introduces database production in a distribution or network environment. Enterprise databases are reviewed, including Oracle, Microsoft SQL Server, and IBM DB2 are explored. Client/Server applications and enterprise connectivity are also reviewed.'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'290-80-249', N'Rose', N'Marie', N'Hobson', N'202-208-0058', N'hobbiesrus@yaho.com'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName, PhoneNumber) " +
                                                        "VALUES(N'805-15-691', N'Ayodele	', N'Adegbosun', N'703-203-1405'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'402-48-885', N'Laura', N'Claire', N'Wayne'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, EmailAddress) " +
                                                        "VALUES(N'280-14-513', N'Kimberly', N'Danielle', N'Barnett', N'kimbarnett@juniorland.com'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'108-24-972', N'Meghan', N'Brawer'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName, PhoneNumber) " +
                                                        "VALUES(N'481-85-913', N'Fatima', N'Djouda', N'(301) 701-1583'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'108-96-156', N'Matthew', N'Richard', N'Perez', N'(240) 901-8094', N'myperez@gmail.com'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'393-46-377', N'Joan', N'York'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'681-07-049', N'Faustino', N'Raymondo', N'Castanuela', N'410-928-4795', N'raycasting@att.net'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'186-04-379', N'Judith', N'Wu'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'104-46-624', N'James', N'Arnold', N'Hornett', N'(202) 400-3807', N'jarnett202@hotmail.com'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'183-04-202', N'Patricia', N'Graham'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'179-38-027', N'Jennifer', N'Gabriella', N'Rubenstein'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'208-58-050', N'Patrick', N'Dixon'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'927-40-351', N'Daniel', N'Gibson'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'273-04-775', N'Noëlle', N'Gabrielle', N'Pellotti'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, EmailAddress) " +
                                                        "VALUES(N'574-36-379', N'Laetishia', N'Justine', N'Roberts', N'larobertson@yahoo.com'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'279-97-405', N'James', N'Dixxon'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, PhoneNumber) " +
                                                        "VALUES(N'284-95-006', N'Joshua', N'Gregory', N'Efemba', N'443-394-8275'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'920-92-270', N'Ahmed', N'Khamil', N'240-927-0053', N'roasterman@gmail.com'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'293-74-635', N'Arthur', N'Drewise'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'695-88-473', N'Lynette', N'Michelle', N'Lace', N'(301) 700-8304', N'lazymichelle@gmail.com'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'357-96-927', N'Courtney', N'Jane', N'Kemp'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'842-50-960', N'John', N'Lucas', N'Finelly'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'294-80-275', N'Edward', N'Vasquez'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, LastName) " +
                                                        "VALUES(N'949-29-204', N'Anna', N'Hutchinson'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'296-61-805', N'Mary', N'Danielle', N'Means'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'606-39-722', N'Daniel', N'Lewis', N'Jefferson', N'(301) 806-9300', N'djefferson2@hr.hamaleck.net'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'485-05-940', N'Aaron', N'Paul', N'Fox'); " +
                                                        "INSERT INTO Administration.Students(StudentNumber, FirstName, MiddleName, LastName) " +
                                                        "VALUES(N'530-47-225', N'Erin', N'Joan', N'Spears'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, MiddleName, LastName, StartDate, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'624-633', N'Denise', N'Jane', N'Harrington', N'20110411', N'301-201-8405', N'djharry@hotmail.com'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, MiddleName, LastName, StartDate) " +
                                                        "VALUES(N'264-005', N'William', N'Philippe', N'Melton', N'20101214'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, LastName, StartDate, PhoneNumber,	EmailAddress) " +
                                                        "VALUES(N'726-115', N'Saheed', N'Hussieni', N'26-October-2011', N'240-209-8160', N'husseinis@faculty.mduniv.edu'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, LastName, StartDate, PhoneNumber) " +
                                                        "VALUES(N'420-108', N'Saheer', N'Aliou', N'14-Aug-2009', N'(240) 901-8304'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, MiddleName, LastName, StartDate, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'100-326', N'Joseph', N'Harry', N'Lemeck', N'20101006', N'(202) 208-4135', N'joseph.lemeck@courts.maryland.gov'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, MiddleName, LastName, StartDate) " +
                                                        "VALUES(N'740-925', N'Margareth', N'Felicia', N'Gundlehach', N'04-JAN-2012'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, LastName, StartDate, PhoneNumber, EmailAddress) " +
                                                        "VALUES(N'685-108', N'Joan', N'Tilton', N'20081028', N'703-601-8044', N'jtilton@fairfax.gov'); " +
                                                        "INSERT INTO Administration.Teachers(TeacherNumber, FirstName, MiddleName, LastName, StartDate) " +
                                                        "VALUES(N'292-572', N'Daniel', N'Robert', N'Coppit', N'20120104'); " +
                                                        "INSERT INTO Academics.CoursesSchedules(CourseCode, TeacherNumber, DaysTaught, TimeTaught, StartDate, EndDate, RoomNumber) " +
                                                        "VALUES(N'BGNKBD', N'420-108', N'Mon, Wed', N'1800-2200', N'20120116', N'20120206', N'101'), " +
                                                        "      (N'BGNWDP', N'624-633', N'Mon, Wed', N'1800-2200', N'20120116', N'20120206', N'102'), " +
                                                        "      (N'BGNPRS', N'740-925', N'Mon, Wed', N'1800-2200', N'20120116', N'20120206', N'103'), " +
                                                        "      (N'BGNSPS', N'292-572', N'Mon, Wed', N'1800-2200', N'20120116', N'20120207', N'104'), " +
                                                        "      (N'BGNGRD', N'740-925', N'Tue, Thu', N'1800-2200', N'20120117', N'20120207', N'101'), " +
                                                        "      (N'BGNDBS', N'100-326', N'Tue, Thu', N'1800-2200', N'20120117', N'20120207', N'102'), " +
                                                        "      (N'BGNMKT', N'264-005', N'Tue, Thu', N'1800-2200', N'20120117', N'20120207', N'103'), " +
                                                        "      (N'BGNSMB', N'624-633', N'Tue, Thu', N'1800-2200', N'20120117', N'20120207', N'104'), " +
                                                        "      (N'BGNWDS', N'740-925', N'Sat',      N'0900-1700', N'20120121', N'20120211', N'102'), " +
                                                        "      (N'NTMKBD', N'420-108', N'Mon, Wed', N'1800-2200', N'20120220', N'20120312', N'101'), " +
                                                        "      (N'NTMWDP', N'685-108', N'Mon, Wed', N'1800-2200', N'20120220', N'20120312', N'102'), " +
                                                        "      (N'NTMPRS', N'264-005', N'Mon, Wed', N'1800-2200', N'20120220', N'20120312', N'103'), " +
                                                        "      (N'NTMSPS', N'292-572', N'Mon, Wed', N'1800-2200', N'20120220', N'20120312', N'104'), " +
                                                        "      (N'NTMGRD', N'740-925', N'Tue, Thu', N'1800-2200', N'20120221', N'20120313', N'101'), " +
                                                        "      (N'NTMDBS', N'726-115', N'Tue, Thu', N'1800-2200', N'20120221', N'20120313', N'102'), " +
                                                        "      (N'NTMMKT', N'264-005', N'Tue, Thu', N'1800-2200', N'20120221', N'20120313', N'103'), " +
                                                        "      (N'NTMSMB', N'420-108', N'Tue, Thu', N'1800-2200', N'20120221', N'20120313', N'104'), " +
                                                        "      (N'NTMWDS', N'264-005', N'Sat',      N'0900-1700', N'20120225', N'20120317', N'102'); " +
                                                        "INSERT INTO Administration.Departments(DeptCode, Department, Manager)" +
                                                        "Values(N'11111', N'Department of Engineering', N'249441')," +
                                                        "      (N'33333', N'Department of Computer Science', N'792702');" +
                                                        "INSERT INTO Administration.Employees(EmployeeNumber, FirstName, LastName, Title, ManagerID, HourlySalary, DeptCode)" +
                                                        "VALUES(N'792702', N'Frank', N'Cassini', N'General Manager', 1, 30.25, N'11111')," +
                                                        "      (N'249441', N'Patrick', N'Levine', N'Regional Manager', 1, 28.46, N'11111')," +
                                                        "      (N'302484', N'Catherine', N'Borrow', N'Shift Supervisor', 1, 25.72, N'11111')," +
                                                        "      (N'485052', N'Jerry', N'Fesman', N'Head Cashier', 1, 18.64, N'11111')," +
                                                        "      (N'279475', N'Alex', N'Simkins', N'Intern', 3, 12.48, N'11111')," +
                                                        "      (N'908047', N'Grace', N'McDermott', N'Cashier', 3, 14.72, N'11111')," +
                                                        "      (N'395822', N'Craig', N'Newman', N'IT Support', 2, 20.26, N'11111')," +
                                                        "      (N'381848', N'John', N'Hough', N'Cashier', 3, 13.52, N'11111')," +
                                                        "      (N'300724', N'Matt', N'Kern', N'Accountant', 1, 24.58, N'11111')," +
                                                        "      (N'974115', N'Elsa', N'Steinberg', N'Webmaster', 3, 16.94, N'11111')," +
                                                        "      (N'974005', N'David', N'Miller', N'Intern', 2, 10.48, N'11111')," +
                                                        "      (N'273941', N'Jessica', N'Redding', N'Cashier', 3, 12.63, N'11111');" +
                                                        "INSERT INTO Academics.Enrollments(StudentNumber, ScheduleID) " +
                                                        "VALUES(N'104-46-624',  9), (N'108-96-156',  2), (N'280-14-513',  1), (N'284-95-006',  9), (N'290-80-249',  1), " +
                                                        "      (N'481-85-913',  1), (N'606-39-722',  1), (N'681-07-049',  3), (N'695-88-473',  4), (N'805-15-691',  2), " +
                                                        "      (N'920-92-270',  4), (N'574-36-379',  1), (N'208-58-050',  2), (N'402-48-885',  2), (N'296-61-805',  4), " +
                                                        "      (N'293-74-635',  3), (N'530-47-225',  3), (N'842-50-960',  4), (N'927-40-351',  3), (N'574-36-379',  5), " +
                                                        "      (N'280-14-513',  5), (N'104-46-624',  5), (N'280-14-513', 10), (N'290-80-249', 10), (N'481-85-913', 10), " +
                                                        "      (N'606-39-722', 10), (N'574-36-379', 10), (N'485-05-940',  7), (N'606-39-722',  9), (N'290-80-249',  5), " +
                                                        "      (N'280-14-513',  9), (N'949-29-204',  6), (N'393-46-377',  6), (N'186-04-379',  6), (N'183-04-202',  6), " +
                                                        "      (N'273-04-775',  7), (N'294-80-275',  7), (N'279-97-405',  7), (N'695-88-473', 13), (N'290-80-249',  8), (N'104-46-624', 18), (N'284-95-006', 18), (N'280-14-513', 18), (N'606-39-722', 18), (N'357-96-927',  7), " +
                                                        "      (N'481-85-913',  8), (N'606-39-722',  8), (N'574-36-379',  8), (N'179-38-027',  8), (N'108-96-156', 11), " +
                                                        "      (N'805-15-691', 11), (N'208-58-050', 11), (N'402-48-885', 11), (N'681-07-049', 12), (N'293-74-635', 12), " +
                                                        "      (N'530-47-225', 12), (N'927-40-351', 12), (N'179-38-027', 17), (N'920-92-270', 13), (N'296-61-805', 13), " +
                                                        "      (N'842-50-960', 13), (N'104-46-624', 14), (N'280-14-513', 14), (N'290-80-249', 14), (N'574-36-379', 14), " +
                                                        "      (N'949-29-204', 16), (N'393-46-377', 16), (N'186-04-379', 16), (N'183-04-202', 16), (N'290-80-249', 17), " +                                                        
                                                        "      (N'481-85-913', 17), (N'606-39-722', 17), (N'574-36-379', 17), (N'108-24-972',  4), (N'108-24-972', 6);",
                                                        cntComputerTrainingCenter);

                cntComputerTrainingCenter.Open();
                cmdDatabase.ExecuteNonQuery();

                MessageBox.Show("Preliminary tables and their records have been added to the ComputerTrainingCenter1 database.",
                                "Computer Training Center",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ComputerTrainingCenter_Load(object sender, EventArgs e)
        {
            //CreateDatabase();
        }

        private void btnCoursesSchedules_Click(object sender, EventArgs e)
        {
            CoursesSchedules cs = new CoursesSchedules();
            cs.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
        }

        private void btnEnrollments_Click(object sender, EventArgs e)
        {
            Enrollments enroll = new Enrollments();
            enroll.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            Teachers teach = new Teachers();
            teach.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }
    }
}
