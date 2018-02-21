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
            this.CreateTravelButton = new System.Windows.Forms.Button();
            this.TravelsListView = new System.Windows.Forms.ListView();
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
            this.SuspendLayout();
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DestinationLabel.Location = new System.Drawing.Point(9, 16);
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
            this.DestinationsTextBox.Location = new System.Drawing.Point(12, 37);
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
            this.StartDateLabel.Location = new System.Drawing.Point(9, 67);
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
            this.StartDateTimePicker.Location = new System.Drawing.Point(12, 88);
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
            this.FinishDateLabel.Location = new System.Drawing.Point(9, 118);
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
            this.FinishDateTimePicker.Location = new System.Drawing.Point(12, 139);
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
            this.BusLabel.Location = new System.Drawing.Point(9, 169);
            this.BusLabel.Name = "BusLabel";
            this.BusLabel.Size = new System.Drawing.Size(144, 18);
            this.BusLabel.TabIndex = 6;
            this.BusLabel.Text = "Number of seats";
            // 
            // Number_Of_SeatsComboBox
            // 
            this.Number_Of_SeatsComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.Number_Of_SeatsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Number_Of_SeatsComboBox.Location = new System.Drawing.Point(12, 190);
            this.Number_Of_SeatsComboBox.Name = "Number_Of_SeatsComboBox";
            this.Number_Of_SeatsComboBox.Size = new System.Drawing.Size(184, 26);
            this.Number_Of_SeatsComboBox.TabIndex = 8;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PriceLabel.Location = new System.Drawing.Point(9, 269);
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
            this.PriceTextBox.Location = new System.Drawing.Point(12, 290);
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
            this.TravelLabel.Location = new System.Drawing.Point(218, 67);
            this.TravelLabel.Name = "TravelLabel";
            this.TravelLabel.Size = new System.Drawing.Size(65, 18);
            this.TravelLabel.TabIndex = 12;
            this.TravelLabel.Text = "Travels";
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(12, 374);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 45);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateTravelButton
            // 
            this.CreateTravelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTravelButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.CreateTravelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateTravelButton.Location = new System.Drawing.Point(12, 323);
            this.CreateTravelButton.Name = "CreateTravelButton";
            this.CreateTravelButton.Size = new System.Drawing.Size(184, 45);
            this.CreateTravelButton.TabIndex = 14;
            this.CreateTravelButton.Text = "Create travel";
            this.CreateTravelButton.UseVisualStyleBackColor = true;
            this.CreateTravelButton.Click += new System.EventHandler(this.CreateTravelButton_Click);
            // 
            // TravelsListView
            // 
            this.TravelsListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TravelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DestinationColumnHeader,
            this.StartDateColumnHeader,
            this.FinishDateColumnHeader,
            this.GuideColumnHeader,
            this.NumberOfSeatsColumnHeader,
            this.PriceColumnHeader});
            this.TravelsListView.GridLines = true;
            this.TravelsListView.Location = new System.Drawing.Point(221, 88);
            this.TravelsListView.Name = "TravelsListView";
            this.TravelsListView.Size = new System.Drawing.Size(738, 328);
            this.TravelsListView.TabIndex = 15;
            this.TravelsListView.UseCompatibleStateImageBehavior = false;
            this.TravelsListView.View = System.Windows.Forms.View.Details;
            this.TravelsListView.Click += new System.EventHandler(this.TravelsListView_Click);
            // 
            // DestinationColumnHeader
            // 
            this.DestinationColumnHeader.Tag = "";
            this.DestinationColumnHeader.Text = "Destination";
            this.DestinationColumnHeader.Width = 120;
            // 
            // StartDateColumnHeader
            // 
            this.StartDateColumnHeader.Text = "Start Date";
            this.StartDateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartDateColumnHeader.Width = 117;
            // 
            // FinishDateColumnHeader
            // 
            this.FinishDateColumnHeader.Text = "Finish Date";
            this.FinishDateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinishDateColumnHeader.Width = 125;
            // 
            // GuideColumnHeader
            // 
            this.GuideColumnHeader.Text = "Guide";
            this.GuideColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GuideColumnHeader.Width = 152;
            // 
            // NumberOfSeatsColumnHeader
            // 
            this.NumberOfSeatsColumnHeader.Text = "Number of seats";
            this.NumberOfSeatsColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfSeatsColumnHeader.Width = 115;
            // 
            // PriceColumnHeader
            // 
            this.PriceColumnHeader.Text = "Price";
            this.PriceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceColumnHeader.Width = 105;
            // 
            // GuideComboBox
            // 
            this.GuideComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.GuideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GuideComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuideComboBox.FormattingEnabled = true;
            this.GuideComboBox.Location = new System.Drawing.Point(12, 240);
            this.GuideComboBox.Name = "GuideComboBox";
            this.GuideComboBox.Size = new System.Drawing.Size(184, 26);
            this.GuideComboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(9, 219);
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
            this.SearchTextBox.Location = new System.Drawing.Point(221, 37);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(184, 27);
            this.SearchTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(218, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search";
            // 
            // InfoTravelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuideComboBox);
            this.Controls.Add(this.TravelsListView);
            this.Controls.Add(this.CreateTravelButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Button CreateTravelButton;
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
    }
}