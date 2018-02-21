namespace TourismAgency
{
    partial class ClientTourismAgencyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTourismAgencyForm));
            this.ClientFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TravelListPanel = new System.Windows.Forms.Panel();
            this.PhotoPanel1 = new System.Windows.Forms.Panel();
            this.PhotoPanel2 = new System.Windows.Forms.Panel();
            this.PhotoPanel3 = new System.Windows.Forms.Panel();
            this.PhotoPanel4 = new System.Windows.Forms.Panel();
            this.PreviousButton3 = new System.Windows.Forms.Button();
            this.TravellnfoButton3 = new System.Windows.Forms.Button();
            this.PreviousButton2 = new System.Windows.Forms.Button();
            this.NextButton2 = new System.Windows.Forms.Button();
            this.TravellnfoButton2 = new System.Windows.Forms.Button();
            this.PreviousButton1 = new System.Windows.Forms.Button();
            this.NextButton1 = new System.Windows.Forms.Button();
            this.TravelInfoButton1 = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.TravelInfoButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TravelsListView = new System.Windows.Forms.ListView();
            this.DestinationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinishDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuideColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfSeatsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhotoCollectionButton = new System.Windows.Forms.Button();
            this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientFormToolStrip.SuspendLayout();
            this.TravelListPanel.SuspendLayout();
            this.PhotoPanel1.SuspendLayout();
            this.PhotoPanel2.SuspendLayout();
            this.PhotoPanel3.SuspendLayout();
            this.PhotoPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientFormToolStrip
            // 
            this.ClientFormToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.ClientFormToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientFormToolStrip.BackgroundImage")));
            this.ClientFormToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientFormToolStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientFormToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ClientFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.ClientFormToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ClientFormToolStrip.Name = "ClientFormToolStrip";
            this.ClientFormToolStrip.Size = new System.Drawing.Size(820, 37);
            this.ClientFormToolStrip.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(45, 34);
            this.toolStripButton1.Text = "Login";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // TravelListPanel
            // 
            this.TravelListPanel.BackgroundImage = global::TourismAgency.Properties.Resources.ClientForm;
            this.TravelListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TravelListPanel.Controls.Add(this.PhotoPanel1);
            this.TravelListPanel.Controls.Add(this.SearchLabel);
            this.TravelListPanel.Controls.Add(this.SearchTextBox);
            this.TravelListPanel.Controls.Add(this.TravelsListView);
            this.TravelListPanel.Controls.Add(this.PhotoCollectionButton);
            this.TravelListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TravelListPanel.Location = new System.Drawing.Point(0, 37);
            this.TravelListPanel.Name = "TravelListPanel";
            this.TravelListPanel.Size = new System.Drawing.Size(820, 344);
            this.TravelListPanel.TabIndex = 1;
            // 
            // PhotoPanel1
            // 
            this.PhotoPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhotoPanel1.BackgroundImage")));
            this.PhotoPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PhotoPanel1.Controls.Add(this.PhotoPanel2);
            this.PhotoPanel1.Controls.Add(this.NextButton);
            this.PhotoPanel1.Controls.Add(this.TravelInfoButton);
            this.PhotoPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoPanel1.Location = new System.Drawing.Point(0, 0);
            this.PhotoPanel1.Name = "PhotoPanel1";
            this.PhotoPanel1.Size = new System.Drawing.Size(820, 344);
            this.PhotoPanel1.TabIndex = 21;
            this.PhotoPanel1.Visible = false;
            // 
            // PhotoPanel2
            // 
            this.PhotoPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhotoPanel2.BackgroundImage")));
            this.PhotoPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PhotoPanel2.Controls.Add(this.PhotoPanel3);
            this.PhotoPanel2.Controls.Add(this.PreviousButton1);
            this.PhotoPanel2.Controls.Add(this.NextButton1);
            this.PhotoPanel2.Controls.Add(this.TravelInfoButton1);
            this.PhotoPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoPanel2.Location = new System.Drawing.Point(0, 0);
            this.PhotoPanel2.Name = "PhotoPanel2";
            this.PhotoPanel2.Size = new System.Drawing.Size(820, 344);
            this.PhotoPanel2.TabIndex = 3;
            this.PhotoPanel2.Visible = false;
            // 
            // PhotoPanel3
            // 
            this.PhotoPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhotoPanel3.BackgroundImage")));
            this.PhotoPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PhotoPanel3.Controls.Add(this.PhotoPanel4);
            this.PhotoPanel3.Controls.Add(this.PreviousButton2);
            this.PhotoPanel3.Controls.Add(this.NextButton2);
            this.PhotoPanel3.Controls.Add(this.TravellnfoButton2);
            this.PhotoPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoPanel3.Location = new System.Drawing.Point(0, 0);
            this.PhotoPanel3.Name = "PhotoPanel3";
            this.PhotoPanel3.Size = new System.Drawing.Size(820, 344);
            this.PhotoPanel3.TabIndex = 3;
            this.PhotoPanel3.Visible = false;
            // 
            // PhotoPanel4
            // 
            this.PhotoPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhotoPanel4.BackgroundImage")));
            this.PhotoPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PhotoPanel4.Controls.Add(this.PreviousButton3);
            this.PhotoPanel4.Controls.Add(this.TravellnfoButton3);
            this.PhotoPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoPanel4.Location = new System.Drawing.Point(0, 0);
            this.PhotoPanel4.Name = "PhotoPanel4";
            this.PhotoPanel4.Size = new System.Drawing.Size(820, 344);
            this.PhotoPanel4.TabIndex = 3;
            this.PhotoPanel4.Visible = false;
            // 
            // PreviousButton3
            // 
            this.PreviousButton3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton3.Location = new System.Drawing.Point(300, 301);
            this.PreviousButton3.Name = "PreviousButton3";
            this.PreviousButton3.Size = new System.Drawing.Size(76, 30);
            this.PreviousButton3.TabIndex = 2;
            this.PreviousButton3.Text = "Previous";
            this.PreviousButton3.UseVisualStyleBackColor = true;
            this.PreviousButton3.Click += new System.EventHandler(this.PreviousButton3_Click);
            // 
            // TravellnfoButton3
            // 
            this.TravellnfoButton3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravellnfoButton3.Location = new System.Drawing.Point(639, 16);
            this.TravellnfoButton3.Name = "TravellnfoButton3";
            this.TravellnfoButton3.Size = new System.Drawing.Size(169, 63);
            this.TravellnfoButton3.TabIndex = 0;
            this.TravellnfoButton3.Text = "See travel offers";
            this.TravellnfoButton3.UseVisualStyleBackColor = true;
            this.TravellnfoButton3.Click += new System.EventHandler(this.TravellnfoButton3_Click);
            // 
            // PreviousButton2
            // 
            this.PreviousButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton2.Location = new System.Drawing.Point(300, 301);
            this.PreviousButton2.Name = "PreviousButton2";
            this.PreviousButton2.Size = new System.Drawing.Size(76, 30);
            this.PreviousButton2.TabIndex = 2;
            this.PreviousButton2.Text = "Previous";
            this.PreviousButton2.UseVisualStyleBackColor = true;
            this.PreviousButton2.Click += new System.EventHandler(this.PreviousButton2_Click);
            // 
            // NextButton2
            // 
            this.NextButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton2.Location = new System.Drawing.Point(432, 301);
            this.NextButton2.Name = "NextButton2";
            this.NextButton2.Size = new System.Drawing.Size(76, 30);
            this.NextButton2.TabIndex = 1;
            this.NextButton2.Text = "Next";
            this.NextButton2.UseVisualStyleBackColor = true;
            this.NextButton2.Click += new System.EventHandler(this.NextButton2_Click);
            // 
            // TravellnfoButton2
            // 
            this.TravellnfoButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravellnfoButton2.Location = new System.Drawing.Point(639, 16);
            this.TravellnfoButton2.Name = "TravellnfoButton2";
            this.TravellnfoButton2.Size = new System.Drawing.Size(169, 63);
            this.TravellnfoButton2.TabIndex = 0;
            this.TravellnfoButton2.Text = "See travel offers";
            this.TravellnfoButton2.UseVisualStyleBackColor = true;
            this.TravellnfoButton2.Click += new System.EventHandler(this.TravellnfoButton2_Click);
            // 
            // PreviousButton1
            // 
            this.PreviousButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton1.Location = new System.Drawing.Point(300, 301);
            this.PreviousButton1.Name = "PreviousButton1";
            this.PreviousButton1.Size = new System.Drawing.Size(76, 30);
            this.PreviousButton1.TabIndex = 2;
            this.PreviousButton1.Text = "Previous";
            this.PreviousButton1.UseVisualStyleBackColor = true;
            this.PreviousButton1.Click += new System.EventHandler(this.PreviousButton1_Click);
            // 
            // NextButton1
            // 
            this.NextButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton1.Location = new System.Drawing.Point(432, 301);
            this.NextButton1.Name = "NextButton1";
            this.NextButton1.Size = new System.Drawing.Size(76, 30);
            this.NextButton1.TabIndex = 1;
            this.NextButton1.Text = "Next";
            this.NextButton1.UseVisualStyleBackColor = true;
            this.NextButton1.Click += new System.EventHandler(this.NextButton1_Click);
            // 
            // TravelInfoButton1
            // 
            this.TravelInfoButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelInfoButton1.Location = new System.Drawing.Point(639, 16);
            this.TravelInfoButton1.Name = "TravelInfoButton1";
            this.TravelInfoButton1.Size = new System.Drawing.Size(169, 63);
            this.TravelInfoButton1.TabIndex = 0;
            this.TravelInfoButton1.Text = "See travel offers";
            this.TravelInfoButton1.UseVisualStyleBackColor = true;
            this.TravelInfoButton1.Click += new System.EventHandler(this.TravelInfoButton1_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(432, 301);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(76, 30);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // TravelInfoButton
            // 
            this.TravelInfoButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelInfoButton.Location = new System.Drawing.Point(639, 16);
            this.TravelInfoButton.Name = "TravelInfoButton";
            this.TravelInfoButton.Size = new System.Drawing.Size(169, 63);
            this.TravelInfoButton.TabIndex = 0;
            this.TravelInfoButton.Text = "See travel offers";
            this.TravelInfoButton.UseVisualStyleBackColor = true;
            this.TravelInfoButton.Click += new System.EventHandler(this.TravelInfoButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(40, 73);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(62, 18);
            this.SearchLabel.TabIndex = 20;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchTextBox.Location = new System.Drawing.Point(43, 94);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(184, 27);
            this.SearchTextBox.TabIndex = 19;
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
            this.TravelsListView.Location = new System.Drawing.Point(43, 127);
            this.TravelsListView.Name = "TravelsListView";
            this.TravelsListView.Size = new System.Drawing.Size(738, 205);
            this.TravelsListView.TabIndex = 16;
            this.TravelsListView.UseCompatibleStateImageBehavior = false;
            this.TravelsListView.View = System.Windows.Forms.View.Details;
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
            this.GuideColumnHeader.Width = 152;
            // 
            // NumberOfSeatsColumnHeader
            // 
            this.NumberOfSeatsColumnHeader.Text = "Number of seats";
            this.NumberOfSeatsColumnHeader.Width = 115;
            // 
            // PriceColumnHeader
            // 
            this.PriceColumnHeader.Text = "Price";
            this.PriceColumnHeader.Width = 105;
            // 
            // PhotoCollectionButton
            // 
            this.PhotoCollectionButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhotoCollectionButton.Location = new System.Drawing.Point(632, 16);
            this.PhotoCollectionButton.Name = "PhotoCollectionButton";
            this.PhotoCollectionButton.Size = new System.Drawing.Size(169, 63);
            this.PhotoCollectionButton.TabIndex = 1;
            this.PhotoCollectionButton.Text = "See Photo Collection";
            this.PhotoCollectionButton.UseVisualStyleBackColor = true;
            this.PhotoCollectionButton.Click += new System.EventHandler(this.PhotoCollectionButton_Click);
            // 
            // IdColumnHeader
            // 
            this.IdColumnHeader.Text = "Id";
            // 
            // ClientTourismAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 381);
            this.Controls.Add(this.TravelListPanel);
            this.Controls.Add(this.ClientFormToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientTourismAgencyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tourism agency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientTourismAgencyForm_FormClosed);
            this.ClientFormToolStrip.ResumeLayout(false);
            this.ClientFormToolStrip.PerformLayout();
            this.TravelListPanel.ResumeLayout(false);
            this.TravelListPanel.PerformLayout();
            this.PhotoPanel1.ResumeLayout(false);
            this.PhotoPanel2.ResumeLayout(false);
            this.PhotoPanel3.ResumeLayout(false);
            this.PhotoPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ClientFormToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel TravelListPanel;
        private System.Windows.Forms.Button PhotoCollectionButton;
        private System.Windows.Forms.ListView TravelsListView;
        private System.Windows.Forms.ColumnHeader DestinationColumnHeader;
        private System.Windows.Forms.ColumnHeader StartDateColumnHeader;
        private System.Windows.Forms.ColumnHeader FinishDateColumnHeader;
        private System.Windows.Forms.ColumnHeader GuideColumnHeader;
        private System.Windows.Forms.ColumnHeader NumberOfSeatsColumnHeader;
        private System.Windows.Forms.ColumnHeader PriceColumnHeader;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel PhotoPanel1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button TravelInfoButton;
        private System.Windows.Forms.Panel PhotoPanel2;
        private System.Windows.Forms.Button TravelInfoButton1;
        private System.Windows.Forms.Button PreviousButton1;
        private System.Windows.Forms.Button NextButton1;
        private System.Windows.Forms.Panel PhotoPanel3;
        private System.Windows.Forms.Button PreviousButton2;
        private System.Windows.Forms.Button NextButton2;
        private System.Windows.Forms.Button TravellnfoButton2;
        private System.Windows.Forms.Panel PhotoPanel4;
        private System.Windows.Forms.Button TravellnfoButton3;
        private System.Windows.Forms.Button PreviousButton3;
        private System.Windows.Forms.ColumnHeader IdColumnHeader;
    }
}