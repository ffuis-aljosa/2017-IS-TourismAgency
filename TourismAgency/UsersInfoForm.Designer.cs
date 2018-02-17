namespace TourismAgency
{
    partial class UsersInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersInfoForm));
            this.UsersListView = new System.Windows.Forms.ListView();
            this.NumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsernameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.ChangeUserInfoButton = new System.Windows.Forms.Button();
            this.CreateNewAdminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsersListView
            // 
            this.UsersListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UsersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumnHeader,
            this.UsernameColumnHeader,
            this.RoleColumnHeader,
            this.FirstNameColumnHeader,
            this.LastNameColumnHeader,
            this.DateOfBirthColumnHeader,
            this.EmailColumnHeader,
            this.PassportNumberColumnHeader,
            this.CitizenshipColumnHeader,
            this.CityColumnHeader,
            this.AdressColumnHeader,
            this.PhoneNumberColumnHeader});
            this.UsersListView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersListView.GridLines = true;
            this.UsersListView.Location = new System.Drawing.Point(12, 30);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(1362, 263);
            this.UsersListView.TabIndex = 0;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.View = System.Windows.Forms.View.Details;
            this.UsersListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.UsersListView_ColumnWidthChanging);
            // 
            // NumberColumnHeader
            // 
            this.NumberColumnHeader.Text = "No.";
            this.NumberColumnHeader.Width = 33;
            // 
            // UsernameColumnHeader
            // 
            this.UsernameColumnHeader.Text = "Username";
            this.UsernameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameColumnHeader.Width = 116;
            // 
            // RoleColumnHeader
            // 
            this.RoleColumnHeader.Text = "Role";
            this.RoleColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoleColumnHeader.Width = 68;
            // 
            // FirstNameColumnHeader
            // 
            this.FirstNameColumnHeader.Text = "First Name";
            this.FirstNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameColumnHeader.Width = 137;
            // 
            // LastNameColumnHeader
            // 
            this.LastNameColumnHeader.Text = "Last Name";
            this.LastNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameColumnHeader.Width = 150;
            // 
            // DateOfBirthColumnHeader
            // 
            this.DateOfBirthColumnHeader.Text = "Date of birth";
            this.DateOfBirthColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOfBirthColumnHeader.Width = 95;
            // 
            // EmailColumnHeader
            // 
            this.EmailColumnHeader.Text = "E-mail";
            this.EmailColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailColumnHeader.Width = 129;
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
            this.CitizenshipColumnHeader.Width = 113;
            // 
            // CityColumnHeader
            // 
            this.CityColumnHeader.Text = "City";
            this.CityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityColumnHeader.Width = 128;
            // 
            // AdressColumnHeader
            // 
            this.AdressColumnHeader.Text = "Adress";
            this.AdressColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdressColumnHeader.Width = 148;
            // 
            // PhoneNumberColumnHeader
            // 
            this.PhoneNumberColumnHeader.Text = "Phone number";
            this.PhoneNumberColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberColumnHeader.Width = 122;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(0, 459);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(1386, 46);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangeUserInfoButton
            // 
            this.ChangeUserInfoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChangeUserInfoButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeUserInfoButton.Location = new System.Drawing.Point(0, 413);
            this.ChangeUserInfoButton.Name = "ChangeUserInfoButton";
            this.ChangeUserInfoButton.Size = new System.Drawing.Size(1386, 46);
            this.ChangeUserInfoButton.TabIndex = 2;
            this.ChangeUserInfoButton.Text = "Change Existing User Info";
            this.ChangeUserInfoButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewAdminButton
            // 
            this.CreateNewAdminButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateNewAdminButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewAdminButton.Location = new System.Drawing.Point(0, 367);
            this.CreateNewAdminButton.Name = "CreateNewAdminButton";
            this.CreateNewAdminButton.Size = new System.Drawing.Size(1386, 46);
            this.CreateNewAdminButton.TabIndex = 3;
            this.CreateNewAdminButton.Text = "Create New Admin";
            this.CreateNewAdminButton.UseVisualStyleBackColor = true;
            this.CreateNewAdminButton.Click += new System.EventHandler(this.CreateNewAdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Users Info";
            // 
            // UsersInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1386, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateNewAdminButton);
            this.Controls.Add(this.ChangeUserInfoButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UsersListView);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ColumnHeader FirstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader LastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader DateOfBirthColumnHeader;
        private System.Windows.Forms.ColumnHeader EmailColumnHeader;
        private System.Windows.Forms.ColumnHeader PassportNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader CitizenshipColumnHeader;
        private System.Windows.Forms.ColumnHeader CityColumnHeader;
        private System.Windows.Forms.ColumnHeader AdressColumnHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader NumberColumnHeader;
        private System.Windows.Forms.ColumnHeader UsernameColumnHeader;
        private System.Windows.Forms.ColumnHeader RoleColumnHeader;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChangeUserInfoButton;
        private System.Windows.Forms.Button CreateNewAdminButton;
        private System.Windows.Forms.Label label1;
    }
}