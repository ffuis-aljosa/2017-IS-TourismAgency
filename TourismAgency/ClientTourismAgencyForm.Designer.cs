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
            this.ClientFormToolStrip.SuspendLayout();
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
            this.ClientFormToolStrip.Size = new System.Drawing.Size(813, 37);
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ClientTourismAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TourismAgency.Properties.Resources.ClientForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 360);
            this.Controls.Add(this.ClientFormToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientTourismAgencyForm";
            this.Text = "Tourism agency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientTourismAgencyForm_FormClosed);
            this.ClientFormToolStrip.ResumeLayout(false);
            this.ClientFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ClientFormToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}