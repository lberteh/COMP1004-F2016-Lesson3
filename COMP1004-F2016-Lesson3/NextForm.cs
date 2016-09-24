using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson3
{
    public partial class NextForm : Form
    {
        // Declare a property that has the shape of the previows form
        public StartForm previousForm { get; set; }
        public NextForm()
        {
            InitializeComponent();
        }

        private void NextForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }


        private void NextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Show();
        }
    }
}
