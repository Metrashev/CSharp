using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemProject
{
    public partial class AdminOperationContainer : Form
    {
        public AdminOperationContainer()
        {
            InitializeComponent();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProfessorsTable AdmPrTable = new AdminProfessorsTable();
            AdmPrTable.MdiParent = this;
            AdmPrTable.Show();
        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminStudentTable AdmStTable = new AdminStudentTable();
            AdmStTable.MdiParent = this;
            AdmStTable.Show();
        }

        private void учебниДисциплиниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminCoursesTable AdmCorTable = new AdminCoursesTable();
            AdmCorTable.MdiParent = this;
            AdmCorTable.Show();
        }

        private void изпитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminExamsTable AdmExTable = new AdminExamsTable();
            AdmExTable.MdiParent = this;
            AdmExTable.Show();

        }

        private void специалностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSpecialitiesTable AdmSpecTable = new AdminSpecialitiesTable();
            AdmSpecTable.MdiParent = this;
            AdmSpecTable.Show();
        }

        private void AdminOperationContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
