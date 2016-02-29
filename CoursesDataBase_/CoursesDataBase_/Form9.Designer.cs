namespace CoursesDataBase_
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.dataSet1 = new CoursesDataBase_.DataSet1();
            this.teacherLearnOnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherLearnOnTableAdapter = new CoursesDataBase_.DataSet1TableAdapters.TeacherLearnOnTableAdapter();
            this.tableAdapterManager = new CoursesDataBase_.DataSet1TableAdapters.TableAdapterManager();
            this.teacherLearnOnBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.teacherLearnOnDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchingTCToolStrip = new System.Windows.Forms.ToolStrip();
            this.idTeacherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idTeacherToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fullNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fullNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.idCourseToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idCourseToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.coursetTitleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.coursetTitleToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchingTCToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLearnOnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLearnOnBindingNavigator)).BeginInit();
            this.teacherLearnOnBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLearnOnDataGridView)).BeginInit();
            this.searchingTCToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherLearnOnBindingSource
            // 
            this.teacherLearnOnBindingSource.DataMember = "TeacherLearnOn";
            this.teacherLearnOnBindingSource.DataSource = this.dataSet1;
            // 
            // teacherLearnOnTableAdapter
            // 
            this.teacherLearnOnTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CoursesShortTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.ListOfStudyingTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.StudentsShortTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CoursesDataBase_.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherLearnOnBindingNavigator
            // 
            this.teacherLearnOnBindingNavigator.AddNewItem = null;
            this.teacherLearnOnBindingNavigator.BindingSource = this.teacherLearnOnBindingSource;
            this.teacherLearnOnBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teacherLearnOnBindingNavigator.DeleteItem = null;
            this.teacherLearnOnBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.teacherLearnOnBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripButton3});
            this.teacherLearnOnBindingNavigator.Location = new System.Drawing.Point(207, 244);
            this.teacherLearnOnBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teacherLearnOnBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teacherLearnOnBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teacherLearnOnBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teacherLearnOnBindingNavigator.Name = "teacherLearnOnBindingNavigator";
            this.teacherLearnOnBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teacherLearnOnBindingNavigator.Size = new System.Drawing.Size(343, 25);
            this.teacherLearnOnBindingNavigator.TabIndex = 0;
            this.teacherLearnOnBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "&Refresh";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "&Close";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // teacherLearnOnDataGridView
            // 
            this.teacherLearnOnDataGridView.AutoGenerateColumns = false;
            this.teacherLearnOnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherLearnOnDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.teacherLearnOnDataGridView.DataSource = this.teacherLearnOnBindingSource;
            this.teacherLearnOnDataGridView.Location = new System.Drawing.Point(135, 12);
            this.teacherLearnOnDataGridView.Name = "teacherLearnOnDataGridView";
            this.teacherLearnOnDataGridView.Size = new System.Drawing.Size(446, 220);
            this.teacherLearnOnDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdTeacher";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdCourse";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdCourse";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CoursetTitle";
            this.dataGridViewTextBoxColumn4.HeaderText = "CoursetTitle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // searchingTCToolStrip
            // 
            this.searchingTCToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchingTCToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idTeacherToolStripLabel,
            this.idTeacherToolStripTextBox,
            this.fullNameToolStripLabel,
            this.fullNameToolStripTextBox,
            this.idCourseToolStripLabel,
            this.idCourseToolStripTextBox,
            this.coursetTitleToolStripLabel,
            this.coursetTitleToolStripTextBox,
            this.searchingTCToolStripButton});
            this.searchingTCToolStrip.Location = new System.Drawing.Point(-2, 278);
            this.searchingTCToolStrip.Name = "searchingTCToolStrip";
            this.searchingTCToolStrip.Size = new System.Drawing.Size(718, 25);
            this.searchingTCToolStrip.TabIndex = 2;
            this.searchingTCToolStrip.Text = "searchingTCToolStrip";
            // 
            // idTeacherToolStripLabel
            // 
            this.idTeacherToolStripLabel.Name = "idTeacherToolStripLabel";
            this.idTeacherToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.idTeacherToolStripLabel.Text = "&Id teacher:";
            // 
            // idTeacherToolStripTextBox
            // 
            this.idTeacherToolStripTextBox.Name = "idTeacherToolStripTextBox";
            this.idTeacherToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fullNameToolStripLabel
            // 
            this.fullNameToolStripLabel.Name = "fullNameToolStripLabel";
            this.fullNameToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.fullNameToolStripLabel.Text = "&Full name:";
            // 
            // fullNameToolStripTextBox
            // 
            this.fullNameToolStripTextBox.Name = "fullNameToolStripTextBox";
            this.fullNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // idCourseToolStripLabel
            // 
            this.idCourseToolStripLabel.Name = "idCourseToolStripLabel";
            this.idCourseToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.idCourseToolStripLabel.Text = "&Id course:";
            // 
            // idCourseToolStripTextBox
            // 
            this.idCourseToolStripTextBox.Name = "idCourseToolStripTextBox";
            this.idCourseToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // coursetTitleToolStripLabel
            // 
            this.coursetTitleToolStripLabel.Name = "coursetTitleToolStripLabel";
            this.coursetTitleToolStripLabel.Size = new System.Drawing.Size(70, 22);
            this.coursetTitleToolStripLabel.Text = "&Course title:";
            // 
            // coursetTitleToolStripTextBox
            // 
            this.coursetTitleToolStripTextBox.Name = "coursetTitleToolStripTextBox";
            this.coursetTitleToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchingTCToolStripButton
            // 
            this.searchingTCToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchingTCToolStripButton.Name = "searchingTCToolStripButton";
            this.searchingTCToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchingTCToolStripButton.Text = "&Search";
            this.searchingTCToolStripButton.Click += new System.EventHandler(this.searchingTCToolStripButton_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 312);
            this.Controls.Add(this.searchingTCToolStrip);
            this.Controls.Add(this.teacherLearnOnDataGridView);
            this.Controls.Add(this.teacherLearnOnBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.Text = "Teacher is trained in courses";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLearnOnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLearnOnBindingNavigator)).EndInit();
            this.teacherLearnOnBindingNavigator.ResumeLayout(false);
            this.teacherLearnOnBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLearnOnDataGridView)).EndInit();
            this.searchingTCToolStrip.ResumeLayout(false);
            this.searchingTCToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teacherLearnOnBindingSource;
        private DataSet1TableAdapters.TeacherLearnOnTableAdapter teacherLearnOnTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teacherLearnOnBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView teacherLearnOnDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip searchingTCToolStrip;
        private System.Windows.Forms.ToolStripLabel idTeacherToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idTeacherToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fullNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fullNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel idCourseToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idCourseToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel coursetTitleToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox coursetTitleToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchingTCToolStripButton;
    }
}