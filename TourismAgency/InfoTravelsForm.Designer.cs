﻿namespace TourismAgency
{
    partial class InfoTravelsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoTravelsForm));
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DestinationsTextBox = new System.Windows.Forms.TextBox();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FinishDateLabel = new System.Windows.Forms.Label();
            this.FinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BusLabel = new System.Windows.Forms.Label();
            this.Number_Of_SeatsComboBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TravelLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddNewTravelButton = new System.Windows.Forms.Button();
            this.TravelsListView = new System.Windows.Forms.ListView();
            this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinishDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuideColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfSeatsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuideComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DestinationLabel.Location = new System.Drawing.Point(9, 39);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(112, 18);
            this.DestinationLabel.TabIndex = 0;
            this.DestinationLabel.Text = "Destinations";
            // 
            // DestinationsTextBox
            // 
            this.DestinationsTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DestinationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationsTextBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.DestinationsTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DestinationsTextBox.Location = new System.Drawing.Point(12, 60);
            this.DestinationsTextBox.Multiline = true;
            this.DestinationsTextBox.Name = "DestinationsTextBox";
            this.DestinationsTextBox.Size = new System.Drawing.Size(184, 27);
            this.DestinationsTextBox.TabIndex = 1;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartDateLabel.Location = new System.Drawing.Point(9, 90);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(91, 18);
            this.StartDateLabel.TabIndex = 2;
            this.StartDateLabel.Text = "Start date";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F);
            this.StartDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.StartDateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartDateTimePicker.Font = new System.Drawing.Font("Verdana", 12F);
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTimePicker.Location = new System.Drawing.Point(12, 111);
            this.StartDateTimePicker.MinDate = new System.DateTime(2018, 2, 9, 1, 6, 19, 0);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(184, 27);
            this.StartDateTimePicker.TabIndex = 3;
            this.StartDateTimePicker.Value = new System.DateTime(2018, 2, 9, 1, 6, 19, 0);
            this.StartDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // FinishDateLabel
            // 
            this.FinishDateLabel.AutoSize = true;
            this.FinishDateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishDateLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FinishDateLabel.Location = new System.Drawing.Point(9, 141);
            this.FinishDateLabel.Name = "FinishDateLabel";
            this.FinishDateLabel.Size = new System.Drawing.Size(99, 18);
            this.FinishDateLabel.TabIndex = 4;
            this.FinishDateLabel.Text = "Finish date";
            // 
            // FinishDateTimePicker
            // 
            this.FinishDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinishDateTimePicker.Font = new System.Drawing.Font("Verdana", 12F);
            this.FinishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinishDateTimePicker.Location = new System.Drawing.Point(12, 162);
            this.FinishDateTimePicker.MinDate = new System.DateTime(2018, 2, 9, 0, 0, 0, 0);
            this.FinishDateTimePicker.Name = "FinishDateTimePicker";
            this.FinishDateTimePicker.Size = new System.Drawing.Size(184, 27);
            this.FinishDateTimePicker.TabIndex = 5;
            this.FinishDateTimePicker.Value = new System.DateTime(2018, 2, 9, 0, 0, 0, 0);
            // 
            // BusLabel
            // 
            this.BusLabel.AutoSize = true;
            this.BusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BusLabel.Location = new System.Drawing.Point(9, 192);
            this.BusLabel.Name = "BusLabel";
            this.BusLabel.Size = new System.Drawing.Size(144, 18);
            this.BusLabel.TabIndex = 6;
            this.BusLabel.Text = "Number of seats";
            // 
            // Number_Of_SeatsComboBox
            // 
            this.Number_Of_SeatsComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.Number_Of_SeatsComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Number_Of_SeatsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Number_Of_SeatsComboBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.Number_Of_SeatsComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Number_Of_SeatsComboBox.FormattingEnabled = true;
            this.Number_Of_SeatsComboBox.Items.AddRange(new object[] {
            "",
            "33",
            "34",
            "38",
            "44",
            "50",
            "54",
            "60",
            "80"});
            this.Number_Of_SeatsComboBox.Location = new System.Drawing.Point(12, 213);
            this.Number_Of_SeatsComboBox.Name = "Number_Of_SeatsComboBox";
            this.Number_Of_SeatsComboBox.Size = new System.Drawing.Size(184, 26);
            this.Number_Of_SeatsComboBox.TabIndex = 8;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PriceLabel.Location = new System.Drawing.Point(9, 292);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(47, 18);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.PriceTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceTextBox.Location = new System.Drawing.Point(12, 313);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(184, 27);
            this.PriceTextBox.TabIndex = 10;
            // 
            // TravelLabel
            // 
            this.TravelLabel.AutoSize = true;
            this.TravelLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TravelLabel.Location = new System.Drawing.Point(218, 62);
            this.TravelLabel.Name = "TravelLabel";
            this.TravelLabel.Size = new System.Drawing.Size(65, 18);
            this.TravelLabel.TabIndex = 12;
            this.TravelLabel.Text = "Travels";
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(12, 499);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 45);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddNewTravelButton
            // 
            this.AddNewTravelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewTravelButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.AddNewTravelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewTravelButton.Location = new System.Drawing.Point(12, 346);
            this.AddNewTravelButton.Name = "AddNewTravelButton";
            this.AddNewTravelButton.Size = new System.Drawing.Size(184, 45);
            this.AddNewTravelButton.TabIndex = 14;
            this.AddNewTravelButton.Text = "Add new travel";
            this.AddNewTravelButton.UseVisualStyleBackColor = true;
            this.AddNewTravelButton.Click += new System.EventHandler(this.AddNewTravelButton_Click);
            // 
            // TravelsListView
            // 
            this.TravelsListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TravelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.DestinationColumnHeader,
            this.StartDateColumnHeader,
            this.FinishDateColumnHeader,
            this.GuideColumnHeader,
            this.NumberOfSeatsColumnHeader,
            this.PriceColumnHeader});
            this.TravelsListView.GridLines = true;
            this.TravelsListView.Location = new System.Drawing.Point(221, 83);
            this.TravelsListView.Name = "TravelsListView";
            this.TravelsListView.Size = new System.Drawing.Size(739, 461);
            this.TravelsListView.TabIndex = 15;
            this.TravelsListView.UseCompatibleStateImageBehavior = false;
            this.TravelsListView.View = System.Windows.Forms.View.Details;
            this.TravelsListView.Click += new System.EventHandler(this.TravelsListView_Click);
            // 
            // IdColumnHeader
            // 
            this.IdColumnHeader.Text = "Id";
            this.IdColumnHeader.Width = 33;
            // 
            // DestinationColumnHeader
            // 
            this.DestinationColumnHeader.Tag = "";
            this.DestinationColumnHeader.Text = "Destination";
            this.DestinationColumnHeader.Width = 151;
            // 
            // StartDateColumnHeader
            // 
            this.StartDateColumnHeader.Text = "Start Date";
            this.StartDateColumnHeader.Width = 117;
            // 
            // FinishDateColumnHeader
            // 
            this.FinishDateColumnHeader.Text = "Finish Date";
            this.FinishDateColumnHeader.Width = 125;
            // 
            // GuideColumnHeader
            // 
            this.GuideColumnHeader.Text = "Guide";
            this.GuideColumnHeader.Width = 122;
            // 
            // NumberOfSeatsColumnHeader
            // 
            this.NumberOfSeatsColumnHeader.Text = "Number of seats";
            this.NumberOfSeatsColumnHeader.Width = 115;
            // 
            // PriceColumnHeader
            // 
            this.PriceColumnHeader.Text = "Price";
            this.PriceColumnHeader.Width = 72;
            // 
            // GuideComboBox
            // 
            this.GuideComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.GuideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GuideComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuideComboBox.FormattingEnabled = true;
            this.GuideComboBox.Location = new System.Drawing.Point(12, 263);
            this.GuideComboBox.Name = "GuideComboBox";
            this.GuideComboBox.Size = new System.Drawing.Size(184, 26);
            this.GuideComboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(9, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Guide";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchTextBox.Location = new System.Drawing.Point(221, 30);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(184, 27);
            this.SearchTextBox.TabIndex = 18;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpdateButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Location = new System.Drawing.Point(12, 397);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(184, 45);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Update selected";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(12, 448);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(184, 45);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete selected";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IdLabel.Location = new System.Drawing.Point(15, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 18);
            this.IdLabel.TabIndex = 23;
            this.IdLabel.Text = "Id";
            // 
            // InfoTravelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 559);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuideComboBox);
            this.Controls.Add(this.TravelsListView);
            this.Controls.Add(this.AddNewTravelButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TravelLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.Number_Of_SeatsComboBox);
            this.Controls.Add(this.BusLabel);
            this.Controls.Add(this.FinishDateTimePicker);
            this.Controls.Add(this.FinishDateLabel);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.DestinationsTextBox);
            this.Controls.Add(this.DestinationLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InfoTravelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox DestinationsTextBox;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label FinishDateLabel;
        private System.Windows.Forms.DateTimePicker FinishDateTimePicker;
        private System.Windows.Forms.Label BusLabel;
        private System.Windows.Forms.ComboBox Number_Of_SeatsComboBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TravelLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddNewTravelButton;
        private System.Windows.Forms.ListView TravelsListView;
        private System.Windows.Forms.ColumnHeader DestinationColumnHeader;
        private System.Windows.Forms.ColumnHeader StartDateColumnHeader;
        private System.Windows.Forms.ColumnHeader FinishDateColumnHeader;
        private System.Windows.Forms.ColumnHeader NumberOfSeatsColumnHeader;
        private System.Windows.Forms.ColumnHeader PriceColumnHeader;
        private System.Windows.Forms.ComboBox GuideComboBox;
        private System.Windows.Forms.ColumnHeader GuideColumnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ColumnHeader IdColumnHeader;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label IdLabel;
    }
}