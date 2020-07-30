namespace IMICNC_WinForm
{
    partial class Information
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMachine = new System.Windows.Forms.Label();
            this.cboSelectMachine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPosToEncoder = new System.Windows.Forms.TextBox();
            this.txtRPM = new System.Windows.Forms.TextBox();
            this.txtPPR = new System.Windows.Forms.TextBox();
            this.txtPitch = new System.Windows.Forms.TextBox();
            this.txtGearRatio = new System.Windows.Forms.TextBox();
            this.txtHightLimit = new System.Windows.Forms.TextBox();
            this.txtLowLimit = new System.Windows.Forms.TextBox();
            this.txtPulseMode = new System.Windows.Forms.TextBox();
            this.txtPulseWidth = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtHighSpeed = new System.Windows.Forms.TextBox();
            this.txtLowSpeed = new System.Windows.Forms.TextBox();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.btnSaveMachine = new System.Windows.Forms.Button();
            this.btnClearMachine = new System.Windows.Forms.Button();
            this.btnDeleteMachine = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMachine.Location = new System.Drawing.Point(50, 30);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(127, 36);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Text = "選擇機台";
            // 
            // cboSelectMachine
            // 
            this.cboSelectMachine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSelectMachine.FormattingEnabled = true;
            this.cboSelectMachine.Location = new System.Drawing.Point(183, 30);
            this.cboSelectMachine.Name = "cboSelectMachine";
            this.cboSelectMachine.Size = new System.Drawing.Size(178, 33);
            this.cboSelectMachine.TabIndex = 1;
            this.cboSelectMachine.SelectedIndexChanged += new System.EventHandler(this.cboSelectMachine_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "方向調整參數：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(50, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "RPM：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "PPR：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(50, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "導螺桿間隙值：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(381, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "脈波輸出格式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(381, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "負方向邊界：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(381, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "正方向邊界：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(381, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "齒輪箱減速比：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(723, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "減速時間：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(723, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 31);
            this.label10.TabIndex = 12;
            this.label10.Text = "加速時間：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(723, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 31);
            this.label11.TabIndex = 11;
            this.label11.Text = "運動命令輸出：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(381, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 31);
            this.label12.TabIndex = 10;
            this.label12.Text = "脈波輸出寬度：";
            // 
            // txtPosToEncoder
            // 
            this.txtPosToEncoder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPosToEncoder.Location = new System.Drawing.Point(238, 167);
            this.txtPosToEncoder.Name = "txtPosToEncoder";
            this.txtPosToEncoder.Size = new System.Drawing.Size(123, 34);
            this.txtPosToEncoder.TabIndex = 16;
            // 
            // txtRPM
            // 
            this.txtRPM.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRPM.Location = new System.Drawing.Point(238, 227);
            this.txtRPM.Name = "txtRPM";
            this.txtRPM.Size = new System.Drawing.Size(123, 34);
            this.txtRPM.TabIndex = 17;
            // 
            // txtPPR
            // 
            this.txtPPR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPPR.Location = new System.Drawing.Point(238, 287);
            this.txtPPR.Name = "txtPPR";
            this.txtPPR.Size = new System.Drawing.Size(123, 34);
            this.txtPPR.TabIndex = 18;
            // 
            // txtPitch
            // 
            this.txtPitch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPitch.Location = new System.Drawing.Point(238, 347);
            this.txtPitch.Name = "txtPitch";
            this.txtPitch.Size = new System.Drawing.Size(123, 34);
            this.txtPitch.TabIndex = 19;
            // 
            // txtGearRatio
            // 
            this.txtGearRatio.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGearRatio.Location = new System.Drawing.Point(569, 104);
            this.txtGearRatio.Name = "txtGearRatio";
            this.txtGearRatio.Size = new System.Drawing.Size(123, 34);
            this.txtGearRatio.TabIndex = 20;
            // 
            // txtHightLimit
            // 
            this.txtHightLimit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHightLimit.Location = new System.Drawing.Point(570, 167);
            this.txtHightLimit.Name = "txtHightLimit";
            this.txtHightLimit.Size = new System.Drawing.Size(123, 34);
            this.txtHightLimit.TabIndex = 21;
            // 
            // txtLowLimit
            // 
            this.txtLowLimit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLowLimit.Location = new System.Drawing.Point(570, 227);
            this.txtLowLimit.Name = "txtLowLimit";
            this.txtLowLimit.Size = new System.Drawing.Size(123, 34);
            this.txtLowLimit.TabIndex = 22;
            // 
            // txtPulseMode
            // 
            this.txtPulseMode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPulseMode.Location = new System.Drawing.Point(570, 287);
            this.txtPulseMode.Name = "txtPulseMode";
            this.txtPulseMode.Size = new System.Drawing.Size(123, 34);
            this.txtPulseMode.TabIndex = 23;
            // 
            // txtPulseWidth
            // 
            this.txtPulseWidth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPulseWidth.Location = new System.Drawing.Point(570, 347);
            this.txtPulseWidth.Name = "txtPulseWidth";
            this.txtPulseWidth.Size = new System.Drawing.Size(123, 34);
            this.txtPulseWidth.TabIndex = 24;
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCommand.Location = new System.Drawing.Point(910, 101);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(123, 34);
            this.txtCommand.TabIndex = 25;
            // 
            // txtHighSpeed
            // 
            this.txtHighSpeed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHighSpeed.Location = new System.Drawing.Point(911, 164);
            this.txtHighSpeed.Name = "txtHighSpeed";
            this.txtHighSpeed.Size = new System.Drawing.Size(123, 34);
            this.txtHighSpeed.TabIndex = 26;
            // 
            // txtLowSpeed
            // 
            this.txtLowSpeed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLowSpeed.Location = new System.Drawing.Point(911, 224);
            this.txtLowSpeed.Name = "txtLowSpeed";
            this.txtLowSpeed.Size = new System.Drawing.Size(123, 34);
            this.txtLowSpeed.TabIndex = 27;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddMachine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddMachine.Location = new System.Drawing.Point(400, 28);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(140, 35);
            this.btnAddMachine.TabIndex = 28;
            this.btnAddMachine.Text = "新增參數";
            this.btnAddMachine.UseVisualStyleBackColor = false;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // btnSaveMachine
            // 
            this.btnSaveMachine.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveMachine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveMachine.Location = new System.Drawing.Point(570, 28);
            this.btnSaveMachine.Name = "btnSaveMachine";
            this.btnSaveMachine.Size = new System.Drawing.Size(140, 35);
            this.btnSaveMachine.TabIndex = 29;
            this.btnSaveMachine.Text = "儲存參數";
            this.btnSaveMachine.UseVisualStyleBackColor = false;
            this.btnSaveMachine.Click += new System.EventHandler(this.btnSaveMachine_Click);
            // 
            // btnClearMachine
            // 
            this.btnClearMachine.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearMachine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearMachine.Location = new System.Drawing.Point(740, 28);
            this.btnClearMachine.Name = "btnClearMachine";
            this.btnClearMachine.Size = new System.Drawing.Size(140, 35);
            this.btnClearMachine.TabIndex = 30;
            this.btnClearMachine.Text = "清除參數";
            this.btnClearMachine.UseVisualStyleBackColor = false;
            this.btnClearMachine.Click += new System.EventHandler(this.btnClearMachine_Click);
            // 
            // btnDeleteMachine
            // 
            this.btnDeleteMachine.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteMachine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteMachine.Location = new System.Drawing.Point(910, 28);
            this.btnDeleteMachine.Name = "btnDeleteMachine";
            this.btnDeleteMachine.Size = new System.Drawing.Size(140, 35);
            this.btnDeleteMachine.TabIndex = 31;
            this.btnDeleteMachine.Text = "刪除參數";
            this.btnDeleteMachine.UseVisualStyleBackColor = false;
            this.btnDeleteMachine.Click += new System.EventHandler(this.btnDeleteMachine_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(50, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 31);
            this.label13.TabIndex = 32;
            this.label13.Text = "機台名稱：";
            // 
            // txtMachineName
            // 
            this.txtMachineName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMachineName.Location = new System.Drawing.Point(238, 104);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(123, 34);
            this.txtMachineName.TabIndex = 33;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDeleteMachine);
            this.Controls.Add(this.btnClearMachine);
            this.Controls.Add(this.btnSaveMachine);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.txtLowSpeed);
            this.Controls.Add(this.txtHighSpeed);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.txtPulseWidth);
            this.Controls.Add(this.txtPulseMode);
            this.Controls.Add(this.txtLowLimit);
            this.Controls.Add(this.txtHightLimit);
            this.Controls.Add(this.txtGearRatio);
            this.Controls.Add(this.txtPitch);
            this.Controls.Add(this.txtPPR);
            this.Controls.Add(this.txtRPM);
            this.Controls.Add(this.txtPosToEncoder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSelectMachine);
            this.Controls.Add(this.lblMachine);
            this.Name = "Information";
            this.Size = new System.Drawing.Size(1074, 423);
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.ComboBox cboSelectMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPosToEncoder;
        private System.Windows.Forms.TextBox txtRPM;
        private System.Windows.Forms.TextBox txtPPR;
        private System.Windows.Forms.TextBox txtPitch;
        private System.Windows.Forms.TextBox txtGearRatio;
        private System.Windows.Forms.TextBox txtHightLimit;
        private System.Windows.Forms.TextBox txtLowLimit;
        private System.Windows.Forms.TextBox txtPulseMode;
        private System.Windows.Forms.TextBox txtPulseWidth;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtHighSpeed;
        private System.Windows.Forms.TextBox txtLowSpeed;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.Button btnSaveMachine;
        private System.Windows.Forms.Button btnClearMachine;
        private System.Windows.Forms.Button btnDeleteMachine;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMachineName;
    }
}
