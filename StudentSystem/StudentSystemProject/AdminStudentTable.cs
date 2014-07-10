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
    public partial class AdminStudentTable : Form
    {
        public AdminStudentTable()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentSystemDB);

        }

        private void AdminStudentTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentSystemDB.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentSystemDB.Students);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (this.FnRadio.Checked)
            {
                try
                {
                    int StID = int.Parse(this.SearchStudentTextBox.Text);
                    studentsBindingSource.Filter = "StudentID=" + "'" + StID + "'";
                }
                catch
                {
                    if (this.SearchStudentTextBox.Text == "")
                    {
                        studentsBindingSource.RemoveFilter();
                    }
                    else
                    {
                        MessageBox.Show("Невалиден факутетен номер !");
                    }
                }
            }
            if (this.IdRadio.Checked)
            {
                studentsBindingSource.Filter = @"PersonalNumber like" + "'" + this.SearchStudentTextBox.Text + "%'";
            }
        }
    }
}
