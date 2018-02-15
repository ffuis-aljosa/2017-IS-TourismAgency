﻿namespace TourismAgency
{
    partial class AddNewAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAdminForm));
            this.CreateAdminLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CreateAdminButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateAdminLabel
            // 
            this.CreateAdminLabel.AutoSize = true;
            this.CreateAdminLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAdminLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateAdminLabel.Location = new System.Drawing.Point(57, 25);
            this.CreateAdminLabel.Name = "CreateAdminLabel";
            this.CreateAdminLabel.Size = new System.Drawing.Size(200, 32);
            this.CreateAdminLabel.TabIndex = 0;
            this.CreateAdminLabel.Text = "Create Admin";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Location = new System.Drawing.Point(73, 94);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(169, 27);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Location = new System.Drawing.Point(73, 145);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(169, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RepeatPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(73, 196);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(169, 27);
            this.RepeatPasswordTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Location = new System.Drawing.Point(73, 247);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(169, 27);
            this.FirstNameTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Location = new System.Drawing.Point(73, 298);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(169, 27);
            this.LastNameTextBox.TabIndex = 5;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(73, 75);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(90, 18);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(73, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(85, 18);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(73, 175);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(149, 18);
            this.RepeatPasswordLabel.TabIndex = 8;
            this.RepeatPasswordLabel.Text = "Repeat password";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(73, 226);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(95, 18);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(73, 277);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(94, 18);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Last name";
            // 
            // CreateAdminButton
            // 
            this.CreateAdminButton.Location = new System.Drawing.Point(12, 352);
            this.CreateAdminButton.Name = "CreateAdminButton";
            this.CreateAdminButton.Size = new System.Drawing.Size(137, 52);
            this.CreateAdminButton.TabIndex = 11;
            this.CreateAdminButton.Text = "Create admin";
            this.CreateAdminButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(164, 352);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(137, 52);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // AddNewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 416);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CreateAdminButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.CreateAdminLabel);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddNewAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateAdminLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button CreateAdminButton;
        private System.Windows.Forms.Button ExitButton;
    }
}