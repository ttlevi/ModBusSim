namespace ModBusSim
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogholdingDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalcoilDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1608, 64);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analogholdingDeviceToolStripMenuItem,
            this.digitalcoilDeviceToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(77, 60);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // analogholdingDeviceToolStripMenuItem
            // 
            this.analogholdingDeviceToolStripMenuItem.Name = "analogholdingDeviceToolStripMenuItem";
            this.analogholdingDeviceToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.analogholdingDeviceToolStripMenuItem.Text = "Analog (holding) device";
            this.analogholdingDeviceToolStripMenuItem.Click += new System.EventHandler(this.analogholdingDeviceToolStripMenuItem_Click);
            // 
            // digitalcoilDeviceToolStripMenuItem
            // 
            this.digitalcoilDeviceToolStripMenuItem.Name = "digitalcoilDeviceToolStripMenuItem";
            this.digitalcoilDeviceToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.digitalcoilDeviceToolStripMenuItem.Text = "Digital (coil) device";
            this.digitalcoilDeviceToolStripMenuItem.Click += new System.EventHandler(this.digitalcoilDeviceToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomPropertiesToolStripMenuItem,
            this.logToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 60);
            this.openToolStripMenuItem.Text = "Details";
            // 
            // roomPropertiesToolStripMenuItem
            // 
            this.roomPropertiesToolStripMenuItem.Name = "roomPropertiesToolStripMenuItem";
            this.roomPropertiesToolStripMenuItem.Size = new System.Drawing.Size(367, 44);
            this.roomPropertiesToolStripMenuItem.Text = "Room Properties";
            this.roomPropertiesToolStripMenuItem.Click += new System.EventHandler(this.roomPropertiesToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(367, 44);
            this.logToolStripMenuItem.Text = "Register Change Log";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(15, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 530);
            this.panel1.TabIndex = 2;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Room_FormClosing);
            this.Load += new System.EventHandler(this.Room_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analogholdingDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalcoilDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomPropertiesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}