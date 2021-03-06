﻿namespace TourismAgency
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
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddNewAdminToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClientsInfoButton = new System.Windows.Forms.Button();
            this.TravelsInfoButton = new System.Windows.Forms.Button();
            this.GuidesInfoButton = new System.Windows.Forms.Button();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainToolStrip.BackgroundImage")));
            this.MainToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainToolStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewAdminToolStripButton,
            this.HelpToolStripButton,
            this.LogoutToolStripButton});
            this.MainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(366, 37);
            this.MainToolStrip.TabIndex = 3;
            // 
            // AddNewAdminToolStripButton
            // 
            this.AddNewAdminToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNewAdminToolStripButton.Image")));
            this.AddNewAdminToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewAdminToolStripButton.Name = "AddNewAdminToolStripButton";
            this.AddNewAdminToolStripButton.Size = new System.Drawing.Size(81, 34);
            this.AddNewAdminToolStripButton.Text = "New admin";
            this.AddNewAdminToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddNewAdminToolStripButton.Click += new System.EventHandler(this.AddNewAdminToolStripButton_Click);
            // 
            // HelpToolStripButton
            // 
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(39, 34);
            this.HelpToolStripButton.Text = "Help";
            this.HelpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // LogoutToolStripButton
            // 
            this.LogoutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogoutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutToolStripButton.Image")));
            this.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutToolStripButton.Name = "LogoutToolStripButton";
            this.LogoutToolStripButton.Size = new System.Drawing.Size(55, 34);
            this.LogoutToolStripButton.Text = "Logout";
            this.LogoutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LogoutToolStripButton.Click += new System.EventHandler(this.LogoutToolStripButton_Click);
            // 
            // ClientsInfoButton
            // 
            this.ClientsInfoButton.Location = new System.Drawing.Point(66, 76);
            this.ClientsInfoButton.Name = "ClientsInfoButton";
            this.ClientsInfoButton.Size = new System.Drawing.Size(238, 90);
            this.ClientsInfoButton.TabIndex = 0;
            this.ClientsInfoButton.Text = "Clients info";
            this.ClientsInfoButton.UseVisualStyleBackColor = true;
            this.ClientsInfoButton.Click += new System.EventHandler(this.ClientsInfoButton_Click);
            // 
            // TravelsInfoButton
            // 
            this.TravelsInfoButton.Location = new System.Drawing.Point(66, 191);
            this.TravelsInfoButton.Name = "TravelsInfoButton";
            this.TravelsInfoButton.Size = new System.Drawing.Size(238, 90);
            this.TravelsInfoButton.TabIndex = 2;
            this.TravelsInfoButton.Text = "Travels info";
            this.TravelsInfoButton.UseVisualStyleBackColor = true;
            this.TravelsInfoButton.Click += new System.EventHandler(this.TravelsInfoButton_Click);
            // 
            // GuidesInfoButton
            // 
            this.GuidesInfoButton.Location = new System.Drawing.Point(66, 306);
            this.GuidesInfoButton.Name = "GuidesInfoButton";
            this.GuidesInfoButton.Size = new System.Drawing.Size(238, 90);
            this.GuidesInfoButton.TabIndex = 4;
            this.GuidesInfoButton.Text = "Guides info";
            this.GuidesInfoButton.UseVisualStyleBackColor = true;
            this.GuidesInfoButton.Click += new System.EventHandler(this.GuidesInfoButton_Click);
            // 
            // AdminTourismAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 432);
            this.Controls.Add(this.GuidesInfoButton);
            this.Controls.Add(this.TravelsInfoButton);
            this.Controls.Add(this.ClientsInfoButton);
            this.Controls.Add(this.MainToolStrip);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminTourismAgencyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tourism Agency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TourismAgencyForm_FormClosed);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton LogoutToolStripButton;
        private System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.Button ClientsInfoButton;
        private System.Windows.Forms.Button TravelsInfoButton;
        private System.Windows.Forms.ToolStripButton AddNewAdminToolStripButton;
        private System.Windows.Forms.Button GuidesInfoButton;
    }
}