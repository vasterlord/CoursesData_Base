﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common; 

namespace CoursesDataBase_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();            
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormNameAboutProgram = new Form2();
            FormNameAboutProgram.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormNameStudents = new Form3();
            FormNameStudents.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FormNameTeachers = new Form4();
            FormNameTeachers.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form FormNameCourses = new Form5();
            FormNameCourses.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form FormNameStudyingList  = new Form6();
            FormNameStudyingList .ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

                if (textBox1.Text == "123456")
                {
                    aboutProgramToolStripMenuItem.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                else  
                {
                    MessageBox.Show(" Wrong password. Please, enter your password again ", " Important message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
        }
    }
}
