namespace TourismAgency
{
    partial class AddNewTravelForm
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
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FinishDateLabel = new System.Windows.Forms.Label();
            this.FinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NumberOfSeatsLabel = new System.Windows.Forms.Label();
            this.NumberOfSeatsComboBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TravelListBox = new System.Windows.Forms.ListBox();
            this.TravelLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateTravelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(13, 13);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(60, 13);
            this.DestinationLabel.TabIndex = 0;
            this.DestinationLabel.Text = "Destination";
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(13, 30);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(158, 20);
            this.DestinationTextBox.TabIndex = 1;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(13, 57);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.StartDateLabel.TabIndex = 2;
            this.StartDateLabel.Text = "Start date";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(13, 74);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.StartDateTimePicker.TabIndex = 3;
            // 
            // FinishDateLabel
            // 
            this.FinishDateLabel.AutoSize = true;
            this.FinishDateLabel.Location = new System.Drawing.Point(13, 101);
            this.FinishDateLabel.Name = "FinishDateLabel";
            this.FinishDateLabel.Size = new System.Drawing.Size(58, 13);
            this.FinishDateLabel.TabIndex = 4;
            this.FinishDateLabel.Text = "Finish date";
            // 
            // FinishDateTimePicker
            // 
            this.FinishDateTimePicker.Location = new System.Drawing.Point(13, 118);
            this.FinishDateTimePicker.Name = "FinishDateTimePicker";
            this.FinishDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.FinishDateTimePicker.TabIndex = 5;
            // 
            // NumberOfSeatsLabel
            // 
            this.NumberOfSeatsLabel.AutoSize = true;
            this.NumberOfSeatsLabel.Location = new System.Drawing.Point(13, 145);
            this.NumberOfSeatsLabel.Name = "NumberOfSeatsLabel";
            this.NumberOfSeatsLabel.Size = new System.Drawing.Size(84, 13);
            this.NumberOfSeatsLabel.TabIndex = 6;
            this.NumberOfSeatsLabel.Text = "Number of seats";
            // 
            // NumberOfSeatsComboBox
            // 
            this.NumberOfSeatsComboBox.FormattingEnabled = true;
            this.NumberOfSeatsComboBox.Location = new System.Drawing.Point(13, 162);
            this.NumberOfSeatsComboBox.Name = "NumberOfSeatsComboBox";
            this.NumberOfSeatsComboBox.Size = new System.Drawing.Size(158, 21);
            this.NumberOfSeatsComboBox.TabIndex = 8;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(13, 186);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(13, 203);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(158, 20);
            this.PriceTextBox.TabIndex = 10;
            // 
            // TravelListBox
            // 
            this.TravelListBox.FormattingEnabled = true;
            this.TravelListBox.Location = new System.Drawing.Point(187, 30);
            this.TravelListBox.Name = "TravelListBox";
            this.TravelListBox.Size = new System.Drawing.Size(284, 381);
            this.TravelListBox.TabIndex = 11;
            // 
            // TravelLabel
            // 
            this.TravelLabel.AutoSize = true;
            this.TravelLabel.Location = new System.Drawing.Point(187, 13);
            this.TravelLabel.Name = "TravelLabel";
            this.TravelLabel.Size = new System.Drawing.Size(37, 13);
            this.TravelLabel.TabIndex = 12;
            this.TravelLabel.Text = "Travel";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(13, 388);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(158, 23);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateTravelButton
            // 
            this.CreateTravelButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CreateTravelButton.Location = new System.Drawing.Point(12, 348);
            this.CreateTravelButton.Name = "CreateTravelButton";
            this.CreateTravelButton.Size = new System.Drawing.Size(157, 23);
            this.CreateTravelButton.TabIndex = 14;
            this.CreateTravelButton.Text = "Create travel";
            this.CreateTravelButton.UseVisualStyleBackColor = true;
            this.CreateTravelButton.UseWaitCursor = true;
            // 
            // AddNewTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 419);
            this.ControlBox = false;
            this.Controls.Add(this.CreateTravelButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TravelLabel);
            this.Controls.Add(this.TravelListBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NumberOfSeatsComboBox);
            this.Controls.Add(this.NumberOfSeatsLabel);
            this.Controls.Add(this.FinishDateTimePicker);
            this.Controls.Add(this.FinishDateLabel);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.DestinationLabel);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewTravelForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label FinishDateLabel;
        private System.Windows.Forms.DateTimePicker FinishDateTimePicker;
        private System.Windows.Forms.Label NumberOfSeatsLabel;
        private System.Windows.Forms.ComboBox NumberOfSeatsComboBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.ListBox TravelListBox;
        private System.Windows.Forms.Label TravelLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreateTravelButton;
    }
}