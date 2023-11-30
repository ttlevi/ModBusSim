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
            this.addDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRoom = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addDeviceToolStripMenuItem
            // 
            this.addDeviceToolStripMenuItem.Name = "addDeviceToolStripMenuItem";
            this.addDeviceToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.addDeviceToolStripMenuItem.Text = "Add Device";
            this.addDeviceToolStripMenuItem.Click += new System.EventHandler(this.addDeviceToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomPropertiesToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.openToolStripMenuItem.Text = "Details";
            // 
            // roomPropertiesToolStripMenuItem
            // 
            this.roomPropertiesToolStripMenuItem.Name = "roomPropertiesToolStripMenuItem";
            this.roomPropertiesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.roomPropertiesToolStripMenuItem.Text = "Room Properties";
            this.roomPropertiesToolStripMenuItem.Click += new System.EventHandler(this.roomPropertiesToolStripMenuItem_Click);
            // 
            // panelRoom
            // 
            this.panelRoom.AutoScroll = true;
            this.panelRoom.BackColor = System.Drawing.Color.Silver;
            this.panelRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoom.Location = new System.Drawing.Point(0, 24);
            this.panelRoom.Margin = new System.Windows.Forms.Padding(2);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(1057, 355);
            this.panelRoom.TabIndex = 2;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 379);
            this.Controls.Add(this.panelRoom);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Room";
            this.Text = "NewRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Room_FormClosing);
            this.Resize += new System.EventHandler(this.Room_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomPropertiesToolStripMenuItem;
        private System.Windows.Forms.Panel panelRoom;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem;
    }
}