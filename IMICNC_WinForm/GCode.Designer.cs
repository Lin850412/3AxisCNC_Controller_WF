namespace IMICNC_WinForm
{
    partial class GCode
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtxtGCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ConfirmFile = new System.Windows.Forms.Button();
            this.Btn_LoadFile = new System.Windows.Forms.Button();
            this.txtFilePlace = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Lb_FilePlace = new System.Windows.Forms.Label();
            this.Lb_FileName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lb_BZ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_BY = new System.Windows.Forms.Label();
            this.Lb_BX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lb_Op = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_AZ = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lb_AY = new System.Windows.Forms.Label();
            this.Lb_AX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lb_Ab = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.26139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.73861F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rtxtGCode);
            this.panel6.Location = new System.Drawing.Point(3, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(805, 315);
            this.panel6.TabIndex = 1;
            // 
            // rtxtGCode
            // 
            this.rtxtGCode.Location = new System.Drawing.Point(4, 5);
            this.rtxtGCode.Multiline = true;
            this.rtxtGCode.Name = "rtxtGCode";
            this.rtxtGCode.Size = new System.Drawing.Size(798, 307);
            this.rtxtGCode.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_ConfirmFile);
            this.panel1.Controls.Add(this.Btn_LoadFile);
            this.panel1.Controls.Add(this.txtFilePlace);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.Lb_FilePlace);
            this.panel1.Controls.Add(this.Lb_FileName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 90);
            this.panel1.TabIndex = 0;
            // 
            // Btn_ConfirmFile
            // 
            this.Btn_ConfirmFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ConfirmFile.Location = new System.Drawing.Point(653, 15);
            this.Btn_ConfirmFile.Name = "Btn_ConfirmFile";
            this.Btn_ConfirmFile.Size = new System.Drawing.Size(120, 61);
            this.Btn_ConfirmFile.TabIndex = 5;
            this.Btn_ConfirmFile.Text = "確認檔案";
            this.Btn_ConfirmFile.UseVisualStyleBackColor = true;
            this.Btn_ConfirmFile.Click += new System.EventHandler(this.Btn_ConfirmFile_Click);
            // 
            // Btn_LoadFile
            // 
            this.Btn_LoadFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_LoadFile.Location = new System.Drawing.Point(519, 16);
            this.Btn_LoadFile.Name = "Btn_LoadFile";
            this.Btn_LoadFile.Size = new System.Drawing.Size(120, 61);
            this.Btn_LoadFile.TabIndex = 4;
            this.Btn_LoadFile.Text = "載入檔案";
            this.Btn_LoadFile.UseVisualStyleBackColor = true;
            this.Btn_LoadFile.Click += new System.EventHandler(this.Btn_LoadFile_Click);
            // 
            // txtFilePlace
            // 
            this.txtFilePlace.Location = new System.Drawing.Point(143, 51);
            this.txtFilePlace.Name = "txtFilePlace";
            this.txtFilePlace.Size = new System.Drawing.Size(339, 25);
            this.txtFilePlace.TabIndex = 3;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(143, 15);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(339, 25);
            this.txtFileName.TabIndex = 2;
            // 
            // Lb_FilePlace
            // 
            this.Lb_FilePlace.AutoSize = true;
            this.Lb_FilePlace.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_FilePlace.Location = new System.Drawing.Point(24, 51);
            this.Lb_FilePlace.Name = "Lb_FilePlace";
            this.Lb_FilePlace.Size = new System.Drawing.Size(112, 25);
            this.Lb_FilePlace.TabIndex = 1;
            this.Lb_FilePlace.Text = "檔案位置：";
            // 
            // Lb_FileName
            // 
            this.Lb_FileName.AutoSize = true;
            this.Lb_FileName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_FileName.Location = new System.Drawing.Point(24, 16);
            this.Lb_FileName.Name = "Lb_FileName";
            this.Lb_FileName.Size = new System.Drawing.Size(112, 25);
            this.Lb_FileName.TabIndex = 0;
            this.Lb_FileName.Text = "檔案名稱：";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(817, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 417);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Lb_BZ);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.Lb_BY);
            this.panel5.Controls.Add(this.Lb_BX);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 156);
            this.panel5.TabIndex = 2;
            // 
            // Lb_BZ
            // 
            this.Lb_BZ.AutoSize = true;
            this.Lb_BZ.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_BZ.Location = new System.Drawing.Point(114, 98);
            this.Lb_BZ.Name = "Lb_BZ";
            this.Lb_BZ.Size = new System.Drawing.Size(118, 42);
            this.Lb_BZ.TabIndex = 26;
            this.Lb_BZ.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Z";
            // 
            // Lb_BY
            // 
            this.Lb_BY.AutoSize = true;
            this.Lb_BY.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lb_BY.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_BY.Location = new System.Drawing.Point(114, 54);
            this.Lb_BY.Name = "Lb_BY";
            this.Lb_BY.Size = new System.Drawing.Size(118, 42);
            this.Lb_BY.TabIndex = 25;
            this.Lb_BY.Text = "00000";
            // 
            // Lb_BX
            // 
            this.Lb_BX.AutoSize = true;
            this.Lb_BX.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_BX.Location = new System.Drawing.Point(114, 11);
            this.Lb_BX.Name = "Lb_BX";
            this.Lb_BX.Size = new System.Drawing.Size(118, 42);
            this.Lb_BX.TabIndex = 24;
            this.Lb_BX.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "X";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Lb_Op);
            this.panel4.Location = new System.Drawing.Point(3, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 39);
            this.panel4.TabIndex = 1;
            // 
            // Lb_Op
            // 
            this.Lb_Op.AutoSize = true;
            this.Lb_Op.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_Op.Location = new System.Drawing.Point(3, 3);
            this.Lb_Op.Name = "Lb_Op";
            this.Lb_Op.Size = new System.Drawing.Size(127, 36);
            this.Lb_Op.TabIndex = 4;
            this.Lb_Op.Text = "絕對座標";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Lb_AZ);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Lb_AY);
            this.panel3.Controls.Add(this.Lb_AX);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 159);
            this.panel3.TabIndex = 1;
            // 
            // Lb_AZ
            // 
            this.Lb_AZ.AutoSize = true;
            this.Lb_AZ.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_AZ.Location = new System.Drawing.Point(114, 98);
            this.Lb_AZ.Name = "Lb_AZ";
            this.Lb_AZ.Size = new System.Drawing.Size(118, 42);
            this.Lb_AZ.TabIndex = 23;
            this.Lb_AZ.Text = "00000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 38);
            this.label9.TabIndex = 17;
            this.label9.Text = "Z";
            // 
            // Lb_AY
            // 
            this.Lb_AY.AutoSize = true;
            this.Lb_AY.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lb_AY.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_AY.Location = new System.Drawing.Point(114, 54);
            this.Lb_AY.Name = "Lb_AY";
            this.Lb_AY.Size = new System.Drawing.Size(118, 42);
            this.Lb_AY.TabIndex = 22;
            this.Lb_AY.Text = "00000";
            // 
            // Lb_AX
            // 
            this.Lb_AX.AutoSize = true;
            this.Lb_AX.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_AX.Location = new System.Drawing.Point(114, 11);
            this.Lb_AX.Name = "Lb_AX";
            this.Lb_AX.Size = new System.Drawing.Size(118, 42);
            this.Lb_AX.TabIndex = 21;
            this.Lb_AX.Text = "00000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 38);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 38);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lb_Ab);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 39);
            this.panel2.TabIndex = 0;
            // 
            // Lb_Ab
            // 
            this.Lb_Ab.AutoSize = true;
            this.Lb_Ab.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_Ab.Location = new System.Drawing.Point(3, 2);
            this.Lb_Ab.Name = "Lb_Ab";
            this.Lb_Ab.Size = new System.Drawing.Size(127, 36);
            this.Lb_Ab.TabIndex = 3;
            this.Lb_Ab.Text = "機械座標";
            // 
            // GCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GCode";
            this.Size = new System.Drawing.Size(1074, 423);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lb_BZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_BY;
        private System.Windows.Forms.Label Lb_BX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lb_Op;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lb_AZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lb_AY;
        private System.Windows.Forms.Label Lb_AX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lb_Ab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_FilePlace;
        private System.Windows.Forms.Label Lb_FileName;
        private System.Windows.Forms.TextBox rtxtGCode;
        private System.Windows.Forms.Button Btn_ConfirmFile;
        private System.Windows.Forms.Button Btn_LoadFile;
        private System.Windows.Forms.TextBox txtFilePlace;
        private System.Windows.Forms.TextBox txtFileName;
    }
}
