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
    public partial class AverageGrade : Form
    {
        public AverageGrade()
        {
            InitializeComponent();
        }

        public string SetAverageSchoolarship
        {
            set
            {
                this.ScholarShipLabel.Text = value;
            }
        }
        public string SetAverageEuroSchoolarship
        {
            set
            {
                this.EuroSchoolarShipLabel.Text = value;
            }
        }
        public string SetCourseAverage
        {
            set
            {
                this.CourseLabel.Text = value;
            }
        }

        private void SSLabel_Click(object sender, EventArgs e)
        {

        }

        private void AverageGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
