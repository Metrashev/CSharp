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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void ExitAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginAdminButton_Click(object sender, EventArgs e)
        {
            string Pass = this.PassAdminTextBox.Text;
            if (Pass.Equals("1111"))
            {
                AdminOperationContainer AdminContainer = new AdminOperationContainer();
                AdminContainer.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Невалидна парола !");
            }
            
        }
    }
}
