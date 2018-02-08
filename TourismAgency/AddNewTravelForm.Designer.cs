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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTravelForm));
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
            resources.ApplyResources(this.DestinationLabel, "DestinationLabel");
            this.DestinationLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DestinationLabel.Name = "DestinationLabel";
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DestinationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DestinationTextBox, "DestinationTextBox");
            this.DestinationTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DestinationTextBox.Name = "DestinationTextBox";
            // 
            // StartDateLabel
            // 
            resources.ApplyResources(this.StartDateLabel, "StartDateLabel");
            this.StartDateLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.StartDateLabel.Name = "StartDateLabel";
            // 
            // StartDateTimePicker
            // 
            resources.ApplyResources(this.StartDateTimePicker, "StartDateTimePicker");
            this.StartDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.StartDateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTimePicker.MinDate = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Value = new System.DateTime(2018, 2, 8, 18, 37, 15, 0);
            // 
            // FinishDateLabel
            // 
            resources.ApplyResources(this.FinishDateLabel, "FinishDateLabel");
            this.FinishDateLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FinishDateLabel.Name = "FinishDateLabel";
            // 
            // FinishDateTimePicker
            // 
            this.FinishDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.FinishDateTimePicker, "FinishDateTimePicker");
            this.FinishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinishDateTimePicker.MinDate = new System.DateTime(2018, 2, 8, 18, 39, 17, 0);
            this.FinishDateTimePicker.Name = "FinishDateTimePicker";
            this.FinishDateTimePicker.Value = new System.DateTime(2018, 2, 8, 18, 39, 17, 0);
            // 
            // NumberOfSeatsLabel
            // 
            resources.ApplyResources(this.NumberOfSeatsLabel, "NumberOfSeatsLabel");
            this.NumberOfSeatsLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NumberOfSeatsLabel.Name = "NumberOfSeatsLabel";
            // 
            // NumberOfSeatsComboBox
            // 
            this.NumberOfSeatsComboBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NumberOfSeatsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.NumberOfSeatsComboBox, "NumberOfSeatsComboBox");
            this.NumberOfSeatsComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NumberOfSeatsComboBox.FormattingEnabled = true;
            this.NumberOfSeatsComboBox.Name = "NumberOfSeatsComboBox";
            // 
            // PriceLabel
            // 
            resources.ApplyResources(this.PriceLabel, "PriceLabel");
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PriceLabel.Name = "PriceLabel";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PriceTextBox, "PriceTextBox");
            this.PriceTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PriceTextBox.Name = "PriceTextBox";
            // 
            // TravelListBox
            // 
            this.TravelListBox.FormattingEnabled = true;
            resources.ApplyResources(this.TravelListBox, "TravelListBox");
            this.TravelListBox.Name = "TravelListBox";
            // 
            // TravelLabel
            // 
            resources.ApplyResources(this.TravelLabel, "TravelLabel");
            this.TravelLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TravelLabel.Name = "TravelLabel";
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateTravelButton
            // 
            this.CreateTravelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.CreateTravelButton, "CreateTravelButton");
            this.CreateTravelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateTravelButton.Name = "CreateTravelButton";
            this.CreateTravelButton.UseVisualStyleBackColor = true;
            // 
            // AddNewTravelForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewTravelForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
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