namespace TourismAgency
{
    partial class TourismAgencyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourismAgencyForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TravelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnterTheDestinationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectADateLabel = new System.Windows.Forms.Label();
            this.SelectADateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.TravelToolStripMenuItem,
            this.TravelsToolStripMenuItem,
            this.ClientToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
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
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LogOutToolStripMenuItem.Text = "Log out";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // TravelToolStripMenuItem
            // 
            this.TravelToolStripMenuItem.Name = "TravelToolStripMenuItem";
            this.TravelToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
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
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewClientToolStripMenuItem});
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ClientToolStripMenuItem.Text = "Client";
            // 
            // AddNewClientToolStripMenuItem
            // 
            this.AddNewClientToolStripMenuItem.Name = "AddNewClientToolStripMenuItem";
            this.AddNewClientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.AddNewClientToolStripMenuItem.Text = "Add new client";
            this.AddNewClientToolStripMenuItem.Click += new System.EventHandler(this.AddNewClientToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // EnterTheDestinationTextBox
            // 
            this.EnterTheDestinationTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnterTheDestinationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnterTheDestinationTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnterTheDestinationTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EnterTheDestinationTextBox.Location = new System.Drawing.Point(12, 58);
            this.EnterTheDestinationTextBox.Name = "EnterTheDestinationTextBox";
            this.EnterTheDestinationTextBox.Size = new System.Drawing.Size(180, 27);
            this.EnterTheDestinationTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the destination";
            // 
            // SelectADateLabel
            // 
            this.SelectADateLabel.AutoSize = true;
            this.SelectADateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectADateLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SelectADateLabel.Location = new System.Drawing.Point(13, 92);
            this.SelectADateLabel.Name = "SelectADateLabel";
            this.SelectADateLabel.Size = new System.Drawing.Size(118, 18);
            this.SelectADateLabel.TabIndex = 4;
            this.SelectADateLabel.Text = "Select a date";
            // 
            // SelectADateDateTimePicker
            // 
            this.SelectADateDateTimePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectADateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SelectADateDateTimePicker.Location = new System.Drawing.Point(12, 113);
            this.SelectADateDateTimePicker.MinDate = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            this.SelectADateDateTimePicker.Name = "SelectADateDateTimePicker";
            this.SelectADateDateTimePicker.Size = new System.Drawing.Size(180, 27);
            this.SelectADateDateTimePicker.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.Location = new System.Drawing.Point(12, 166);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(180, 46);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // TourismAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 354);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SelectADateDateTimePicker);
            this.Controls.Add(this.SelectADateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterTheDestinationTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TourismAgencyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Tourism Agency\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TourismAgencyForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TravelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewClientToolStripMenuItem;
        private System.Windows.Forms.TextBox EnterTheDestinationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectADateLabel;
        private System.Windows.Forms.DateTimePicker SelectADateDateTimePicker;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}