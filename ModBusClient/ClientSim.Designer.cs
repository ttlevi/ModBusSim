namespace ModBusClient
{
    partial class ModbusClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModbusClientForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chCoilVal = new System.Windows.Forms.CheckBox();
            this.rbtnHoldingReg = new System.Windows.Forms.RadioButton();
            this.rbtnCoil = new System.Windows.Forms.RadioButton();
            this.nuRegVal = new System.Windows.Forms.NumericUpDown();
            this.nuRegAddr = new System.Windows.Forms.NumericUpDown();
            this.nuUnitID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSetValue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRegVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRegAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitID)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chCoilVal);
            this.groupBox1.Controls.Add(this.rbtnHoldingReg);
            this.groupBox1.Controls.Add(this.rbtnCoil);
            this.groupBox1.Controls.Add(this.nuRegVal);
            this.groupBox1.Controls.Add(this.nuRegAddr);
            this.groupBox1.Controls.Add(this.nuUnitID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.btnSetValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(636, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Data";
            // 
            // chCoilVal
            // 
            this.chCoilVal.AutoSize = true;
            this.chCoilVal.Location = new System.Drawing.Point(262, 196);
            this.chCoilVal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chCoilVal.Name = "chCoilVal";
            this.chCoilVal.Size = new System.Drawing.Size(88, 29);
            this.chCoilVal.TabIndex = 18;
            this.chCoilVal.Text = "True";
            this.chCoilVal.UseVisualStyleBackColor = true;
            // 
            // rbtnHoldingReg
            // 
            this.rbtnHoldingReg.AutoSize = true;
            this.rbtnHoldingReg.Location = new System.Drawing.Point(418, 94);
            this.rbtnHoldingReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnHoldingReg.Name = "rbtnHoldingReg";
            this.rbtnHoldingReg.Size = new System.Drawing.Size(202, 29);
            this.rbtnHoldingReg.TabIndex = 17;
            this.rbtnHoldingReg.Text = "Holding Register";
            this.rbtnHoldingReg.UseVisualStyleBackColor = true;
            // 
            // rbtnCoil
            // 
            this.rbtnCoil.AutoSize = true;
            this.rbtnCoil.Checked = true;
            this.rbtnCoil.Location = new System.Drawing.Point(262, 94);
            this.rbtnCoil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCoil.Name = "rbtnCoil";
            this.rbtnCoil.Size = new System.Drawing.Size(150, 29);
            this.rbtnCoil.TabIndex = 16;
            this.rbtnCoil.TabStop = true;
            this.rbtnCoil.Text = "Coil Output";
            this.rbtnCoil.UseVisualStyleBackColor = true;
            this.rbtnCoil.CheckedChanged += new System.EventHandler(this.rbtnCoil_CheckedChanged);
            // 
            // nuRegVal
            // 
            this.nuRegVal.Location = new System.Drawing.Point(262, 196);
            this.nuRegVal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuRegVal.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nuRegVal.Name = "nuRegVal";
            this.nuRegVal.Size = new System.Drawing.Size(358, 31);
            this.nuRegVal.TabIndex = 15;
            // 
            // nuRegAddr
            // 
            this.nuRegAddr.Location = new System.Drawing.Point(260, 144);
            this.nuRegAddr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nuRegAddr.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nuRegAddr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuRegAddr.Name = "nuRegAddr";
            this.nuRegAddr.Size = new System.Drawing.Size(360, 31);
            this.nuRegAddr.TabIndex = 14;
            this.nuRegAddr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuUnitID
            // 
            this.nuUnitID.Location = new System.Drawing.Point(262, 42);
            this.nuUnitID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.nuUnitID.Size = new System.Drawing.Size(358, 31);
            this.nuUnitID.TabIndex = 13;
            this.nuUnitID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unit ID";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(256, 283);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 7;
            // 
            // btnSetValue
            // 
            this.btnSetValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetValue.Location = new System.Drawing.Point(260, 244);
            this.btnSetValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSetValue.Name = "btnSetValue";
            this.btnSetValue.Size = new System.Drawing.Size(360, 73);
            this.btnSetValue.TabIndex = 6;
            this.btnSetValue.Text = "Set";
            this.btnSetValue.UseVisualStyleBackColor = true;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Register Address";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Value";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.txtIPAddr);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(636, 221);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Properties";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(262, 133);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(358, 73);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port Number";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP Address";
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(262, 83);
            this.txtPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(358, 31);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "502";
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIPAddr.Location = new System.Drawing.Point(260, 33);
            this.txtIPAddr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.Size = new System.Drawing.Size(360, 31);
            this.txtIPAddr.TabIndex = 2;
            this.txtIPAddr.Text = "127.0.0.1";
            // 
            // ModbusClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ModbusClientForm";
            this.Text = "ModBusClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRegVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRegAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddr;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuUnitID;
        private System.Windows.Forms.NumericUpDown nuRegAddr;
        private System.Windows.Forms.NumericUpDown nuRegVal;
        private System.Windows.Forms.RadioButton rbtnHoldingReg;
        private System.Windows.Forms.RadioButton rbtnCoil;
        private System.Windows.Forms.CheckBox chCoilVal;
    }
}

