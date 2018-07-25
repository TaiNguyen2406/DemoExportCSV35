﻿namespace DemoExport_csv35
{
    partial class frmDocDuLieu
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtGiaTri1 = new System.Windows.Forms.TextBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.txtGiaTri2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDigital = new System.Windows.Forms.NumericUpDown();
            this.chkDigitalInput = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAnalogue = new System.Windows.Forms.NumericUpDown();
            this.txtInputReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCoil2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCoil1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudReg2 = new System.Windows.Forms.NumericUpDown();
            this.nudReg1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudCoilNoW = new System.Windows.Forms.NumericUpDown();
            this.nudRegValue = new System.Windows.Forms.NumericUpDown();
            this.nudRegNoW = new System.Windows.Forms.NumericUpDown();
            this.chkCoilValue = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGhi = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIpAdam = new System.Windows.Forms.TextBox();
            this.lblStatusAdam = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalogue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReg1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoilNoW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegNoW)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(243, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Offline";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(21, 336);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(71, 41);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(113, 336);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(71, 41);
            this.btnDisConnect.TabIndex = 3;
            this.btnDisConnect.Text = "DisConnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtGiaTri1
            // 
            this.txtGiaTri1.Location = new System.Drawing.Point(175, 26);
            this.txtGiaTri1.Name = "txtGiaTri1";
            this.txtGiaTri1.Size = new System.Drawing.Size(59, 20);
            this.txtGiaTri1.TabIndex = 4;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(175, 78);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(52, 17);
            this.chk1.TabIndex = 5;
            this.chk1.Text = "Coil 1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(175, 106);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(52, 17);
            this.chk2.TabIndex = 6;
            this.chk2.Text = "Coil 2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // txtGiaTri2
            // 
            this.txtGiaTri2.Location = new System.Drawing.Point(175, 52);
            this.txtGiaTri2.Name = "txtGiaTri2";
            this.txtGiaTri2.Size = new System.Drawing.Size(59, 20);
            this.txtGiaTri2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudDigital);
            this.groupBox1.Controls.Add(this.chkDigitalInput);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nudAnalogue);
            this.groupBox1.Controls.Add(this.txtInputReg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudCoil2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nudCoil1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudReg2);
            this.groupBox1.Controls.Add(this.nudReg1);
            this.groupBox1.Controls.Add(this.txtGiaTri1);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.txtGiaTri2);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 199);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đọc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Digital Input";
            // 
            // nudDigital
            // 
            this.nudDigital.Location = new System.Drawing.Point(107, 156);
            this.nudDigital.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudDigital.Name = "nudDigital";
            this.nudDigital.Size = new System.Drawing.Size(62, 20);
            this.nudDigital.TabIndex = 28;
            // 
            // chkDigitalInput
            // 
            this.chkDigitalInput.AutoSize = true;
            this.chkDigitalInput.Location = new System.Drawing.Point(175, 157);
            this.chkDigitalInput.Name = "chkDigitalInput";
            this.chkDigitalInput.Size = new System.Drawing.Size(53, 17);
            this.chkDigitalInput.TabIndex = 25;
            this.chkDigitalInput.Text = "Value";
            this.chkDigitalInput.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Analogue Input No:";
            // 
            // nudAnalogue
            // 
            this.nudAnalogue.Location = new System.Drawing.Point(107, 131);
            this.nudAnalogue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudAnalogue.Name = "nudAnalogue";
            this.nudAnalogue.Size = new System.Drawing.Size(62, 20);
            this.nudAnalogue.TabIndex = 26;
            // 
            // txtInputReg
            // 
            this.txtInputReg.Location = new System.Drawing.Point(175, 131);
            this.txtInputReg.Name = "txtInputReg";
            this.txtInputReg.Size = new System.Drawing.Size(59, 20);
            this.txtInputReg.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Register No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Register No:";
            // 
            // nudCoil2
            // 
            this.nudCoil2.Location = new System.Drawing.Point(107, 105);
            this.nudCoil2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudCoil2.Name = "nudCoil2";
            this.nudCoil2.Size = new System.Drawing.Size(62, 20);
            this.nudCoil2.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Coil No:";
            // 
            // nudCoil1
            // 
            this.nudCoil1.Location = new System.Drawing.Point(107, 79);
            this.nudCoil1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudCoil1.Name = "nudCoil1";
            this.nudCoil1.Size = new System.Drawing.Size(62, 20);
            this.nudCoil1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Coil No:";
            // 
            // nudReg2
            // 
            this.nudReg2.Location = new System.Drawing.Point(107, 53);
            this.nudReg2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudReg2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReg2.Name = "nudReg2";
            this.nudReg2.Size = new System.Drawing.Size(62, 20);
            this.nudReg2.TabIndex = 16;
            this.nudReg2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudReg1
            // 
            this.nudReg1.Location = new System.Drawing.Point(107, 27);
            this.nudReg1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudReg1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReg1.Name = "nudReg1";
            this.nudReg1.Size = new System.Drawing.Size(62, 20);
            this.nudReg1.TabIndex = 15;
            this.nudReg1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.nudCoilNoW);
            this.groupBox2.Controls.Add(this.nudRegValue);
            this.groupBox2.Controls.Add(this.nudRegNoW);
            this.groupBox2.Controls.Add(this.chkCoilValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(277, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 132);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ghi";
            // 
            // nudCoilNoW
            // 
            this.nudCoilNoW.Location = new System.Drawing.Point(78, 51);
            this.nudCoilNoW.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudCoilNoW.Name = "nudCoilNoW";
            this.nudCoilNoW.Size = new System.Drawing.Size(62, 20);
            this.nudCoilNoW.TabIndex = 19;
            // 
            // nudRegValue
            // 
            this.nudRegValue.Location = new System.Drawing.Point(178, 24);
            this.nudRegValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudRegValue.Name = "nudRegValue";
            this.nudRegValue.Size = new System.Drawing.Size(62, 20);
            this.nudRegValue.TabIndex = 18;
            // 
            // nudRegNoW
            // 
            this.nudRegNoW.Location = new System.Drawing.Point(78, 24);
            this.nudRegNoW.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudRegNoW.Name = "nudRegNoW";
            this.nudRegNoW.Size = new System.Drawing.Size(62, 20);
            this.nudRegNoW.TabIndex = 14;
            // 
            // chkCoilValue
            // 
            this.chkCoilValue.AutoSize = true;
            this.chkCoilValue.Location = new System.Drawing.Point(149, 53);
            this.chkCoilValue.Name = "chkCoilValue";
            this.chkCoilValue.Size = new System.Drawing.Size(53, 17);
            this.chkCoilValue.TabIndex = 17;
            this.chkCoilValue.Text = "Value";
            this.chkCoilValue.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Coil No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Register No:";
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(285, 336);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(71, 41);
            this.btnGhi.TabIndex = 13;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(113, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(111, 20);
            this.txtIP.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "IP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "IP:";
            // 
            // txtIpAdam
            // 
            this.txtIpAdam.Location = new System.Drawing.Point(113, 230);
            this.txtIpAdam.Name = "txtIpAdam";
            this.txtIpAdam.Size = new System.Drawing.Size(111, 20);
            this.txtIpAdam.TabIndex = 25;
            // 
            // lblStatusAdam
            // 
            this.lblStatusAdam.AutoSize = true;
            this.lblStatusAdam.Location = new System.Drawing.Point(243, 233);
            this.lblStatusAdam.Name = "lblStatusAdam";
            this.lblStatusAdam.Size = new System.Drawing.Size(37, 13);
            this.lblStatusAdam.TabIndex = 24;
            this.lblStatusAdam.Text = "Offline";
            // 
            // frmDocDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIpAdam);
            this.Controls.Add(this.lblStatusAdam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblStatus);
            this.Name = "frmDocDuLieu";
            this.Text = "ĐọC dỮ LiỆu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDocDuLieu_FormClosed);
            this.Load += new System.EventHandler(this.frmDocDuLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalogue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReg1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoilNoW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegNoW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtGiaTri1;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.TextBox txtGiaTri2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCoilValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.NumericUpDown nudRegNoW;
        private System.Windows.Forms.NumericUpDown nudCoilNoW;
        private System.Windows.Forms.NumericUpDown nudRegValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCoil2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCoil1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudReg2;
        private System.Windows.Forms.NumericUpDown nudReg1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtInputReg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAnalogue;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDigitalInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudDigital;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIpAdam;
        private System.Windows.Forms.Label lblStatusAdam;
    }
}