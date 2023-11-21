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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue.BackColor = System.Drawing.Color.Black;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(43, 0);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(60, 30);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddr
            // 
            this.lblAddr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddr.BackColor = System.Drawing.Color.White;
            this.lblAddr.ForeColor = System.Drawing.Color.Black;
            this.lblAddr.Location = new System.Drawing.Point(0, 0);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(40, 30);
            this.lblAddr.TabIndex = 1;
            this.lblAddr.Text = "0";
            this.lblAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Display
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblValue);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(100, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblAddr;
    }
}
