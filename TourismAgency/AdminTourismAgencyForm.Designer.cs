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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TravelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UsersToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addNewAdminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TravelToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addNewTravelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.changeTravelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.AdminToolStripMenuItem,
            this.TravelsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.LogOutToolStripMenuItem.Text = "Log out";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewAdminToolStripMenuItem});
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.AdminToolStripMenuItem.Text = "Admins";
            // 
            // AddNewAdminToolStripMenuItem
            // 
            this.AddNewAdminToolStripMenuItem.Name = "AddNewAdminToolStripMenuItem";
            this.AddNewAdminToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.AddNewAdminToolStripMenuItem.Text = "Add new admin";
            // 
            // TravelsToolStripMenuItem
            // 
            this.TravelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewTravelToolStripMenuItem});
            this.TravelsToolStripMenuItem.Name = "TravelsToolStripMenuItem";
            this.TravelsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.TravelsToolStripMenuItem.Text = "Travels";
            // 
            // AddNewTravelToolStripMenuItem
            // 
            this.AddNewTravelToolStripMenuItem.Name = "AddNewTravelToolStripMenuItem";
            this.AddNewTravelToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.AddNewTravelToolStripMenuItem.Text = "Add new travel";
            this.AddNewTravelToolStripMenuItem.Click += new System.EventHandler(this.AddNewTravelToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutToolStripButton,
            this.UsersToolStripDropDownButton,
            this.TravelToolStripDropDownButton,
            this.HelpToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainToolStrip.Size = new System.Drawing.Size(754, 25);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // LogoutToolStripButton
            // 
            this.LogoutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogoutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutToolStripButton.Image")));
            this.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutToolStripButton.Name = "LogoutToolStripButton";
            this.LogoutToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogoutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LogoutToolStripButton.Text = "Logout";
            // 
            // UsersToolStripDropDownButton
            // 
            this.UsersToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UsersToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAdminToolStripMenuItem1,
            this.changeClientInfoToolStripMenuItem});
            this.UsersToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("UsersToolStripDropDownButton.Image")));
            this.UsersToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsersToolStripDropDownButton.Name = "UsersToolStripDropDownButton";
            this.UsersToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.UsersToolStripDropDownButton.Text = "Users";
            // 
            // addNewAdminToolStripMenuItem1
            // 
            this.addNewAdminToolStripMenuItem1.Name = "addNewAdminToolStripMenuItem1";
            this.addNewAdminToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.addNewAdminToolStripMenuItem1.Text = "Add new admin";
            // 
            // changeClientInfoToolStripMenuItem
            // 
            this.changeClientInfoToolStripMenuItem.Name = "changeClientInfoToolStripMenuItem";
            this.changeClientInfoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changeClientInfoToolStripMenuItem.Text = "Change client info";
            // 
            // TravelToolStripDropDownButton
            // 
            this.TravelToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TravelToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTravelToolStripMenuItem1,
            this.changeTravelInfoToolStripMenuItem});
            this.TravelToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("TravelToolStripDropDownButton.Image")));
            this.TravelToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TravelToolStripDropDownButton.Name = "TravelToolStripDropDownButton";
            this.TravelToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.TravelToolStripDropDownButton.Text = "Travels";
            // 
            // addNewTravelToolStripMenuItem1
            // 
            this.addNewTravelToolStripMenuItem1.Name = "addNewTravelToolStripMenuItem1";
            this.addNewTravelToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.addNewTravelToolStripMenuItem1.Text = "Add new travel";
            // 
            // HelpToolStripButton
            // 
            this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HelpToolStripButton.Text = "Help";
            // 
            // changeTravelInfoToolStripMenuItem
            // 
            this.changeTravelInfoToolStripMenuItem.Name = "changeTravelInfoToolStripMenuItem";
            this.changeTravelInfoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changeTravelInfoToolStripMenuItem.Text = "Change travel info";
            // 
            // AdminTourismAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 440);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminTourismAgencyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tourism Agency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TourismAgencyForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TravelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton LogoutToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton UsersToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addNewAdminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton TravelToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addNewTravelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem changeTravelInfoToolStripMenuItem;
    }
}