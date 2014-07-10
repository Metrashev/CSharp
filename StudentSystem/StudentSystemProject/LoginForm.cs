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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT StudentID FROM Students WHERE StudentID = @studentID AND StPassword = @stPassword", con);
            string fnumber = this.FNumberTextBox.Text;
            string pass = this.PassTextBox.Text;

            cmd.Parameters.AddWithValue("@studentID", fnumber);
            cmd.Parameters.AddWithValue("@stPassword", pass);
            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Не сте въвели или е грешен факултетния номер и/или паролата !");
                    }
                    else 
                    {
                        StudentBasicData studentForm = new StudentBasicData();
                        studentForm.SetFacultyNumber = this.FNumberTextBox.Text;
                        studentForm.Show();
                        this.Hide();

                    }

                }

            }
         
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterAdminButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLog = new AdminLogin();
            adminLog.Show();
            this.Hide();
          
        }
    }
}

