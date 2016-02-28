namespace CoursesDataBase_
{
    partial class Form3
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
            System.Windows.Forms.Label idStudentLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label homeAddressLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.idStudentTextBox = new System.Windows.Forms.TextBox();
            this.fullNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchingStudentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.idStudentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idStudentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fullNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fullNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.passportToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.passportToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchingStudentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CoursesDataBase_.DataSet1();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsTableAdapter = new CoursesDataBase_.DataSet1TableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new CoursesDataBase_.DataSet1TableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coursesOfStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            idStudentLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            homeAddressLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.searchingStudentsToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idStudentLabel
            // 
            idStudentLabel.AutoSize = true;
            idStudentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idStudentLabel.Location = new System.Drawing.Point(12, 36);
            idStudentLabel.Name = "idStudentLabel";
            idStudentLabel.Size = new System.Drawing.Size(75, 17);
            idStudentLabel.TabIndex = 2;
            idStudentLabel.Text = "&Id student:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fullNameLabel.Location = new System.Drawing.Point(269, 36);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(75, 17);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "&Full name:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passportLabel.Location = new System.Drawing.Point(9, 80);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(68, 17);
            passportLabel.TabIndex = 6;
            passportLabel.Text = "&Passport:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneNumberLabel.Location = new System.Drawing.Point(504, 82);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(104, 17);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "&Phone number:";
            // 
            // homeAddressLabel1
            // 
            homeAddressLabel1.AutoSize = true;
            homeAddressLabel1.Location = new System.Drawing.Point(504, 36);
            homeAddressLabel1.Name = "homeAddressLabel1";
            homeAddressLabel1.Size = new System.Drawing.Size(101, 17);
            homeAddressLabel1.TabIndex = 12;
            homeAddressLabel1.Text = "&Home address:";
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentsBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripButton3});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(141, 27);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(457, 25);
            this.studentsBindingNavigator.TabIndex = 0;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(66, 23);
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
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
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
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(12, 211);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.Size = new System.Drawing.Size(782, 270);
            this.studentsDataGridView.TabIndex = 1;
            // 
            // idStudentTextBox
            // 
            this.idStudentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "IdStudent", true));
            this.idStudentTextBox.Location = new System.Drawing.Point(90, 33);
            this.idStudentTextBox.Name = "idStudentTextBox";
            this.idStudentTextBox.Size = new System.Drawing.Size(138, 25);
            this.idStudentTextBox.TabIndex = 3;
            // 
            // fullNameRichTextBox
            // 
            this.fullNameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FullName", true));
            this.fullNameRichTextBox.Location = new System.Drawing.Point(350, 33);
            this.fullNameRichTextBox.Name = "fullNameRichTextBox";
            this.fullNameRichTextBox.Size = new System.Drawing.Size(132, 49);
            this.fullNameRichTextBox.TabIndex = 5;
            this.fullNameRichTextBox.Text = "";
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(90, 74);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(138, 25);
            this.passportTextBox.TabIndex = 7;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(612, 77);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(182, 25);
            this.phoneNumberTextBox.TabIndex = 11;
            // 
            // homeAddressRichTextBox
            // 
            this.homeAddressRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "HomeAddress", true));
            this.homeAddressRichTextBox.Location = new System.Drawing.Point(612, 27);
            this.homeAddressRichTextBox.Name = "homeAddressRichTextBox";
            this.homeAddressRichTextBox.Size = new System.Drawing.Size(182, 45);
            this.homeAddressRichTextBox.TabIndex = 13;
            this.homeAddressRichTextBox.Text = "";
            // 
            // searchingStudentsToolStrip
            // 
            this.searchingStudentsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchingStudentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idStudentToolStripLabel,
            this.idStudentToolStripTextBox,
            this.fullNameToolStripLabel,
            this.fullNameToolStripTextBox,
            this.passportToolStripLabel,
            this.passportToolStripTextBox,
            this.searchingStudentsToolStripButton});
            this.searchingStudentsToolStrip.Location = new System.Drawing.Point(78, 66);
            this.searchingStudentsToolStrip.Name = "searchingStudentsToolStrip";
            this.searchingStudentsToolStrip.Size = new System.Drawing.Size(644, 25);
            this.searchingStudentsToolStrip.TabIndex = 14;
            this.searchingStudentsToolStrip.Text = "searchingStudentsToolStrip";
            // 
            // idStudentToolStripLabel
            // 
            this.idStudentToolStripLabel.Name = "idStudentToolStripLabel";
            this.idStudentToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.idStudentToolStripLabel.Text = "&Id student:";
            // 
            // idStudentToolStripTextBox
            // 
            this.idStudentToolStripTextBox.Name = "idStudentToolStripTextBox";
            this.idStudentToolStripTextBox.Size = new System.Drawing.Size(100, 25);
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
            this.fullNameToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // passportToolStripLabel
            // 
            this.passportToolStripLabel.Name = "passportToolStripLabel";
            this.passportToolStripLabel.Size = new System.Drawing.Size(55, 22);
            this.passportToolStripLabel.Text = "&Passport:";
            // 
            // passportToolStripTextBox
            // 
            this.passportToolStripTextBox.Name = "passportToolStripTextBox";
            this.passportToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchingStudentsToolStripButton
            // 
            this.searchingStudentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchingStudentsToolStripButton.Name = "searchingStudentsToolStripButton";
            this.searchingStudentsToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchingStudentsToolStripButton.Text = "&Search";
            this.searchingStudentsToolStripButton.Click += new System.EventHandler(this.searchingStudentsToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentsBindingNavigator);
            this.groupBox1.Controls.Add(this.searchingStudentsToolStrip);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 16;
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
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdStudent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 215;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn3.HeaderText = "Passport";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HomeAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "HomeAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesShortTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.ListOfStudyingTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.StudentsShortTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CoursesDataBase_.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursesOfStudentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coursesOfStudentsToolStripMenuItem
            // 
            this.coursesOfStudentsToolStripMenuItem.Name = "coursesOfStudentsToolStripMenuItem";
            this.coursesOfStudentsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.coursesOfStudentsToolStripMenuItem.Text = "&Courses of students";
            this.coursesOfStudentsToolStripMenuItem.Click += new System.EventHandler(this.coursesOfStudentsToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 505);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(homeAddressLabel1);
            this.Controls.Add(this.homeAddressRichTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameRichTextBox);
            this.Controls.Add(idStudentLabel);
            this.Controls.Add(this.idStudentTextBox);
            this.Controls.Add(this.studentsDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.searchingStudentsToolStrip.ResumeLayout(false);
            this.searchingStudentsToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.TextBox idStudentTextBox;
        private System.Windows.Forms.RichTextBox fullNameRichTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.RichTextBox homeAddressRichTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip searchingStudentsToolStrip;
        private System.Windows.Forms.ToolStripLabel idStudentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idStudentToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fullNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fullNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel passportToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox passportToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchingStudentsToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coursesOfStudentsToolStripMenuItem;
    }
}