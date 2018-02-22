namespace TourismAgency
{
    partial class AddNewGuideForm
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateGuideLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateGuideButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstNameTextBox.Location = new System.Drawing.Point(40, 81);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(169, 27);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastNameTextBox.Location = new System.Drawing.Point(40, 132);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(169, 27);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // CreateGuideLabel
            // 
            this.CreateGuideLabel.AutoSize = true;
            this.CreateGuideLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGuideLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateGuideLabel.Location = new System.Drawing.Point(34, 9);
            this.CreateGuideLabel.Name = "CreateGuideLabel";
            this.CreateGuideLabel.Size = new System.Drawing.Size(193, 32);
            this.CreateGuideLabel.TabIndex = 3;
            this.CreateGuideLabel.Text = "Create Guide";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LastNameLabel.Location = new System.Drawing.Point(37, 111);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(94, 18);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "First name";
            // 
            // CreateGuideButton
            // 
            this.CreateGuideButton.Location = new System.Drawing.Point(55, 172);
            this.CreateGuideButton.Name = "CreateGuideButton";
            this.CreateGuideButton.Size = new System.Drawing.Size(137, 52);
            this.CreateGuideButton.TabIndex = 3;
            this.CreateGuideButton.Text = "Create admin";
            this.CreateGuideButton.UseVisualStyleBackColor = true;
            this.CreateGuideButton.Click += new System.EventHandler(this.CreateGuideButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(55, 230);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(137, 52);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddNewGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(256, 298);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateGuideButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.CreateGuideLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddNewGuideForm";
            this.Text = "AddNewGuideForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label CreateGuideLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateGuideButton;
        private System.Windows.Forms.Button BackButton;
    }
}