namespace CoursesDataBase_
{
    partial class Form5
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
            System.Windows.Forms.Label idCourseLabel;
            System.Windows.Forms.Label coursetTitleLabel;
            System.Windows.Forms.Label timetableLabel;
            System.Windows.Forms.Label idTeacherLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label duringOneLessonLabel;
            System.Windows.Forms.Label courseFeeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label label1;
            this.dataSet1 = new CoursesDataBase_.DataSet1();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new CoursesDataBase_.DataSet1TableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new CoursesDataBase_.DataSet1TableAdapters.TableAdapterManager();
            this.coursesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.coursesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCourseTextBox = new System.Windows.Forms.TextBox();
            this.coursetTitleTextBox = new System.Windows.Forms.TextBox();
            this.timetableTextBox = new System.Windows.Forms.TextBox();
            this.idTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.duringOneLessonTextBox = new System.Windows.Forms.TextBox();
            this.courseFeeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTeachersToolStrip = new System.Windows.Forms.ToolStrip();
            this.idCourseToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idCourseToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.idTeacherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idTeacherToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.coursetTitleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.coursetTitleToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchTeachersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            idCourseLabel = new System.Windows.Forms.Label();
            coursetTitleLabel = new System.Windows.Forms.Label();
            timetableLabel = new System.Windows.Forms.Label();
            idTeacherLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            duringOneLessonLabel = new System.Windows.Forms.Label();
            courseFeeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.searchTeachersToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCourseLabel
            // 
            idCourseLabel.AutoSize = true;
            idCourseLabel.Location = new System.Drawing.Point(11, 15);
            idCourseLabel.Name = "idCourseLabel";
            idCourseLabel.Size = new System.Drawing.Size(72, 17);
            idCourseLabel.TabIndex = 2;
            idCourseLabel.Text = "&Id course:";
            // 
            // coursetTitleLabel
            // 
            coursetTitleLabel.AutoSize = true;
            coursetTitleLabel.Location = new System.Drawing.Point(242, 15);
            coursetTitleLabel.Name = "coursetTitleLabel";
            coursetTitleLabel.Size = new System.Drawing.Size(89, 17);
            coursetTitleLabel.TabIndex = 4;
            coursetTitleLabel.Text = "&Courset title:";
            // 
            // timetableLabel
            // 
            timetableLabel.AutoSize = true;
            timetableLabel.Location = new System.Drawing.Point(259, 58);
            timetableLabel.Name = "timetableLabel";
            timetableLabel.Size = new System.Drawing.Size(72, 17);
            timetableLabel.TabIndex = 6;
            timetableLabel.Text = "&Timetable:";
            // 
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(9, 58);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(77, 17);
            idTeacherLabel.TabIndex = 8;
            idTeacherLabel.Text = "&Id teacher:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(559, 15);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(70, 17);
            durationLabel.TabIndex = 10;
            durationLabel.Text = "&Duration:";
            // 
            // duringOneLessonLabel
            // 
            duringOneLessonLabel.AutoSize = true;
            duringOneLessonLabel.Location = new System.Drawing.Point(501, 58);
            duringOneLessonLabel.Name = "duringOneLessonLabel";
            duringOneLessonLabel.Size = new System.Drawing.Size(128, 17);
            duringOneLessonLabel.TabIndex = 12;
            duringOneLessonLabel.Text = "&During one lesson:";
            // 
            // courseFeeLabel
            // 
            courseFeeLabel.AutoSize = true;
            courseFeeLabel.Location = new System.Drawing.Point(745, 15);
            courseFeeLabel.Name = "courseFeeLabel";
            courseFeeLabel.Size = new System.Drawing.Size(81, 17);
            courseFeeLabel.TabIndex = 14;
            courseFeeLabel.Text = "&Course fee:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dataSet1;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.ListOfStudyingTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CoursesDataBase_.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesBindingNavigator
            // 
            this.coursesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coursesBindingNavigator.BindingSource = this.coursesBindingSource;
            this.coursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coursesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coursesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.coursesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.coursesBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripButton3});
            this.coursesBindingNavigator.Location = new System.Drawing.Point(239, 17);
            this.coursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coursesBindingNavigator.Name = "coursesBindingNavigator";
            this.coursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coursesBindingNavigator.Size = new System.Drawing.Size(441, 25);
            this.coursesBindingNavigator.TabIndex = 0;
            this.coursesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // coursesBindingNavigatorSaveItem
            // 
            this.coursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coursesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coursesBindingNavigatorSaveItem.Image")));
            this.coursesBindingNavigatorSaveItem.Name = "coursesBindingNavigatorSaveItem";
            this.coursesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coursesBindingNavigatorSaveItem.Text = "Save Data";
            this.coursesBindingNavigatorSaveItem.Click += new System.EventHandler(this.coursesBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // coursesDataGridView
            // 
            this.coursesDataGridView.AllowUserToAddRows = false;
            this.coursesDataGridView.AllowUserToDeleteRows = false;
            this.coursesDataGridView.AutoGenerateColumns = false;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.coursesDataGridView.DataSource = this.coursesBindingSource;
            this.coursesDataGridView.Location = new System.Drawing.Point(12, 178);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.ReadOnly = true;
            this.coursesDataGridView.Size = new System.Drawing.Size(935, 272);
            this.coursesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCourse";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCourse";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdTeacher";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CoursetTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "CoursetTitle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Timetable";
            this.dataGridViewTextBoxColumn3.HeaderText = "Timetable";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DuringOneLesson";
            this.dataGridViewTextBoxColumn5.HeaderText = "DuringOneLesson";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CourseFee";
            this.dataGridViewTextBoxColumn6.HeaderText = "CourseFee";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // idCourseTextBox
            // 
            this.idCourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "IdCourse", true));
            this.idCourseTextBox.Location = new System.Drawing.Point(89, 12);
            this.idCourseTextBox.Name = "idCourseTextBox";
            this.idCourseTextBox.Size = new System.Drawing.Size(129, 25);
            this.idCourseTextBox.TabIndex = 3;
            // 
            // coursetTitleTextBox
            // 
            this.coursetTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CoursetTitle", true));
            this.coursetTitleTextBox.Location = new System.Drawing.Point(337, 12);
            this.coursetTitleTextBox.Name = "coursetTitleTextBox";
            this.coursetTitleTextBox.Size = new System.Drawing.Size(138, 25);
            this.coursetTitleTextBox.TabIndex = 5;
            // 
            // timetableTextBox
            // 
            this.timetableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Timetable", true));
            this.timetableTextBox.Location = new System.Drawing.Point(337, 55);
            this.timetableTextBox.Name = "timetableTextBox";
            this.timetableTextBox.Size = new System.Drawing.Size(138, 25);
            this.timetableTextBox.TabIndex = 7;
            // 
            // idTeacherComboBox
            // 
            this.idTeacherComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "IdTeacher", true));
            this.idTeacherComboBox.FormattingEnabled = true;
            this.idTeacherComboBox.Location = new System.Drawing.Point(89, 55);
            this.idTeacherComboBox.Name = "idTeacherComboBox";
            this.idTeacherComboBox.Size = new System.Drawing.Size(129, 25);
            this.idTeacherComboBox.TabIndex = 9;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(635, 12);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 25);
            this.durationTextBox.TabIndex = 11;
            // 
            // duringOneLessonTextBox
            // 
            this.duringOneLessonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "DuringOneLesson", true));
            this.duringOneLessonTextBox.Location = new System.Drawing.Point(635, 55);
            this.duringOneLessonTextBox.Name = "duringOneLessonTextBox";
            this.duringOneLessonTextBox.Size = new System.Drawing.Size(100, 25);
            this.duringOneLessonTextBox.TabIndex = 13;
            // 
            // courseFeeTextBox
            // 
            this.courseFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseFee", true));
            this.courseFeeTextBox.Location = new System.Drawing.Point(832, 12);
            this.courseFeeTextBox.Name = "courseFeeTextBox";
            this.courseFeeTextBox.Size = new System.Drawing.Size(70, 25);
            this.courseFeeTextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTeachersToolStrip);
            this.groupBox1.Controls.Add(this.coursesBindingNavigator);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // searchTeachersToolStrip
            // 
            this.searchTeachersToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchTeachersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idCourseToolStripLabel,
            this.idCourseToolStripTextBox,
            this.idTeacherToolStripLabel,
            this.idTeacherToolStripTextBox,
            this.coursetTitleToolStripLabel,
            this.coursetTitleToolStripTextBox,
            this.searchTeachersToolStripButton});
            this.searchTeachersToolStrip.Location = new System.Drawing.Point(129, 55);
            this.searchTeachersToolStrip.Name = "searchTeachersToolStrip";
            this.searchTeachersToolStrip.Size = new System.Drawing.Size(608, 25);
            this.searchTeachersToolStrip.TabIndex = 17;
            this.searchTeachersToolStrip.Text = "searchTeachersToolStrip";
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
            // coursetTitleToolStripLabel
            // 
            this.coursetTitleToolStripLabel.Name = "coursetTitleToolStripLabel";
            this.coursetTitleToolStripLabel.Size = new System.Drawing.Size(74, 22);
            this.coursetTitleToolStripLabel.Text = "&Courset title:";
            // 
            // coursetTitleToolStripTextBox
            // 
            this.coursetTitleToolStripTextBox.Name = "coursetTitleToolStripTextBox";
            this.coursetTitleToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // searchTeachersToolStripButton
            // 
            this.searchTeachersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchTeachersToolStripButton.Name = "searchTeachersToolStripButton";
            this.searchTeachersToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchTeachersToolStripButton.Text = "&Search";
            this.searchTeachersToolStripButton.Click += new System.EventHandler(this.searchTeachersToolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(954, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "&Дата і час : ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(7, 17);
            this.toolStripStatusLabel3.Text = "&";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(908, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 17);
            label1.TabIndex = 19;
            label1.Text = "&UAH";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 478);
            this.Controls.Add(label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(courseFeeLabel);
            this.Controls.Add(this.courseFeeTextBox);
            this.Controls.Add(duringOneLessonLabel);
            this.Controls.Add(this.duringOneLessonTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(idTeacherLabel);
            this.Controls.Add(this.idTeacherComboBox);
            this.Controls.Add(timetableLabel);
            this.Controls.Add(this.timetableTextBox);
            this.Controls.Add(coursetTitleLabel);
            this.Controls.Add(this.coursetTitleTextBox);
            this.Controls.Add(idCourseLabel);
            this.Controls.Add(this.idCourseTextBox);
            this.Controls.Add(this.coursesDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.searchTeachersToolStrip.ResumeLayout(false);
            this.searchTeachersToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private DataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coursesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton coursesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox idCourseTextBox;
        private System.Windows.Forms.TextBox coursetTitleTextBox;
        private System.Windows.Forms.TextBox timetableTextBox;
        private System.Windows.Forms.ComboBox idTeacherComboBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox duringOneLessonTextBox;
        private System.Windows.Forms.TextBox courseFeeTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip searchTeachersToolStrip;
        private System.Windows.Forms.ToolStripLabel idCourseToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idCourseToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel idTeacherToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idTeacherToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel coursetTitleToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox coursetTitleToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchTeachersToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
    }
}