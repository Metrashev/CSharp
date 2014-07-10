namespace StudentSystemProject
{
    partial class LoginForm
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
            this.FNumberLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FNumberTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnterAdminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FNumberLabel
            // 
            this.FNumberLabel.AutoSize = true;
            this.FNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNumberLabel.Location = new System.Drawing.Point(100, 135);
            this.FNumberLabel.Name = "FNumberLabel";
            this.FNumberLabel.Size = new System.Drawing.Size(206, 25);
            this.FNumberLabel.TabIndex = 0;
            this.FNumberLabel.Text = "Факултетен номер: ";
            this.FNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(215, 165);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 25);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Парола:";
            // 
            // FNumberTextBox
            // 
            this.FNumberTextBox.BackColor = System.Drawing.Color.White;
            this.FNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNumberTextBox.Location = new System.Drawing.Point(318, 136);
            this.FNumberTextBox.Name = "FNumberTextBox";
            this.FNumberTextBox.Size = new System.Drawing.Size(130, 23);
            this.FNumberTextBox.TabIndex = 2;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextBox.Location = new System.Drawing.Point(318, 166);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(130, 23);
            this.PassTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(318, 201);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(130, 30);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "ВХОД";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(318, 236);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "ИЗХОД";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EnterAdminButton
            // 
            this.EnterAdminButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterAdminButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.EnterAdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.EnterAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterAdminButton.Location = new System.Drawing.Point(410, 320);
            this.EnterAdminButton.Name = "EnterAdminButton";
            this.EnterAdminButton.Size = new System.Drawing.Size(130, 30);
            this.EnterAdminButton.TabIndex = 6;
            this.EnterAdminButton.Text = "ВХОД АДМИН";
            this.EnterAdminButton.UseVisualStyleBackColor = false;
            this.EnterAdminButton.Click += new System.EventHandler(this.EnterAdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "ВХОД СТУДЕНТИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterAdminButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.FNumberTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.FNumberLabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FNumberLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox FNumberTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EnterAdminButton;
        private System.Windows.Forms.Label label1;
    }
}