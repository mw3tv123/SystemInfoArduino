namespace SystemInfoTransfer {
    partial class SystemMonitorUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SerialPortCb = new System.Windows.Forms.ComboBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ErrorLb = new System.Windows.Forms.Label();
            this.SystemInfoDg = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemInfoDg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SerialPortCb);
            this.groupBox1.Controls.Add(this.ConnectBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection";
            // 
            // SerialPortCb
            // 
            this.SerialPortCb.FormattingEnabled = true;
            this.SerialPortCb.Location = new System.Drawing.Point(87, 28);
            this.SerialPortCb.Name = "SerialPortCb";
            this.SerialPortCb.Size = new System.Drawing.Size(167, 21);
            this.SerialPortCb.TabIndex = 1;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Enabled = false;
            this.ConnectBtn.Location = new System.Drawing.Point(6, 28);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ErrorLb
            // 
            this.ErrorLb.AutoSize = true;
            this.ErrorLb.Enabled = false;
            this.ErrorLb.ForeColor = System.Drawing.Color.OrangeRed;
            this.ErrorLb.Location = new System.Drawing.Point(123, 77);
            this.ErrorLb.Name = "ErrorLb";
            this.ErrorLb.Size = new System.Drawing.Size(0, 13);
            this.ErrorLb.TabIndex = 1;
            // 
            // SystemInfoDg
            // 
            this.SystemInfoDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SystemInfoDg.Location = new System.Drawing.Point(12, 81);
            this.SystemInfoDg.Name = "SystemInfoDg";
            this.SystemInfoDg.Size = new System.Drawing.Size(270, 268);
            this.SystemInfoDg.TabIndex = 2;
            // 
            // SystemMonitorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 361);
            this.Controls.Add(this.SystemInfoDg);
            this.Controls.Add(this.ErrorLb);
            this.Controls.Add(this.groupBox1);
            this.Name = "SystemMonitorUI";
            this.Text = "SystemMonitorUI";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SystemInfoDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SerialPortCb;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label ErrorLb;
        private System.Windows.Forms.DataGridView SystemInfoDg;
    }
}