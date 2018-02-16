namespace TourismAgency
{
    partial class AdminTourismAgencyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTourismAgencyForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.UsersTabPage = new System.Windows.Forms.TabPage();
            this.AddNewAdminButton = new System.Windows.Forms.Button();
            this.UsersListView = new System.Windows.Forms.ListView();
            this.NumberUsersColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsernameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirthColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassportNumberColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CitizenshipColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TravelsTabPage = new System.Windows.Forms.TabPage();
            this.AddNewTravelButton = new System.Windows.Forms.Button();
            this.TravelListView = new System.Windows.Forms.ListView();
            this.NumberTravelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinishDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TouristGuideColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainTabControl.SuspendLayout();
            this.UsersTabPage.SuspendLayout();
            this.TravelsTabPage.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.UsersTabPage);
            this.MainTabControl.Controls.Add(this.TravelsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainTabControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 28);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1184, 480);
            this.MainTabControl.TabIndex = 2;
            // 
            // UsersTabPage
            // 
            this.UsersTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsersTabPage.Controls.Add(this.AddNewAdminButton);
            this.UsersTabPage.Controls.Add(this.UsersListView);
            this.UsersTabPage.Location = new System.Drawing.Point(4, 25);
            this.UsersTabPage.Name = "UsersTabPage";
            this.UsersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTabPage.Size = new System.Drawing.Size(1176, 451);
            this.UsersTabPage.TabIndex = 0;
            this.UsersTabPage.Text = "Users";
            // 
            // AddNewAdminButton
            // 
            this.AddNewAdminButton.Location = new System.Drawing.Point(8, 309);
            this.AddNewAdminButton.Name = "AddNewAdminButton";
            this.AddNewAdminButton.Size = new System.Drawing.Size(164, 47);
            this.AddNewAdminButton.TabIndex = 1;
            this.AddNewAdminButton.Text = "Create new admin";
            this.AddNewAdminButton.UseVisualStyleBackColor = true;
            this.AddNewAdminButton.Click += new System.EventHandler(this.AddNewAdminButton_Click);
            // 
            // UsersListView
            // 
            this.UsersListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberUsersColumnHeader,
            this.UsernameColumnHeader,
            this.RoleColumnHeader,
            this.FirstNameColumnHeader,
            this.LastNameColumnHeader,
            this.DateOfBirthColumnHeader,
            this.EmailColumnHeader,
            this.PassportNumberColumnHeader1,
            this.CitizenshipColumnHeader,
            this.CityColumnHeader,
            this.AdressColumnHeader,
            this.PhoneNumberColumnHeader});
            this.UsersListView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersListView.GridLines = true;
            this.UsersListView.Location = new System.Drawing.Point(0, 39);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(1109, 214);
            this.UsersListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.UsersListView.TabIndex = 0;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.View = System.Windows.Forms.View.Details;
            // 
            // NumberUsersColumnHeader
            // 
            this.NumberUsersColumnHeader.Text = "No.";
            this.NumberUsersColumnHeader.Width = 37;
            // 
            // UsernameColumnHeader
            // 
            this.UsernameColumnHeader.Text = "Username";
            this.UsernameColumnHeader.Width = 90;
            // 
            // RoleColumnHeader
            // 
            this.RoleColumnHeader.Text = "Role";
            this.RoleColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoleColumnHeader.Width = 65;
            // 
            // FirstNameColumnHeader
            // 
            this.FirstNameColumnHeader.Text = "First Name";
            this.FirstNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameColumnHeader.Width = 90;
            // 
            // LastNameColumnHeader
            // 
            this.LastNameColumnHeader.Text = "Last Name";
            this.LastNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameColumnHeader.Width = 90;
            // 
            // DateOfBirthColumnHeader
            // 
            this.DateOfBirthColumnHeader.Text = "Date of birth";
            this.DateOfBirthColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOfBirthColumnHeader.Width = 90;
            // 
            // EmailColumnHeader
            // 
            this.EmailColumnHeader.Text = "E-mail";
            this.EmailColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailColumnHeader.Width = 100;
            // 
            // PassportNumberColumnHeader1
            // 
            this.PassportNumberColumnHeader1.Text = "Passport number";
            this.PassportNumberColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassportNumberColumnHeader1.Width = 130;
            // 
            // CitizenshipColumnHeader
            // 
            this.CitizenshipColumnHeader.Text = "Citizenship";
            this.CitizenshipColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CitizenshipColumnHeader.Width = 101;
            // 
            // CityColumnHeader
            // 
            this.CityColumnHeader.Text = "City";
            this.CityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityColumnHeader.Width = 118;
            // 
            // AdressColumnHeader
            // 
            this.AdressColumnHeader.Text = "Adress";
            this.AdressColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdressColumnHeader.Width = 125;
            // 
            // PhoneNumberColumnHeader
            // 
            this.PhoneNumberColumnHeader.Text = "Phone number";
            this.PhoneNumberColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberColumnHeader.Width = 128;
            // 
            // TravelsTabPage
            // 
            this.TravelsTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TravelsTabPage.Controls.Add(this.AddNewTravelButton);
            this.TravelsTabPage.Controls.Add(this.TravelListView);
            this.TravelsTabPage.Location = new System.Drawing.Point(4, 25);
            this.TravelsTabPage.Name = "TravelsTabPage";
            this.TravelsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TravelsTabPage.Size = new System.Drawing.Size(1176, 451);
            this.TravelsTabPage.TabIndex = 1;
            this.TravelsTabPage.Text = "Travels";
            // 
            // AddNewTravelButton
            // 
            this.AddNewTravelButton.Location = new System.Drawing.Point(8, 310);
            this.AddNewTravelButton.Name = "AddNewTravelButton";
            this.AddNewTravelButton.Size = new System.Drawing.Size(136, 44);
            this.AddNewTravelButton.TabIndex = 1;
            this.AddNewTravelButton.Text = "Add new travel";
            this.AddNewTravelButton.UseVisualStyleBackColor = true;
            this.AddNewTravelButton.Click += new System.EventHandler(this.AddNewTravelButton_Click);
            // 
            // TravelListView
            // 
            this.TravelListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TravelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberTravelColumnHeader,
            this.DestinationColumnHeader,
            this.StartDateColumnHeader,
            this.FinishDateColumnHeader,
            this.BusColumnHeader,
            this.TouristGuideColumnHeader});
            this.TravelListView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelListView.GridLines = true;
            this.TravelListView.Location = new System.Drawing.Point(0, 36);
            this.TravelListView.Name = "TravelListView";
            this.TravelListView.Size = new System.Drawing.Size(798, 256);
            this.TravelListView.TabIndex = 0;
            this.TravelListView.UseCompatibleStateImageBehavior = false;
            this.TravelListView.View = System.Windows.Forms.View.Details;
            // 
            // NumberTravelColumnHeader
            // 
            this.NumberTravelColumnHeader.Text = "No.";
            this.NumberTravelColumnHeader.Width = 46;
            // 
            // DestinationColumnHeader
            // 
            this.DestinationColumnHeader.Text = "Destination";
            this.DestinationColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DestinationColumnHeader.Width = 197;
            // 
            // StartDateColumnHeader
            // 
            this.StartDateColumnHeader.Text = "Start Date";
            this.StartDateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartDateColumnHeader.Width = 116;
            // 
            // FinishDateColumnHeader
            // 
            this.FinishDateColumnHeader.Text = "Finish date";
            this.FinishDateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinishDateColumnHeader.Width = 112;
            // 
            // BusColumnHeader
            // 
            this.BusColumnHeader.Text = "Bus ";
            this.BusColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BusColumnHeader.Width = 130;
            // 
            // TouristGuideColumnHeader
            // 
            this.TouristGuideColumnHeader.Text = "Tourist guide";
            this.TouristGuideColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TouristGuideColumnHeader.Width = 193;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutToolStripButton,
            this.HelpToolStripButton});
            this.MainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainToolStrip.Size = new System.Drawing.Size(1184, 25);
            this.MainToolStrip.TabIndex = 3;
            // 
            // LogoutToolStripButton
            // 
            this.LogoutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogoutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutToolStripButton.Image")));
            this.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutToolStripButton.Name = "LogoutToolStripButton";
            this.LogoutToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.LogoutToolStripButton.Text = "Logout";
            // 
            // HelpToolStripButton
            // 
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(55, 22);
            this.HelpToolStripButton.Text = "Help";
            // 
            // AdminTourismAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 508);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminTourismAgencyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tourism Agency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TourismAgencyForm_FormClosed);
            this.MainTabControl.ResumeLayout(false);
            this.UsersTabPage.ResumeLayout(false);
            this.TravelsTabPage.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage UsersTabPage;
        private System.Windows.Forms.TabPage TravelsTabPage;
        private System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ColumnHeader UsernameColumnHeader;
        private System.Windows.Forms.ColumnHeader RoleColumnHeader;
        private System.Windows.Forms.ColumnHeader FirstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader LastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader DateOfBirthColumnHeader;
        private System.Windows.Forms.ColumnHeader EmailColumnHeader;
        private System.Windows.Forms.ColumnHeader PassportNumberColumnHeader1;
        private System.Windows.Forms.ColumnHeader CitizenshipColumnHeader;
        private System.Windows.Forms.ColumnHeader CityColumnHeader;
        private System.Windows.Forms.ColumnHeader AdressColumnHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberColumnHeader;
        private System.Windows.Forms.ListView TravelListView;
        private System.Windows.Forms.ColumnHeader DestinationColumnHeader;
        private System.Windows.Forms.ColumnHeader StartDateColumnHeader;
        private System.Windows.Forms.ColumnHeader FinishDateColumnHeader;
        private System.Windows.Forms.ColumnHeader BusColumnHeader;
        private System.Windows.Forms.ColumnHeader TouristGuideColumnHeader;
        private System.Windows.Forms.ColumnHeader NumberUsersColumnHeader;
        private System.Windows.Forms.ColumnHeader NumberTravelColumnHeader;
        private System.Windows.Forms.Button AddNewAdminButton;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton LogoutToolStripButton;
        private System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.Button AddNewTravelButton;
    }
}