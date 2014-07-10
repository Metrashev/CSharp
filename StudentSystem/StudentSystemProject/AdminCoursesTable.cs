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
    public partial class AdminCoursesTable : Form
    {
        public AdminCoursesTable()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentSystemDB);

        }

        private void AdminCoursesTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentSystemDB.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentSystemDB.Courses);

        }

        private void SearchCoursesTextBox_TextChanged(object sender, EventArgs e)
        {
            coursesBindingSource.Filter = @"CourseName like" + "'%" + this.SearchCoursesTextBox.Text + "%'";
        }

        private void courseIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
