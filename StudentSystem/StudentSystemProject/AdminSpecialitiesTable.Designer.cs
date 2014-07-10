namespace StudentSystemProject
{
    partial class AdminSpecialitiesTable
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
            System.Windows.Forms.Label specialityIDLabel;
            System.Windows.Forms.Label specialityNameLabel;
            System.Windows.Forms.Label rankIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSpecialitiesTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchSpecialitiesTextBox = new System.Windows.Forms.TextBox();
            this.SearchSpecialitiesLabel = new System.Windows.Forms.Label();
            this.studentSystemDB = new StudentSystemProject.StudentSystemDB();
            this.specialitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialitiesTableAdapter = new StudentSystemProject.StudentSystemDBTableAdapters.SpecialitiesTableAdapter();
            this.tableAdapterManager = new StudentSystemProject.StudentSystemDBTableAdapters.TableAdapterManager();
            this.specialitiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.specialitiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.specialitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityIDTextBox = new System.Windows.Forms.TextBox();
            this.specialityNameTextBox = new System.Windows.Forms.TextBox();
            this.rankIDTextBox = new System.Windows.Forms.TextBox();
            specialityIDLabel = new System.Windows.Forms.Label();
            specialityNameLabel = new System.Windows.Forms.Label();
            rankIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentSystemDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingNavigator)).BeginInit();
            this.specialitiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // specialityIDLabel
            // 
            specialityIDLabel.AutoSize = true;
            specialityIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            specialityIDLabel.Location = new System.Drawing.Point(50, 102);
            specialityIDLabel.Name = "specialityIDLabel";
            specialityIDLabel.Size = new System.Drawing.Size(161, 16);
            specialityIDLabel.TabIndex = 4;
            specialityIDLabel.Text = "Номер на специалност:";
            // 
            // specialityNameLabel
            // 
            specialityNameLabel.AutoSize = true;
            specialityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            specialityNameLabel.Location = new System.Drawing.Point(113, 128);
            specialityNameLabel.Name = "specialityNameLabel";
            specialityNameLabel.Size = new System.Drawing.Size(98, 16);
            specialityNameLabel.TabIndex = 6;
            specialityNameLabel.Text = "Специалност:";
            // 
            // rankIDLabel
            // 
            rankIDLabel.AutoSize = true;
            rankIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            rankIDLabel.Location = new System.Drawing.Point(89, 154);
            rankIDLabel.Name = "rankIDLabel";
            rankIDLabel.Size = new System.Drawing.Size(122, 16);
            rankIDLabel.TabIndex = 8;
            rankIDLabel.Text = "Квалификация №";
            // 
            // SearchSpecialitiesTextBox
            // 
            this.SearchSpecialitiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchSpecialitiesTextBox.Location = new System.Drawing.Point(217, 53);
            this.SearchSpecialitiesTextBox.Name = "SearchSpecialitiesTextBox";
            this.SearchSpecialitiesTextBox.Size = new System.Drawing.Size(130, 22);
            this.SearchSpecialitiesTextBox.TabIndex = 3;
            this.SearchSpecialitiesTextBox.TextChanged += new System.EventHandler(this.SearchSpecialitiesTextBox_TextChanged);
            // 
            // SearchSpecialitiesLabel
            // 
            this.SearchSpecialitiesLabel.AutoSize = true;
            this.SearchSpecialitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchSpecialitiesLabel.Location = new System.Drawing.Point(65, 53);
            this.SearchSpecialitiesLabel.Name = "SearchSpecialitiesLabel";
            this.SearchSpecialitiesLabel.Size = new System.Drawing.Size(146, 20);
            this.SearchSpecialitiesLabel.TabIndex = 2;
            this.SearchSpecialitiesLabel.Text = "Търсене по име:";
            // 
            // studentSystemDB
            // 
            this.studentSystemDB.DataSetName = "StudentSystemDB";
            this.studentSystemDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialitiesBindingSource
            // 
            this.specialitiesBindingSource.DataMember = "Specialities";
            this.specialitiesBindingSource.DataSource = this.studentSystemDB;
            // 
            // specialitiesTableAdapter
            // 
            this.specialitiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.ExamsTableAdapter = null;
            this.tableAdapterManager.ProfessorsTableAdapter = null;
            this.tableAdapterManager.RanksTableAdapter = null;
            this.tableAdapterManager.SpecialitiesTableAdapter = this.specialitiesTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentSystemProject.StudentSystemDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialitiesBindingNavigator
            // 
            this.specialitiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specialitiesBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.specialitiesBindingNavigator.BindingSource = this.specialitiesBindingSource;
            this.specialitiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specialitiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specialitiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.specialitiesBindingNavigatorSaveItem});
            this.specialitiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.specialitiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specialitiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specialitiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specialitiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specialitiesBindingNavigator.Name = "specialitiesBindingNavigator";
            this.specialitiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specialitiesBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.specialitiesBindingNavigator.TabIndex = 4;
            this.specialitiesBindingNavigator.Text = "bindingNavigator1";
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
            // specialitiesBindingNavigatorSaveItem
            // 
            this.specialitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specialitiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specialitiesBindingNavigatorSaveItem.Image")));
            this.specialitiesBindingNavigatorSaveItem.Name = "specialitiesBindingNavigatorSaveItem";
            this.specialitiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.specialitiesBindingNavigatorSaveItem.Text = "Save Data";
            this.specialitiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.specialitiesBindingNavigatorSaveItem_Click);
            // 
            // specialitiesDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.specialitiesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.specialitiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialitiesDataGridView.AutoGenerateColumns = false;
            this.specialitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.specialitiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.specialitiesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.specialitiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.specialitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.specialitiesDataGridView.DataSource = this.specialitiesBindingSource;
            this.specialitiesDataGridView.EnableHeadersVisualStyles = false;
            this.specialitiesDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.specialitiesDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.specialitiesDataGridView.Location = new System.Drawing.Point(12, 201);
            this.specialitiesDataGridView.Name = "specialitiesDataGridView";
            this.specialitiesDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.specialitiesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.specialitiesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.specialitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.specialitiesDataGridView.Size = new System.Drawing.Size(381, 232);
            this.specialitiesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SpecialityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SpecialityID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SpecialityName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SpecialityName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RankID";
            this.dataGridViewTextBoxColumn3.HeaderText = "RankID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // specialityIDTextBox
            // 
            this.specialityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitiesBindingSource, "SpecialityID", true));
            this.specialityIDTextBox.Location = new System.Drawing.Point(217, 101);
            this.specialityIDTextBox.Name = "specialityIDTextBox";
            this.specialityIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.specialityIDTextBox.TabIndex = 5;
            // 
            // specialityNameTextBox
            // 
            this.specialityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitiesBindingSource, "SpecialityName", true));
            this.specialityNameTextBox.Location = new System.Drawing.Point(217, 127);
            this.specialityNameTextBox.Name = "specialityNameTextBox";
            this.specialityNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.specialityNameTextBox.TabIndex = 7;
            // 
            // rankIDTextBox
            // 
            this.rankIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitiesBindingSource, "RankID", true));
            this.rankIDTextBox.Location = new System.Drawing.Point(217, 153);
            this.rankIDTextBox.Name = "rankIDTextBox";
            this.rankIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.rankIDTextBox.TabIndex = 9;
            // 
            // AdminSpecialitiesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(404, 446);
            this.Controls.Add(specialityIDLabel);
            this.Controls.Add(this.specialityIDTextBox);
            this.Controls.Add(specialityNameLabel);
            this.Controls.Add(this.specialityNameTextBox);
            this.Controls.Add(rankIDLabel);
            this.Controls.Add(this.rankIDTextBox);
            this.Controls.Add(this.specialitiesDataGridView);
            this.Controls.Add(this.specialitiesBindingNavigator);
            this.Controls.Add(this.SearchSpecialitiesTextBox);
            this.Controls.Add(this.SearchSpecialitiesLabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminSpecialitiesTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSpecialitiesTable";
            this.Load += new System.EventHandler(this.AdminSpecialitiesTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentSystemDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingNavigator)).EndInit();
            this.specialitiesBindingNavigator.ResumeLayout(false);
            this.specialitiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchSpecialitiesTextBox;
        private System.Windows.Forms.Label SearchSpecialitiesLabel;
        private StudentSystemDB studentSystemDB;
        private System.Windows.Forms.BindingSource specialitiesBindingSource;
        private StudentSystemDBTableAdapters.SpecialitiesTableAdapter specialitiesTableAdapter;
        private StudentSystemDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specialitiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton specialitiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView specialitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox specialityIDTextBox;
        private System.Windows.Forms.TextBox specialityNameTextBox;
        private System.Windows.Forms.TextBox rankIDTextBox;
    }
}