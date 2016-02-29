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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TeacherLearnOn' table. You can move, or remove it, as needed.
            this.teacherLearnOnTableAdapter.Fill(this.dataSet1.TeacherLearnOn);

        }

        private void fillByZapovnToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherLearnOnTableAdapter.FillByZapovn(this.dataSet1.TeacherLearnOn);
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherLearnOnTableAdapter.FillByZapovn(this.dataSet1.TeacherLearnOn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchingTCToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherLearnOnTableAdapter.SearchingTC(this.dataSet1.TeacherLearnOn, idTeacherToolStripTextBox.Text, fullNameToolStripTextBox.Text, idCourseToolStripTextBox.Text, coursetTitleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
