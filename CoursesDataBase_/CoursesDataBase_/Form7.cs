using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursesDataBase_
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudQueryButton' table. You can move, or remove it, as needed.
            this.studQueryButtonTableAdapter.Fill(this.dataSet1.StudQueryButton);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillByStudCourseToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studQueryButtonTableAdapter.FillByStudCourse(this.dataSet1.StudQueryButton);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.studQueryButtonTableAdapter.FillByStudCourse(this.dataSet1.StudQueryButton);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void serachStudCourseToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studQueryButtonTableAdapter.SerachStudCourse(this.dataSet1.StudQueryButton, iDStudentToolStripTextBox.Text, fullNameToolStripTextBox.Text, idlistToolStripTextBox.Text, idCourseToolStripTextBox.Text, coursetTitleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
