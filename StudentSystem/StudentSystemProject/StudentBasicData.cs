using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemProject
{
    public partial class StudentBasicData : Form
    {
        public StudentBasicData()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string SetFacultyNumber
        {
            set
            {
                this.FacultyNuberLabel.Text = value;
            }
        }


        private void StudentBasicData_Load(object sender, EventArgs e)
        {
            string fnumber = this.FacultyNuberLabel.Text;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students s JOIN Specialities sp ON s.SpecialityID = sp. SpecialityID WHERE StudentID = @studentID", con);

            cmd.Parameters.AddWithValue("@studentID", fnumber);

            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    reader.Read();
                    string FirstName = (string)reader["FirstName"];
                    string FamilyName = (string)reader["LastName"];
                    string PersonID = (string)reader["PersonalNumber"];
                    DateTime date = new DateTime();
                    date = (DateTime)reader["BirthDate"];
                    string BirthDate = date.ToString("dd-MM-yyyy");
                    string EducationForm = (string)reader["EducationForm"];
                    string Speciality = reader["SpecialityName"].ToString();

                    this.NameLabel.Text = FirstName;
                    this.LastNameLabel.Text = FamilyName;
                    this.EGNLabel.Text = PersonID;
                    this.BirthDateLabel.Text = BirthDate;
                    this.EducationFormLabel.Text = EducationForm;
                    this.SpecialityLabel.Text = Speciality;
                }

            }
        }

        private void OpenGradeButton_Click(object sender, EventArgs e)
        {
            GradeForm Grades = new GradeForm();

            string fnumber = this.FacultyNuberLabel.Text;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT e.ExamDate AS [Дата на изпит], p.FirstName + ' ' + p.LastName AS [Име на преподавател], c.CourseName AS [Дисциплина], e.Grade AS [Оценка] FROM Exams e JOIN Students s ON e.StudentID = s.StudentID JOIN Professors p ON e.ProfessorID = p.ProfessorID JOIN Courses c ON p.CourseID = c.CourseID WHERE s.StudentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", fnumber);
            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable GradesTable = new DataTable();
                    GradesTable.Load(reader);
                    GradeForm form = new GradeForm();
                    form.SetTableData = GradesTable;
                    form.Show();
                }
            }
        }

        private void OpenAverageGradeButton_Click(object sender, EventArgs e)
        {
            string fnumber = this.FacultyNuberLabel.Text;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT avg(e.Grade) AS [Average] FROM Exams e JOIN Students s ON e.StudentID = s.StudentID GROUP BY s.StudentID HAVING s.StudentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", fnumber);

            SqlCommand cmd2 = new SqlCommand("SELECT avg(e.Grade) AS [Average] FROM Exams e JOIN Students s ON e.StudentID = s.StudentID GROUP BY s.StudentID, YEAR(e.ExamDate) HAVING s.StudentID = @studentID AND YEAR(e.ExamDate) = 2012", con);
            cmd2.Parameters.AddWithValue("@studentID", fnumber);

            con.Open();
            AverageGrade avgForm = new AverageGrade();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        
                        decimal AverageGrade = Math.Round((decimal)reader["Average"], 2);
                        avgForm.SetAverageSchoolarship = AverageGrade.ToString();
                        avgForm.SetAverageEuroSchoolarship = AverageGrade.ToString();
                    }
                }

                SqlDataReader reader2 = cmd2.ExecuteReader();
                using (reader2)
                {
                    if (reader2.HasRows)
                    {
                        reader2.Read();
                        decimal AverageGrade = Math.Round((decimal)reader2["Average"],2);
                        avgForm.SetCourseAverage = AverageGrade.ToString();
                    }
                }
            }

            avgForm.Show();
        }

        private void StudentBasicData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

