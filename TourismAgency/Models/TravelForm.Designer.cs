namespace TourismAgency.Models
{
    partial class TravelForm
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
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FinishDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NumberOfSeatsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TravelListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CreateTravelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(15, 25);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(198, 20);
            this.DestinationTextBox.TabIndex = 0;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(12, 9);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(60, 13);
            this.DestinationLabel.TabIndex = 1;
            this.DestinationLabel.Text = "Destination";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(15, 52);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 2;
            this.StartDateLabel.Text = "Start Date";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(15, 69);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.StartDateTimePicker.TabIndex = 3;
            // 
            // FinishDateLabel
            // 
            this.FinishDateLabel.AutoSize = true;
            this.FinishDateLabel.Location = new System.Drawing.Point(13, 96);
            this.FinishDateLabel.Name = "FinishDateLabel";
            this.FinishDateLabel.Size = new System.Drawing.Size(60, 13);
            this.FinishDateLabel.TabIndex = 4;
            this.FinishDateLabel.Text = "Finish Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // NumberOfSeatsLabel
            // 
            this.NumberOfSeatsLabel.AutoSize = true;
            this.NumberOfSeatsLabel.Location = new System.Drawing.Point(15, 140);
            this.NumberOfSeatsLabel.Name = "NumberOfSeatsLabel";
            this.NumberOfSeatsLabel.Size = new System.Drawing.Size(84, 13);
            this.NumberOfSeatsLabel.TabIndex = 6;
            this.NumberOfSeatsLabel.Text = "Number of seats";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add destination";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TravelListBox
            // 
            this.TravelListBox.FormattingEnabled = true;
            this.TravelListBox.Location = new System.Drawing.Point(383, 13);
            this.TravelListBox.Name = "TravelListBox";
            this.TravelListBox.Size = new System.Drawing.Size(258, 329);
            this.TravelListBox.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 9;
            // 
            // CreateTravelButton
            // 
            this.CreateTravelButton.Location = new System.Drawing.Point(15, 349);
            this.CreateTravelButton.Name = "CreateTravelButton";
            this.CreateTravelButton.Size = new System.Drawing.Size(198, 23);
            this.CreateTravelButton.TabIndex = 10;
            this.CreateTravelButton.Text = "Create travel";
            this.CreateTravelButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(540, 348);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 384);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CreateTravelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TravelListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumberOfSeatsLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FinishDateLabel);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.DestinationTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TravelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label FinishDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label NumberOfSeatsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox TravelListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CreateTravelButton;
        private System.Windows.Forms.Button ExitButton;
    }
}