namespace ModBusSim.Controls
{
    partial class Display
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddr.Location = new System.Drawing.Point(-2, 0);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(24, 25);
            this.lblAddr.TabIndex = 0;
            this.lblAddr.Text = "1";
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Black;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(15, 0);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(25, 15);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "0";
            // 
            // Display
            // 
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblAddr);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(40, 15);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblAddr;
    }
}
