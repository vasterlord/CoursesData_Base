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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet1.Students); 
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.studentsBindingSource.CancelEdit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillByStudent(this.dataSet1.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByStudentToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillByStudent(this.dataSet1.Students);
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

        private void searchingStudentsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.SearchingStudents(this.dataSet1.Students, idStudentToolStripTextBox.Text, fullNameToolStripTextBox.Text, passportToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void coursesOfStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormNameStudyingCourse = new Form7();
            FormNameStudyingCourse.ShowDialog();
        }
    }
}
