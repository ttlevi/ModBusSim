namespace ModBusSim
{
    partial class Log
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwCoilRegs = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHoldingRegs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bsrcCoilRegs = new System.Windows.Forms.BindingSource(this.components);
            this.bsrcHoldingRegs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoilRegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoldingRegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCoilRegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcHoldingRegs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coil Registers:";
            // 
            // dgwCoilRegs
            // 
            this.dgwCoilRegs.AllowUserToAddRows = false;
            this.dgwCoilRegs.AllowUserToDeleteRows = false;
            this.dgwCoilRegs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgwCoilRegs.AutoGenerateColumns = false;
            this.dgwCoilRegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCoilRegs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Register,
            this.Value});
            this.dgwCoilRegs.DataSource = this.bsrcCoilRegs;
            this.dgwCoilRegs.Location = new System.Drawing.Point(11, 23);
            this.dgwCoilRegs.Margin = new System.Windows.Forms.Padding(2);
            this.dgwCoilRegs.Name = "dgwCoilRegs";
            this.dgwCoilRegs.ReadOnly = true;
            this.dgwCoilRegs.RowHeadersWidth = 82;
            this.dgwCoilRegs.RowTemplate.Height = 33;
            this.dgwCoilRegs.Size = new System.Drawing.Size(298, 416);
            this.dgwCoilRegs.TabIndex = 4;
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 100;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Register
            // 
            this.Register.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Register.HeaderText = "Register";
            this.Register.MinimumWidth = 10;
            this.Register.Name = "Register";
            this.Register.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 10;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // dgwHoldingRegs
            // 
            this.dgwHoldingRegs.AllowUserToAddRows = false;
            this.dgwHoldingRegs.AllowUserToDeleteRows = false;
            this.dgwHoldingRegs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwHoldingRegs.AutoGenerateColumns = false;
            this.dgwHoldingRegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHoldingRegs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgwHoldingRegs.DataSource = this.bsrcHoldingRegs;
            this.dgwHoldingRegs.Location = new System.Drawing.Point(320, 23);
            this.dgwHoldingRegs.Margin = new System.Windows.Forms.Padding(2);
            this.dgwHoldingRegs.Name = "dgwHoldingRegs";
            this.dgwHoldingRegs.ReadOnly = true;
            this.dgwHoldingRegs.RowHeadersWidth = 82;
            this.dgwHoldingRegs.RowTemplate.Height = 33;
            this.dgwHoldingRegs.Size = new System.Drawing.Size(298, 416);
            this.dgwHoldingRegs.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Client";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Register";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Holding Registers:";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCoilRegs);
            this.Controls.Add(this.dgwHoldingRegs);
            this.Controls.Add(this.label2);
            this.Name = "Log";
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoilRegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoldingRegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCoilRegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcHoldingRegs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwCoilRegs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.BindingSource bsrcCoilRegs;
        private System.Windows.Forms.DataGridView dgwHoldingRegs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource bsrcHoldingRegs;
        private System.Windows.Forms.Label label2;
    }
}