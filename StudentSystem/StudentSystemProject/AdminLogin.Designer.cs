namespace StudentSystemProject
{
    partial class AdminLogin
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
            this.AdminLabel = new System.Windows.Forms.Label();
            this.ExitAdminButton = new System.Windows.Forms.Button();
            this.LoginAdminButton = new System.Windows.Forms.Button();
            this.PassAdminTextBox = new System.Windows.Forms.TextBox();
            this.PasswordAdminLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLabel.Location = new System.Drawing.Point(25, 30);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(291, 46);
            this.AdminLabel.TabIndex = 15;
            this.AdminLabel.Text = "ВХОД АДМИН";
            // 
            // ExitAdminButton
            // 
            this.ExitAdminButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ExitAdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitAdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitAdminButton.Location = new System.Drawing.Point(153, 178);
            this.ExitAdminButton.Name = "ExitAdminButton";
            this.ExitAdminButton.Size = new System.Drawing.Size(130, 30);
            this.ExitAdminButton.TabIndex = 13;
            this.ExitAdminButton.Text = "ИЗХОД";
            this.ExitAdminButton.UseVisualStyleBackColor = false;
            this.ExitAdminButton.Click += new System.EventHandler(this.ExitAdminButton_Click);
            // 
            // LoginAdminButton
            // 
            this.LoginAdminButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LoginAdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginAdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.LoginAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginAdminButton.Location = new System.Drawing.Point(153, 140);
            this.LoginAdminButton.Name = "LoginAdminButton";
            this.LoginAdminButton.Size = new System.Drawing.Size(130, 30);
            this.LoginAdminButton.TabIndex = 12;
            this.LoginAdminButton.Text = "ВХОД";
            this.LoginAdminButton.UseVisualStyleBackColor = false;
            this.LoginAdminButton.Click += new System.EventHandler(this.LoginAdminButton_Click);
            // 
            // PassAdminTextBox
            // 
            this.PassAdminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassAdminTextBox.Location = new System.Drawing.Point(153, 114);
            this.PassAdminTextBox.Name = "PassAdminTextBox";
            this.PassAdminTextBox.PasswordChar = '*';
            this.PassAdminTextBox.Size = new System.Drawing.Size(130, 22);
            this.PassAdminTextBox.TabIndex = 11;
            // 
            // PasswordAdminLabel
            // 
            this.PasswordAdminLabel.AutoSize = true;
            this.PasswordAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordAdminLabel.Location = new System.Drawing.Point(61, 109);
            this.PasswordAdminLabel.Name = "PasswordAdminLabel";
            this.PasswordAdminLabel.Size = new System.Drawing.Size(86, 25);
            this.PasswordAdminLabel.TabIndex = 9;
            this.PasswordAdminLabel.Text = "Парола:";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(339, 246);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.ExitAdminButton);
            this.Controls.Add(this.LoginAdminButton);
            this.Controls.Add(this.PassAdminTextBox);
            this.Controls.Add(this.PasswordAdminLabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button ExitAdminButton;
        private System.Windows.Forms.Button LoginAdminButton;
        private System.Windows.Forms.TextBox PassAdminTextBox;
        private System.Windows.Forms.Label PasswordAdminLabel;
    }
}