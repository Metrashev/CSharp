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
    public partial class AdminExamsTable : Form
    {
        public AdminExamsTable()
        {
            InitializeComponent();

        }

        private void FillGrid()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Exams", con);
            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        DataTable ExTable = new DataTable();
                        ExTable.Load(reader);
                        this.AdminExamGrid.DataSource = ExTable;
                    }
                }
            }
        }
        private void AdminExamsTable_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void DeleteExamButton_Click(object sender, EventArgs e)
        {

            DateTime CurrentDate = (DateTime)AdminExamGrid.CurrentRow.Cells[0].Value;
            string CurrentDateStr = CurrentDate.ToString("yyyy-MM-dd");
            string CurrentStudent = AdminExamGrid.CurrentRow.Cells[1].Value.ToString();
            string CurrentProfessor = AdminExamGrid.CurrentRow.Cells[2].Value.ToString();

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM Exams WHERE ExamDate = @ExDate AND StudentID = @StID AND ProfessorID = @PrID; SELECT * FROM Exams ", con);
            cmd.Parameters.AddWithValue("@ExDate", CurrentDateStr);
            cmd.Parameters.AddWithValue("@StID", CurrentStudent);
            cmd.Parameters.AddWithValue("@PrID", CurrentProfessor);
            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Записът е успешно изтрит");
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        DataTable ExTable = new DataTable();
                        ExTable.Load(reader);
                        this.AdminExamGrid.DataSource = ExTable;
                    }
                }
            }
        }

        private void ExamUpdateButton_Click(object sender, EventArgs e)
        {
            DateTime CurrentDate = (DateTime)AdminExamGrid.CurrentRow.Cells[0].Value;
            string CurrentDateStr = CurrentDate.ToString("yyyy-MM-dd");
            string CurrentStudent = AdminExamGrid.CurrentRow.Cells[1].Value.ToString();
            string CurrentProfessor = AdminExamGrid.CurrentRow.Cells[2].Value.ToString();
            string CurrentGrade = AdminExamGrid.CurrentRow.Cells[3].Value.ToString();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Exams SET Grade = @StGrade WHERE ExamDate = @ExDate AND StudentID = @StID AND ProfessorID = @PrID; SELECT * FROM Exams ", con);
            cmd.Parameters.AddWithValue("@ExDate", CurrentDateStr);
            cmd.Parameters.AddWithValue("@StID", CurrentStudent);
            cmd.Parameters.AddWithValue("@PrID", CurrentProfessor);
            cmd.Parameters.AddWithValue("@StGrade", CurrentGrade);
            con.Open();

            using (con)
            {
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Промените бяха направени успешно !");
                    using (reader)
                    {
                        if (reader.HasRows)
                        {
                            DataTable ExTable = new DataTable();
                            ExTable.Load(reader);
                            this.AdminExamGrid.DataSource = ExTable;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Невалидни данни за обновяване !");
                }


            }
        }

        private void ExamInsertButton_Click(object sender, EventArgs e)
        {
            DateTime CurrentDate = (DateTime)AdminExamGrid.CurrentRow.Cells[0].Value;
            string CurrentDateStr = CurrentDate.ToString("yyyy-MM-dd");
            string CurrentStudent = AdminExamGrid.CurrentRow.Cells[1].Value.ToString();
            string CurrentProfessor = AdminExamGrid.CurrentRow.Cells[2].Value.ToString();
            string CurrentGrade = AdminExamGrid.CurrentRow.Cells[3].Value.ToString();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Exams VALUES (@ExDate, @StID, @PrID, @StGrade); SELECT * FROM Exams", con);
            cmd.Parameters.AddWithValue("@ExDate", CurrentDateStr);
            cmd.Parameters.AddWithValue("@StID", CurrentStudent);
            cmd.Parameters.AddWithValue("@PrID", CurrentProfessor);
            cmd.Parameters.AddWithValue("@StGrade", CurrentGrade);
            con.Open();

            using (con)
            {
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Записът е добавен успешно");
                    using (reader)
                    {
                        if (reader.HasRows)
                        {
                            DataTable ExTable = new DataTable();
                            ExTable.Load(reader);
                            this.AdminExamGrid.DataSource = ExTable;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Невалиден запис за добавяне !");
                }


            }
        }

        private void ExamSearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            string SearchCommand = "SELECT * FROM Exams ";
            SqlCommand cmd = new SqlCommand(SearchCommand, con);
            if (this.StudentCheck.Checked && this.ProfessorCheck.Checked)
            {
                SearchCommand += "WHERE StudentID = @StID AND ProfessorID = @PrID";
                cmd = new SqlCommand(SearchCommand, con);
                cmd.Parameters.AddWithValue("@StID", this.SearchByStudentBox.Text);
                cmd.Parameters.AddWithValue("@PrID", this.SearchByProfessorBox.Text);
            }
            else
            {
                if (this.StudentCheck.Checked)
                {
                    SearchCommand += "WHERE StudentID = @StID";
                    cmd = new SqlCommand(SearchCommand, con);
                    cmd.Parameters.AddWithValue("@StID", this.SearchByStudentBox.Text);
                }

                if (this.ProfessorCheck.Checked)
                {
                    SearchCommand += "WHERE ProfessorID = @PrID";
                    cmd = new SqlCommand(SearchCommand, con);
                    cmd.Parameters.AddWithValue("@PrID", this.SearchByProfessorBox.Text);
                }
            }

            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        DataTable ExTable = new DataTable();
                        ExTable.Load(reader);
                        this.AdminExamGrid.DataSource = ExTable;
                    }
                }
            }
            

        }

    }
}
