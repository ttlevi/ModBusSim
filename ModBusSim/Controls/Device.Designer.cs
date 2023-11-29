namespace ModBusSim.Controls
{
    partial class Device
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelDevice = new System.Windows.Forms.Panel();
            this.nuUnitID = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboNrOfRegs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnDigital = new System.Windows.Forms.RadioButton();
            this.rbtnAnalog = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitID)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(6, 4);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(486, 32);
            this.txtName.TabIndex = 37;
            this.txtName.Text = "ModBus Device";
            // 
            // panelDevice
            // 
            this.panelDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDevice.BackColor = System.Drawing.Color.Transparent;
            this.panelDevice.Location = new System.Drawing.Point(0, 167);
            this.panelDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDevice.Name = "panelDevice";
            this.panelDevice.Size = new System.Drawing.Size(560, 271);
            this.panelDevice.TabIndex = 36;
            // 
            // nuUnitID
            // 
            this.nuUnitID.Location = new System.Drawing.Point(8, 75);
            this.nuUnitID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuUnitID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nuUnitID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuUnitID.Name = "nuUnitID";
            this.nuUnitID.Size = new System.Drawing.Size(156, 31);
            this.nuUnitID.TabIndex = 35;
            this.nuUnitID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(500, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 52);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "X\r\n";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(352, 65);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(202, 92);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
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
            this.cboNrOfRegs.Location = new System.Drawing.Point(180, 73);
            this.cboNrOfRegs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboNrOfRegs.Name = "cboNrOfRegs";
            this.cboNrOfRegs.Size = new System.Drawing.Size(156, 33);
            this.cboNrOfRegs.TabIndex = 32;
            this.cboNrOfRegs.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(174, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nr. of reg.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Unit ID";
            // 
            // rbtnDigital
            // 
            this.rbtnDigital.AutoSize = true;
            this.rbtnDigital.Checked = true;
            this.rbtnDigital.Location = new System.Drawing.Point(104, 125);
            this.rbtnDigital.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnDigital.Name = "rbtnDigital";
            this.rbtnDigital.Size = new System.Drawing.Size(103, 29);
            this.rbtnDigital.TabIndex = 38;
            this.rbtnDigital.TabStop = true;
            this.rbtnDigital.Text = "Digital";
            this.rbtnDigital.UseVisualStyleBackColor = true;
            // 
            // rbtnAnalog
            // 
            this.rbtnAnalog.AutoSize = true;
            this.rbtnAnalog.Location = new System.Drawing.Point(224, 125);
            this.rbtnAnalog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnAnalog.Name = "rbtnAnalog";
            this.rbtnAnalog.Size = new System.Drawing.Size(110, 29);
            this.rbtnAnalog.TabIndex = 39;
            this.rbtnAnalog.Text = "Analog";
            this.rbtnAnalog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Type";
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnAnalog);
            this.Controls.Add(this.rbtnDigital);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panelDevice);
            this.Controls.Add(this.nuUnitID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboNrOfRegs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Device";
            this.Size = new System.Drawing.Size(560, 440);
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Panel panelDevice;
        private System.Windows.Forms.NumericUpDown nuUnitID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboNrOfRegs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnDigital;
        private System.Windows.Forms.RadioButton rbtnAnalog;
        private System.Windows.Forms.Label label1;
    }
}
