namespace IMICNC_WinForm
{
    partial class Monitor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_ShowLine = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_StartCode = new System.Windows.Forms.Button();
            this.CodeList = new System.Windows.Forms.ListBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.85132F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Lb_ShowLine);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 52);
            this.panel1.TabIndex = 0;
            // 
            // Lb_ShowLine
            // 
            this.Lb_ShowLine.AutoSize = true;
            this.Lb_ShowLine.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_ShowLine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_ShowLine.Location = new System.Drawing.Point(93, 8);
            this.Lb_ShowLine.Name = "Lb_ShowLine";
            this.Lb_ShowLine.Size = new System.Drawing.Size(257, 38);
            this.Lb_ShowLine.TabIndex = 0;
            this.Lb_ShowLine.Text = "即時加工路徑顯示";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 353);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CodeList, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(469, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 417);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Btn_StartCode);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(335, 52);
            this.panel7.TabIndex = 1;
            // 
            // Btn_StartCode
            // 
            this.Btn_StartCode.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_StartCode.Location = new System.Drawing.Point(23, 4);
            this.Btn_StartCode.Name = "Btn_StartCode";
            this.Btn_StartCode.Size = new System.Drawing.Size(285, 45);
            this.Btn_StartCode.TabIndex = 0;
            this.Btn_StartCode.Text = "開始加工";
            this.Btn_StartCode.UseVisualStyleBackColor = true;
            this.Btn_StartCode.Click += new System.EventHandler(this.Btn_StartCode_Click);
            // 
            // CodeList
            // 
            this.CodeList.FormattingEnabled = true;
            this.CodeList.ItemHeight = 15;
            this.CodeList.Location = new System.Drawing.Point(3, 61);
            this.CodeList.Name = "CodeList";
            this.CodeList.Size = new System.Drawing.Size(335, 349);
            this.CodeList.TabIndex = 0;
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
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.panel5.Size = new System.Drawing.Size(248, 154);
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
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Monitor";
            this.Size = new System.Drawing.Size(1074, 423);
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox CodeList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_ShowLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lb_Op;
        private System.Windows.Forms.Label Lb_Ab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lb_BZ;
        private System.Windows.Forms.Label Lb_BY;
        private System.Windows.Forms.Label Lb_BX;
        private System.Windows.Forms.Label Lb_AZ;
        private System.Windows.Forms.Label Lb_AY;
        private System.Windows.Forms.Label Lb_AX;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Btn_StartCode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
