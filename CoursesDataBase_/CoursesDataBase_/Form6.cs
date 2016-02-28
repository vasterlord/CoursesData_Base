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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void listOfStudyingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listOfStudyingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void listOfStudyingBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.listOfStudyingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet1.Students);
            // TODO: This line of code loads data into the 'dataSet1.TeachShort' table. You can move, or remove it, as needed.
            this.teachShortTableAdapter.Fill(this.dataSet1.TeachShort);
            // TODO: This line of code loads data into the 'dataSet1.StudentsShort' table. You can move, or remove it, as needed.
            this.studentsShortTableAdapter.Fill(this.dataSet1.StudentsShort);
            // TODO: This line of code loads data into the 'dataSet1.ListOfStudying' table. You can move, or remove it, as needed.
            this.listOfStudyingTableAdapter.Fill(this.dataSet1.ListOfStudying);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.listOfStudyingBindingSource.CancelEdit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchListStudyingToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.listOfStudyingTableAdapter.SearchListStudying(this.dataSet1.ListOfStudying, idlistToolStripTextBox.Text, idCourseToolStripTextBox.Text, idStudentToolStripTextBox.Text, idTeacherToolStripTextBox.Text);
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
                this.listOfStudyingTableAdapter.FillByList(this.dataSet1.ListOfStudying);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }         
        }
    }

       
}
