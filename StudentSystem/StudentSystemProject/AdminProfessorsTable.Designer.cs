namespace StudentSystemProject
{
    partial class AdminProfessorsTable
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
            System.Windows.Forms.Label professorIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label courseIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfessorsTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchProfessorTextBox = new System.Windows.Forms.TextBox();
            this.SearchProfessorLabel = new System.Windows.Forms.Label();
            this.studentSystemDB = new StudentSystemProject.StudentSystemDB();
            this.professorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorsTableAdapter = new StudentSystemProject.StudentSystemDBTableAdapters.ProfessorsTableAdapter();
            this.tableAdapterManager = new StudentSystemProject.StudentSystemDBTableAdapters.TableAdapterManager();
            this.professorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.professorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.professorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            professorIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            courseIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentSystemDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsBindingNavigator)).BeginInit();
            this.professorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // professorIDLabel
            // 
            professorIDLabel.AutoSize = true;
            professorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            professorIDLabel.Location = new System.Drawing.Point(29, 108);
            professorIDLabel.Name = "professorIDLabel";
            professorIDLabel.Size = new System.Drawing.Size(171, 16);
            professorIDLabel.TabIndex = 4;
            professorIDLabel.Text = "Номер на преподавател:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(162, 138);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(38, 16);
            firstNameLabel.TabIndex = 6;
            firstNameLabel.Text = "Име:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(130, 161);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(70, 16);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Фамилия:";
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            courseIDLabel.Location = new System.Drawing.Point(64, 187);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(136, 16);
            courseIDLabel.TabIndex = 10;
            courseIDLabel.Text = "Номер дисциплина:";
            // 
            // SearchProfessorTextBox
            // 
            this.SearchProfessorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchProfessorTextBox.Location = new System.Drawing.Point(429, 47);
            this.SearchProfessorTextBox.Name = "SearchProfessorTextBox";
            this.SearchProfessorTextBox.Size = new System.Drawing.Size(130, 22);
            this.SearchProfessorTextBox.TabIndex = 3;
            this.SearchProfessorTextBox.TextChanged += new System.EventHandler(this.SearchProfessorTextBox_TextChanged);
            // 
            // SearchProfessorLabel
            // 
            this.SearchProfessorLabel.AutoSize = true;
            this.SearchProfessorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchProfessorLabel.Location = new System.Drawing.Point(231, 47);
            this.SearchProfessorLabel.Name = "SearchProfessorLabel";
            this.SearchProfessorLabel.Size = new System.Drawing.Size(192, 20);
            this.SearchProfessorLabel.TabIndex = 2;
            this.SearchProfessorLabel.Text = "Търсене по фамилия:";
            this.SearchProfessorLabel.Click += new System.EventHandler(this.SearchProfessorLabel_Click);
            // 
            // studentSystemDB
            // 
            this.studentSystemDB.DataSetName = "StudentSystemDB";
            this.studentSystemDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorsBindingSource
            // 
            this.professorsBindingSource.DataMember = "Professors";
            this.professorsBindingSource.DataSource = this.studentSystemDB;
            // 
            // professorsTableAdapter
            // 
            this.professorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.ExamsTableAdapter = null;
            this.tableAdapterManager.ProfessorsTableAdapter = this.professorsTableAdapter;
            this.tableAdapterManager.RanksTableAdapter = null;
            this.tableAdapterManager.SpecialitiesTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentSystemProject.StudentSystemDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professorsBindingNavigator
            // 
            this.professorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.professorsBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.professorsBindingNavigator.BindingSource = this.professorsBindingSource;
            this.professorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.professorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.professorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.professorsBindingNavigatorSaveItem});
            this.professorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.professorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.professorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.professorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.professorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.professorsBindingNavigator.Name = "professorsBindingNavigator";
            this.professorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.professorsBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.professorsBindingNavigator.TabIndex = 4;
            this.professorsBindingNavigator.Text = "bindingNavigator1";
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
            // professorsBindingNavigatorSaveItem
            // 
            this.professorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.professorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("professorsBindingNavigatorSaveItem.Image")));
            this.professorsBindingNavigatorSaveItem.Name = "professorsBindingNavigatorSaveItem";
            this.professorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.professorsBindingNavigatorSaveItem.Text = "Save Data";
            this.professorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.professorsBindingNavigatorSaveItem_Click);
            // 
            // professorsDataGridView
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professorsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.professorsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.professorsDataGridView.AutoGenerateColumns = false;
            this.professorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.professorsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.professorsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.professorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.professorsDataGridView.DataSource = this.professorsBindingSource;
            this.professorsDataGridView.EnableHeadersVisualStyles = false;
            this.professorsDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.professorsDataGridView.Location = new System.Drawing.Point(21, 237);
            this.professorsDataGridView.Name = "professorsDataGridView";
            this.professorsDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professorsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professorsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.professorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.professorsDataGridView.Size = new System.Drawing.Size(538, 220);
            this.professorsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProfessorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProfessorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CourseID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // professorIDTextBox
            // 
            this.professorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorsBindingSource, "ProfessorID", true));
            this.professorIDTextBox.Location = new System.Drawing.Point(206, 108);
            this.professorIDTextBox.Name = "professorIDTextBox";
            this.professorIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.professorIDTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(206, 134);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(206, 160);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorsBindingSource, "CourseID", true));
            this.courseIDTextBox.Location = new System.Drawing.Point(206, 186);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.courseIDTextBox.TabIndex = 11;
            // 
            // AdminProfessorsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(580, 480);
            this.Controls.Add(professorIDLabel);
            this.Controls.Add(this.professorIDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(this.professorsDataGridView);
            this.Controls.Add(this.professorsBindingNavigator);
            this.Controls.Add(this.SearchProfessorTextBox);
            this.Controls.Add(this.SearchProfessorLabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminProfessorsTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProfessorsTable";
            this.Load += new System.EventHandler(this.AdminProfessorsTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentSystemDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsBindingNavigator)).EndInit();
            this.professorsBindingNavigator.ResumeLayout(false);
            this.professorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchProfessorTextBox;
        private System.Windows.Forms.Label SearchProfessorLabel;
        private StudentSystemDB studentSystemDB;
        private System.Windows.Forms.BindingSource professorsBindingSource;
        private StudentSystemDBTableAdapters.ProfessorsTableAdapter professorsTableAdapter;
        private StudentSystemDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator professorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton professorsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView professorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox professorIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox courseIDTextBox;
    }
}