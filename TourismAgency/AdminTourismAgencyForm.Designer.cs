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
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UsersInfoButton = new System.Windows.Forms.Button();
            this.TravelsInfoButton = new System.Windows.Forms.Button();
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
            this.toolStripButton1,
            this.HelpToolStripButton,
            this.LogoutToolStripButton});
            this.MainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(617, 37);
            this.MainToolStrip.TabIndex = 3;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 34);
            this.toolStripButton1.Text = "New admin";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // UsersInfoButton
            // 
            this.UsersInfoButton.Location = new System.Drawing.Point(65, 99);
            this.UsersInfoButton.Name = "UsersInfoButton";
            this.UsersInfoButton.Size = new System.Drawing.Size(193, 112);
            this.UsersInfoButton.TabIndex = 0;
            this.UsersInfoButton.Text = "Users info";
            this.UsersInfoButton.UseVisualStyleBackColor = true;
            this.UsersInfoButton.Click += new System.EventHandler(this.UsersInfoButton_Click);
            // 
            // TravelsInfoButton
            // 
            this.TravelsInfoButton.Location = new System.Drawing.Point(355, 99);
            this.TravelsInfoButton.Name = "TravelsInfoButton";
            this.TravelsInfoButton.Size = new System.Drawing.Size(193, 112);
            this.TravelsInfoButton.TabIndex = 2;
            this.TravelsInfoButton.Text = "Travels info";
            this.TravelsInfoButton.UseVisualStyleBackColor = true;
            this.TravelsInfoButton.Click += new System.EventHandler(this.TravelsInfoButton_Click);
            // 
            // AdminTourismAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 286);
            this.Controls.Add(this.TravelsInfoButton);
            this.Controls.Add(this.UsersInfoButton);
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
        private System.Windows.Forms.Button UsersInfoButton;
        private System.Windows.Forms.Button TravelsInfoButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}