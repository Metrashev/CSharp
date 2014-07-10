namespace StudentSystemProject
{
    partial class AdminOperationContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебниДисциплиниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изпитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специалностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентиToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.учебниДисциплиниToolStripMenuItem,
            this.изпитиToolStripMenuItem,
            this.специалностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.студентиToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.студентиToolStripMenuItem.Text = "Студенти";
            this.студентиToolStripMenuItem.Click += new System.EventHandler(this.студентиToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // учебниДисциплиниToolStripMenuItem
            // 
            this.учебниДисциплиниToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.учебниДисциплиниToolStripMenuItem.Name = "учебниДисциплиниToolStripMenuItem";
            this.учебниДисциплиниToolStripMenuItem.Size = new System.Drawing.Size(183, 25);
            this.учебниДисциплиниToolStripMenuItem.Text = "Учебни дисциплини";
            this.учебниДисциплиниToolStripMenuItem.Click += new System.EventHandler(this.учебниДисциплиниToolStripMenuItem_Click);
            // 
            // изпитиToolStripMenuItem
            // 
            this.изпитиToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.изпитиToolStripMenuItem.Name = "изпитиToolStripMenuItem";
            this.изпитиToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.изпитиToolStripMenuItem.Text = "Изпити";
            this.изпитиToolStripMenuItem.Click += new System.EventHandler(this.изпитиToolStripMenuItem_Click);
            // 
            // специалностиToolStripMenuItem
            // 
            this.специалностиToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.специалностиToolStripMenuItem.Name = "специалностиToolStripMenuItem";
            this.специалностиToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.специалностиToolStripMenuItem.Text = "Специалности";
            this.специалностиToolStripMenuItem.Click += new System.EventHandler(this.специалностиToolStripMenuItem_Click);
            // 
            // AdminOperationContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminOperationContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOperationContainer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminOperationContainer_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебниДисциплиниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изпитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специалностиToolStripMenuItem;
    }
}