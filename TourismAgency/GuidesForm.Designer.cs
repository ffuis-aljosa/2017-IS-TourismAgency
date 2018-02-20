﻿namespace TourismAgency
{
    partial class GuidesForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GuidesListView = new System.Windows.Forms.ListView();
            this.RemoveGuidesButton = new System.Windows.Forms.Button();
            this.NumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuidesLabel = new System.Windows.Forms.Label();
            this.AddGuidesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
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
            this.FirstNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.LastNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 59);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(94, 18);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(15, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 27);
            this.textBox1.TabIndex = 3;
            // 
            // GuidesListView
            // 
            this.GuidesListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GuidesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumnHeader,
            this.FirstNameColumnHeader,
            this.LastNameColumnHeader});
            this.GuidesListView.GridLines = true;
            this.GuidesListView.Location = new System.Drawing.Point(161, 29);
            this.GuidesListView.Name = "GuidesListView";
            this.GuidesListView.Size = new System.Drawing.Size(370, 236);
            this.GuidesListView.TabIndex = 4;
            this.GuidesListView.UseCompatibleStateImageBehavior = false;
            this.GuidesListView.View = System.Windows.Forms.View.Details;
            // 
            // RemoveGuidesButton
            // 
            this.RemoveGuidesButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveGuidesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveGuidesButton.Location = new System.Drawing.Point(15, 148);
            this.RemoveGuidesButton.Name = "RemoveGuidesButton";
            this.RemoveGuidesButton.Size = new System.Drawing.Size(129, 35);
            this.RemoveGuidesButton.TabIndex = 5;
            this.RemoveGuidesButton.Text = "Remove guides";
            this.RemoveGuidesButton.UseVisualStyleBackColor = true;
            // 
            // NumberColumnHeader
            // 
            this.NumberColumnHeader.Text = "No.";
            this.NumberColumnHeader.Width = 31;
            // 
            // FirstNameColumnHeader
            // 
            this.FirstNameColumnHeader.Text = "First name";
            this.FirstNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameColumnHeader.Width = 167;
            // 
            // LastNameColumnHeader
            // 
            this.LastNameColumnHeader.Text = "Last name";
            this.LastNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameColumnHeader.Width = 170;
            // 
            // GuidesLabel
            // 
            this.GuidesLabel.AutoSize = true;
            this.GuidesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuidesLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GuidesLabel.Location = new System.Drawing.Point(158, 8);
            this.GuidesLabel.Name = "GuidesLabel";
            this.GuidesLabel.Size = new System.Drawing.Size(64, 18);
            this.GuidesLabel.TabIndex = 6;
            this.GuidesLabel.Text = "Guides";
            // 
            // AddGuidesButton
            // 
            this.AddGuidesButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddGuidesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddGuidesButton.Location = new System.Drawing.Point(15, 189);
            this.AddGuidesButton.Name = "AddGuidesButton";
            this.AddGuidesButton.Size = new System.Drawing.Size(129, 35);
            this.AddGuidesButton.TabIndex = 7;
            this.AddGuidesButton.Text = "Add guides";
            this.AddGuidesButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExitButton.Location = new System.Drawing.Point(15, 230);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 35);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GuidesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 288);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddGuidesButton);
            this.Controls.Add(this.GuidesLabel);
            this.Controls.Add(this.RemoveGuidesButton);
            this.Controls.Add(this.GuidesListView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTextBox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuidesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuidesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView GuidesListView;
        private System.Windows.Forms.Button RemoveGuidesButton;
        private System.Windows.Forms.ColumnHeader NumberColumnHeader;
        private System.Windows.Forms.ColumnHeader FirstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader LastNameColumnHeader;
        private System.Windows.Forms.Label GuidesLabel;
        private System.Windows.Forms.Button AddGuidesButton;
        private System.Windows.Forms.Button ExitButton;
    }
}