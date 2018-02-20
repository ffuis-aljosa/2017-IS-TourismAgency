namespace TourismAgency
{
    partial class InfoGuidesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.GuidesListView = new System.Windows.Forms.ListView();
            this.LastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GuidesLabel = new System.Windows.Forms.Label();
            this.AddNewGuideButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FirstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(184, 27);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LastNameLabel.Location = new System.Drawing.Point(9, 59);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(94, 18);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastNameTextBox.Location = new System.Drawing.Point(12, 81);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(184, 27);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // GuidesListView
            // 
            this.GuidesListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GuidesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumnHeader,
            this.LastNameColumnHeader});
            this.GuidesListView.GridLines = true;
            this.GuidesListView.Location = new System.Drawing.Point(227, 29);
            this.GuidesListView.Name = "GuidesListView";
            this.GuidesListView.Size = new System.Drawing.Size(357, 232);
            this.GuidesListView.TabIndex = 4;
            this.GuidesListView.UseCompatibleStateImageBehavior = false;
            this.GuidesListView.View = System.Windows.Forms.View.Details;
            this.GuidesListView.Click += new System.EventHandler(this.GuidesListView_Click);
            // 
            // LastNameColumnHeader
            // 
            this.LastNameColumnHeader.Text = "Last name";
            this.LastNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameColumnHeader.Width = 180;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Location = new System.Drawing.Point(12, 165);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(184, 45);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // GuidesLabel
            // 
            this.GuidesLabel.AutoSize = true;
            this.GuidesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuidesLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GuidesLabel.Location = new System.Drawing.Point(224, 8);
            this.GuidesLabel.Name = "GuidesLabel";
            this.GuidesLabel.Size = new System.Drawing.Size(64, 18);
            this.GuidesLabel.TabIndex = 6;
            this.GuidesLabel.Text = "Guides";
            // 
            // AddNewGuideButton
            // 
            this.AddNewGuideButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddNewGuideButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewGuideButton.Location = new System.Drawing.Point(12, 114);
            this.AddNewGuideButton.Name = "AddNewGuideButton";
            this.AddNewGuideButton.Size = new System.Drawing.Size(184, 45);
            this.AddNewGuideButton.TabIndex = 7;
            this.AddNewGuideButton.Text = "Add new guide";
            this.AddNewGuideButton.UseVisualStyleBackColor = true;
            this.AddNewGuideButton.Click += new System.EventHandler(this.AddGuidesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExitButton.Location = new System.Drawing.Point(12, 216);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 45);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FirstNameColumnHeader
            // 
            this.FirstNameColumnHeader.Text = "FirstName";
            this.FirstNameColumnHeader.Width = 173;
            // 
            // InfoGuidesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 286);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddNewGuideButton);
            this.Controls.Add(this.GuidesLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.GuidesListView);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTextBox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoGuidesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuidesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ListView GuidesListView;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ColumnHeader LastNameColumnHeader;
        private System.Windows.Forms.Label GuidesLabel;
        private System.Windows.Forms.Button AddNewGuideButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ColumnHeader FirstNameColumnHeader;
    }
}