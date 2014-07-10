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
    public partial class AdminProfessorsTable : Form
    {
        public AdminProfessorsTable()
        {
            InitializeComponent();
        }

        private void professorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentSystemDB);

        }

        private void AdminProfessorsTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentSystemDB.Professors' table. You can move, or remove it, as needed.
            this.professorsTableAdapter.Fill(this.studentSystemDB.Professors);

        }

        private void SearchProfessorTextBox_TextChanged(object sender, EventArgs e)
        {
            professorsBindingSource.Filter = @"LastName like" + "'" + this.SearchProfessorTextBox.Text + "%'";
        }

        private void SearchProfessorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
