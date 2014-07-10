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
    public partial class AdminSpecialitiesTable : Form
    {
        public AdminSpecialitiesTable()
        {
            InitializeComponent();
        }

        private void specialitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentSystemDB);

        }

        private void AdminSpecialitiesTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentSystemDB.Specialities' table. You can move, or remove it, as needed.
            this.specialitiesTableAdapter.Fill(this.studentSystemDB.Specialities);

        }

        private void SearchSpecialitiesTextBox_TextChanged(object sender, EventArgs e)
        {
            specialitiesBindingSource.Filter = @"SpecialityName like" + "'%" + this.SearchSpecialitiesTextBox.Text + "%'";
        }
    }
}
