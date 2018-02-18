namespace TourismAgency
{
    partial class TravelsInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelsInfoForm));
            this.TravelsListView = new System.Windows.Forms.ListView();
            this.NumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinishDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SeatsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GuideColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChangeTravelInfoButton = new System.Windows.Forms.Button();
            this.AddNewTravelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TravelsListView
            // 
            this.TravelsListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TravelsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TravelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumnHeader,
            this.DestinationColumnHeader,
            this.StartDateColumnHeader,
            this.FinishDateColumnHeader,
            this.GuideColumnHeader,
            this.SeatsColumnHeader,
            this.PriceColumnHeader});
            this.TravelsListView.GridLines = true;
            this.TravelsListView.Location = new System.Drawing.Point(12, 30);
            this.TravelsListView.Name = "TravelsListView";
            this.TravelsListView.Size = new System.Drawing.Size(824, 175);
            this.TravelsListView.TabIndex = 0;
            this.TravelsListView.UseCompatibleStateImageBehavior = false;
            this.TravelsListView.View = System.Windows.Forms.View.Details;
            this.TravelsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.TravelsListView_ColumnWidthChanging);
            // 
            // NumberColumnHeader
            // 
            this.NumberColumnHeader.Text = "No.";
            this.NumberColumnHeader.Width = 38;
            // 
            // DestinationColumnHeader
            // 
            this.DestinationColumnHeader.Text = "Destination";
            this.DestinationColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DestinationColumnHeader.Width = 164;
            // 
            // StartDateColumnHeader
            // 
            this.StartDateColumnHeader.Text = "Start Date";
            this.StartDateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartDateColumnHeader.Width = 100;
            // 
            // FinishDateColumnHeader
            // 
            this.FinishDateColumnHeader.Text = "Finish Date";
            this.FinishDateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinishDateColumnHeader.Width = 103;
            // 
            // SeatsColumnHeader
            // 
            this.SeatsColumnHeader.Text = "Number of seats";
            this.SeatsColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SeatsColumnHeader.Width = 130;
            // 
            // GuideColumnHeader
            // 
            this.GuideColumnHeader.Text = "Guide";
            this.GuideColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GuideColumnHeader.Width = 182;
            // 
            // PriceColumnHeader
            // 
            this.PriceColumnHeader.Text = "Price";
            this.PriceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceColumnHeader.Width = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Travels Info";
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(0, 319);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(848, 46);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangeTravelInfoButton
            // 
            this.ChangeTravelInfoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChangeTravelInfoButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTravelInfoButton.Location = new System.Drawing.Point(0, 273);
            this.ChangeTravelInfoButton.Name = "ChangeTravelInfoButton";
            this.ChangeTravelInfoButton.Size = new System.Drawing.Size(848, 46);
            this.ChangeTravelInfoButton.TabIndex = 3;
            this.ChangeTravelInfoButton.Text = "Change Existing Travel Info";
            this.ChangeTravelInfoButton.UseVisualStyleBackColor = true;
            // 
            // AddNewTravelButton
            // 
            this.AddNewTravelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddNewTravelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewTravelButton.Location = new System.Drawing.Point(0, 227);
            this.AddNewTravelButton.Name = "AddNewTravelButton";
            this.AddNewTravelButton.Size = new System.Drawing.Size(848, 46);
            this.AddNewTravelButton.TabIndex = 4;
            this.AddNewTravelButton.Text = "Create New Travel";
            this.AddNewTravelButton.UseVisualStyleBackColor = true;
            this.AddNewTravelButton.Click += new System.EventHandler(this.AddNewTravelButton_Click);
            // 
            // TravelsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 365);
            this.Controls.Add(this.AddNewTravelButton);
            this.Controls.Add(this.ChangeTravelInfoButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TravelsListView);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TravelsInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travels Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TravelsListView;
        private System.Windows.Forms.ColumnHeader NumberColumnHeader;
        private System.Windows.Forms.ColumnHeader DestinationColumnHeader;
        private System.Windows.Forms.ColumnHeader StartDateColumnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader FinishDateColumnHeader;
        private System.Windows.Forms.ColumnHeader SeatsColumnHeader;
        private System.Windows.Forms.ColumnHeader GuideColumnHeader;
        private System.Windows.Forms.ColumnHeader PriceColumnHeader;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChangeTravelInfoButton;
        private System.Windows.Forms.Button AddNewTravelButton;
    }
}