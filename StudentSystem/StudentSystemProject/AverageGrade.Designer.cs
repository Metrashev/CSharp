namespace StudentSystemProject
{
    partial class AverageGrade
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
            this.AverageGradeLabel = new System.Windows.Forms.Label();
            this.SSLabel = new System.Windows.Forms.Label();
            this.EULabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.ScholarShipLabel = new System.Windows.Forms.Label();
            this.EuroSchoolarShipLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AverageGradeLabel
            // 
            this.AverageGradeLabel.AllowDrop = true;
            this.AverageGradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AverageGradeLabel.AutoSize = true;
            this.AverageGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageGradeLabel.Location = new System.Drawing.Point(50, 30);
            this.AverageGradeLabel.Name = "AverageGradeLabel";
            this.AverageGradeLabel.Size = new System.Drawing.Size(332, 46);
            this.AverageGradeLabel.TabIndex = 0;
            this.AverageGradeLabel.Text = "СРЕДЕН УСПЕХ";
            // 
            // SSLabel
            // 
            this.SSLabel.AutoSize = true;
            this.SSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SSLabel.ForeColor = System.Drawing.Color.Lime;
            this.SSLabel.Location = new System.Drawing.Point(132, 110);
            this.SSLabel.Name = "SSLabel";
            this.SSLabel.Size = new System.Drawing.Size(126, 25);
            this.SSLabel.TabIndex = 1;
            this.SSLabel.Text = "Стипендии: ";
            this.SSLabel.Click += new System.EventHandler(this.SSLabel_Click);
            // 
            // EULabel
            // 
            this.EULabel.AutoSize = true;
            this.EULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EULabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EULabel.Location = new System.Drawing.Point(21, 140);
            this.EULabel.Name = "EULabel";
            this.EULabel.Size = new System.Drawing.Size(232, 25);
            this.EULabel.TabIndex = 2;
            this.EULabel.Text = "Европейски стипендии:";
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CLabel.ForeColor = System.Drawing.Color.Red;
            this.CLabel.Location = new System.Drawing.Point(193, 170);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(70, 25);
            this.CLabel.TabIndex = 3;
            this.CLabel.Text = "Курс:  ";
            // 
            // ScholarShipLabel
            // 
            this.ScholarShipLabel.AutoSize = true;
            this.ScholarShipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScholarShipLabel.ForeColor = System.Drawing.Color.Lime;
            this.ScholarShipLabel.Location = new System.Drawing.Point(264, 110);
            this.ScholarShipLabel.Name = "ScholarShipLabel";
            this.ScholarShipLabel.Size = new System.Drawing.Size(0, 25);
            this.ScholarShipLabel.TabIndex = 4;
            // 
            // EuroSchoolarShipLabel
            // 
            this.EuroSchoolarShipLabel.AutoSize = true;
            this.EuroSchoolarShipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EuroSchoolarShipLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EuroSchoolarShipLabel.Location = new System.Drawing.Point(264, 140);
            this.EuroSchoolarShipLabel.Name = "EuroSchoolarShipLabel";
            this.EuroSchoolarShipLabel.Size = new System.Drawing.Size(0, 25);
            this.EuroSchoolarShipLabel.TabIndex = 5;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourseLabel.ForeColor = System.Drawing.Color.Red;
            this.CourseLabel.Location = new System.Drawing.Point(264, 170);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(0, 25);
            this.CourseLabel.TabIndex = 6;
            // 
            // AverageGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.EuroSchoolarShipLabel);
            this.Controls.Add(this.ScholarShipLabel);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.EULabel);
            this.Controls.Add(this.SSLabel);
            this.Controls.Add(this.AverageGradeLabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AverageGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AverageGrade";
            this.Load += new System.EventHandler(this.AverageGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AverageGradeLabel;
        private System.Windows.Forms.Label SSLabel;
        private System.Windows.Forms.Label EULabel;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label ScholarShipLabel;
        private System.Windows.Forms.Label EuroSchoolarShipLabel;
        private System.Windows.Forms.Label CourseLabel;
    }
}