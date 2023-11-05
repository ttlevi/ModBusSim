namespace ModBusSim.Controls
{
    partial class DigitalDevice
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboNrOfRegs = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digital ModBus Device";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 147);
            this.panel1.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(147, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 23);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboNrOfRegs
            // 
            this.cboNrOfRegs.FormattingEnabled = true;
            this.cboNrOfRegs.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.cboNrOfRegs.Location = new System.Drawing.Point(90, 39);
            this.cboNrOfRegs.Name = "cboNrOfRegs";
            this.cboNrOfRegs.Size = new System.Drawing.Size(50, 21);
            this.cboNrOfRegs.TabIndex = 23;
            this.cboNrOfRegs.Text = "5";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(2, 40);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(82, 20);
            this.txtIP.TabIndex = 22;
            this.txtIP.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nr. of reg.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Unit ID";
            // 
            // DigitalDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboNrOfRegs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "DigitalDevice";
            this.Size = new System.Drawing.Size(250, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboNrOfRegs;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
