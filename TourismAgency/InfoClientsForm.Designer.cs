namespace TourismAgency
{
    partial class InfoClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoClientsForm));
            this.ClientsListView = new System.Windows.Forms.ListView();
            this.FirstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirthColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassportNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CitizenshipColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddNewClientButton = new System.Windows.Forms.Button();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PassportNumberTextBox = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.CitizenshipTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLlabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PassportNumberLabel = new System.Windows.Forms.Label();
            this.CitizenshipLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ClientsListView
            // 
            this.ClientsListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumnHeader,
            this.LastNameColumnHeader,
            this.DateOfBirthColumnHeader,
            this.EmailColumnHeader,
            this.PassportNumberColumnHeader,
            this.CitizenshipColumnHeader,
            this.CityColumnHeader,
            this.AdressColumnHeader,
            this.PhoneNumberColumnHeader});
            this.ClientsListView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsListView.GridLines = true;
            this.ClientsListView.Location = new System.Drawing.Point(224, 88);
            this.ClientsListView.Name = "ClientsListView";
            this.ClientsListView.Size = new System.Drawing.Size(747, 536);
            this.ClientsListView.TabIndex = 0;
            this.ClientsListView.UseCompatibleStateImageBehavior = false;
            this.ClientsListView.View = System.Windows.Forms.View.Details;
            this.ClientsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.UsersListView_ColumnWidthChanging);
            this.ClientsListView.Click += new System.EventHandler(this.ClientsListView_Click);
            // 
            // FirstNameColumnHeader
            // 
            this.FirstNameColumnHeader.Text = "First Name";
            this.FirstNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameColumnHeader.Width = 110;
            // 
            // LastNameColumnHeader
            // 
            this.LastNameColumnHeader.Text = "Last Name";
            this.LastNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameColumnHeader.Width = 131;
            // 
            // DateOfBirthColumnHeader
            // 
            this.DateOfBirthColumnHeader.Text = "Date of birth";
            this.DateOfBirthColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOfBirthColumnHeader.Width = 110;
            // 
            // EmailColumnHeader
            // 
            this.EmailColumnHeader.Text = "E-mail";
            this.EmailColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailColumnHeader.Width = 167;
            // 
            // PassportNumberColumnHeader
            // 
            this.PassportNumberColumnHeader.Text = "Passport number";
            this.PassportNumberColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassportNumberColumnHeader.Width = 123;
            // 
            // CitizenshipColumnHeader
            // 
            this.CitizenshipColumnHeader.Text = "Citizenship";
            this.CitizenshipColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CitizenshipColumnHeader.Width = 119;
            // 
            // CityColumnHeader
            // 
            this.CityColumnHeader.Text = "City";
            this.CityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityColumnHeader.Width = 145;
            // 
            // AdressColumnHeader
            // 
            this.AdressColumnHeader.Text = "Adress";
            this.AdressColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdressColumnHeader.Width = 159;
            // 
            // PhoneNumberColumnHeader
            // 
            this.PhoneNumberColumnHeader.Text = "Phone number";
            this.PhoneNumberColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberColumnHeader.Width = 121;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 579);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 45);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(12, 528);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(184, 45);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AddNewClientButton
            // 
            this.AddNewClientButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewClientButton.Location = new System.Drawing.Point(12, 477);
            this.AddNewClientButton.Name = "AddNewClientButton";
            this.AddNewClientButton.Size = new System.Drawing.Size(184, 45);
            this.AddNewClientButton.TabIndex = 9;
            this.AddNewClientButton.Text = "Add New Client";
            this.AddNewClientButton.UseVisualStyleBackColor = true;
            this.AddNewClientButton.Click += new System.EventHandler(this.AddNewClientButton_Click);
            // 
            // ClientsLabel
            // 
            this.ClientsLabel.AutoSize = true;
            this.ClientsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsLabel.Location = new System.Drawing.Point(221, 67);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(65, 18);
            this.ClientsLabel.TabIndex = 4;
            this.ClientsLabel.Text = "Clients";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(12, 37);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(184, 27);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(12, 190);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(184, 27);
            this.EmailTextBox.TabIndex = 3;
            // 
            // CityTextBox
            // 
            this.CityTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityTextBox.Location = new System.Drawing.Point(12, 342);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(184, 27);
            this.CityTextBox.TabIndex = 6;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(12, 88);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(184, 27);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // PassportNumberTextBox
            // 
            this.PassportNumberTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PassportNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassportNumberTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassportNumberTextBox.Location = new System.Drawing.Point(12, 241);
            this.PassportNumberTextBox.Name = "PassportNumberTextBox";
            this.PassportNumberTextBox.Size = new System.Drawing.Size(184, 27);
            this.PassportNumberTextBox.TabIndex = 4;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AdressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressTextBox.Location = new System.Drawing.Point(12, 393);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(184, 27);
            this.AdressTextBox.TabIndex = 7;
            // 
            // CitizenshipTextBox
            // 
            this.CitizenshipTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CitizenshipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CitizenshipTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitizenshipTextBox.Location = new System.Drawing.Point(12, 292);
            this.CitizenshipTextBox.Name = "CitizenshipTextBox";
            this.CitizenshipTextBox.Size = new System.Drawing.Size(184, 27);
            this.CitizenshipTextBox.TabIndex = 5;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(12, 444);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(184, 27);
            this.PhoneNumberTextBox.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(8, 16);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(97, 18);
            this.FirstNameLabel.TabIndex = 13;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLlabel
            // 
            this.LastNameLlabel.AutoSize = true;
            this.LastNameLlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLlabel.Location = new System.Drawing.Point(9, 67);
            this.LastNameLlabel.Name = "LastNameLlabel";
            this.LastNameLlabel.Size = new System.Drawing.Size(96, 18);
            this.LastNameLlabel.TabIndex = 14;
            this.LastNameLlabel.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(9, 169);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(60, 18);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "E-mail";
            // 
            // PassportNumberLabel
            // 
            this.PassportNumberLabel.AutoSize = true;
            this.PassportNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassportNumberLabel.Location = new System.Drawing.Point(9, 220);
            this.PassportNumberLabel.Name = "PassportNumberLabel";
            this.PassportNumberLabel.Size = new System.Drawing.Size(146, 18);
            this.PassportNumberLabel.TabIndex = 16;
            this.PassportNumberLabel.Text = "Passport number";
            // 
            // CitizenshipLabel
            // 
            this.CitizenshipLabel.AutoSize = true;
            this.CitizenshipLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitizenshipLabel.Location = new System.Drawing.Point(9, 271);
            this.CitizenshipLabel.Name = "CitizenshipLabel";
            this.CitizenshipLabel.Size = new System.Drawing.Size(99, 18);
            this.CitizenshipLabel.TabIndex = 17;
            this.CitizenshipLabel.Text = "Citizenship";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(9, 321);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(40, 18);
            this.CityLabel.TabIndex = 18;
            this.CityLabel.Text = "City";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabel.Location = new System.Drawing.Point(9, 372);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(63, 18);
            this.AdressLabel.TabIndex = 19;
            this.AdressLabel.Text = "Adress";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(9, 423);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(127, 18);
            this.PhoneNumberLabel.TabIndex = 20;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date of birth";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(224, 37);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(184, 27);
            this.SearchTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search";
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(13, 140);
            this.DateOfBirthDateTimePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.DateOfBirthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(183, 27);
            this.DateOfBirthDateTimePicker.TabIndex = 2;
            this.DateOfBirthDateTimePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // InfoClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 649);
            this.Controls.Add(this.DateOfBirthDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CitizenshipLabel);
            this.Controls.Add(this.PassportNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameLlabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.CitizenshipTextBox);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.PassportNumberTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ClientsLabel);
            this.Controls.Add(this.AddNewClientButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClientsListView);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ClientsListView;
        private System.Windows.Forms.ColumnHeader FirstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader LastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader DateOfBirthColumnHeader;
        private System.Windows.Forms.ColumnHeader EmailColumnHeader;
        private System.Windows.Forms.ColumnHeader PassportNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader CitizenshipColumnHeader;
        private System.Windows.Forms.ColumnHeader CityColumnHeader;
        private System.Windows.Forms.ColumnHeader AdressColumnHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberColumnHeader;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddNewClientButton;
        private System.Windows.Forms.Label ClientsLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox PassportNumberTextBox;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.TextBox CitizenshipTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLlabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PassportNumberLabel;
        private System.Windows.Forms.Label CitizenshipLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
    }
}