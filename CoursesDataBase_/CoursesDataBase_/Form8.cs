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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TeachCourse' table. You can move, or remove it, as needed.
            this.teachCourseTableAdapter.Fill(this.dataSet1.TeachCourse);

        }

        private void fillByTeacherCoursesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachCourseTableAdapter.FillByTeacherCourses(this.dataSet1.TeachCourse);
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
                this.teachCourseTableAdapter.FillByTeacherCourses(this.dataSet1.TeachCourse);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachCourseTableAdapter.FillBy(this.dataSet1.TeachCourse, idTeacherToolStripTextBox.Text, fullNameToolStripTextBox.Text, idCourseToolStripTextBox.Text, coursetTitleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
