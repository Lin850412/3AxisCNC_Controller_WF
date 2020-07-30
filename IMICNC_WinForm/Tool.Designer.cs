namespace IMICNC_WinForm
{
    partial class Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_ToolSelect = new System.Windows.Forms.ComboBox();
            this.Btn_ToolClear = new System.Windows.Forms.Button();
            this.Btn_ToolSave = new System.Windows.Forms.Button();
            this.Btn_ToolDelete = new System.Windows.Forms.Button();
            this.Btn_ToolAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_PredictTime = new System.Windows.Forms.TextBox();
            this.Txt_UsedTime = new System.Windows.Forms.TextBox();
            this.Txt_Type = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_Tool = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PB_Tool = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tool)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.CB_ToolSelect);
            this.panel1.Controls.Add(this.Btn_ToolClear);
            this.panel1.Controls.Add(this.Btn_ToolSave);
            this.panel1.Controls.Add(this.Btn_ToolDelete);
            this.panel1.Controls.Add(this.Btn_ToolAdd);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 411);
            this.panel1.TabIndex = 0;
            // 
            // CB_ToolSelect
            // 
            this.CB_ToolSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CB_ToolSelect.FormattingEnabled = true;
            this.CB_ToolSelect.Location = new System.Drawing.Point(41, 30);
            this.CB_ToolSelect.Name = "CB_ToolSelect";
            this.CB_ToolSelect.Size = new System.Drawing.Size(221, 33);
            this.CB_ToolSelect.TabIndex = 24;
            this.CB_ToolSelect.SelectedIndexChanged += new System.EventHandler(this.CB_ToolSelect_SelectedIndexChanged);
            // 
            // Btn_ToolClear
            // 
            this.Btn_ToolClear.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ToolClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ToolClear.Location = new System.Drawing.Point(41, 248);
            this.Btn_ToolClear.Name = "Btn_ToolClear";
            this.Btn_ToolClear.Size = new System.Drawing.Size(221, 60);
            this.Btn_ToolClear.TabIndex = 23;
            this.Btn_ToolClear.Text = "清空資料";
            this.Btn_ToolClear.UseVisualStyleBackColor = false;
            this.Btn_ToolClear.Click += new System.EventHandler(this.Btn_ToolClear_Click);
            // 
            // Btn_ToolSave
            // 
            this.Btn_ToolSave.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ToolSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ToolSave.Location = new System.Drawing.Point(41, 168);
            this.Btn_ToolSave.Name = "Btn_ToolSave";
            this.Btn_ToolSave.Size = new System.Drawing.Size(221, 60);
            this.Btn_ToolSave.TabIndex = 22;
            this.Btn_ToolSave.Text = "儲存資料";
            this.Btn_ToolSave.UseVisualStyleBackColor = false;
            this.Btn_ToolSave.Click += new System.EventHandler(this.Btn_ToolSave_Click);
            // 
            // Btn_ToolDelete
            // 
            this.Btn_ToolDelete.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ToolDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ToolDelete.Location = new System.Drawing.Point(41, 328);
            this.Btn_ToolDelete.Name = "Btn_ToolDelete";
            this.Btn_ToolDelete.Size = new System.Drawing.Size(221, 60);
            this.Btn_ToolDelete.TabIndex = 21;
            this.Btn_ToolDelete.Text = "刪除刀具";
            this.Btn_ToolDelete.UseVisualStyleBackColor = false;
            this.Btn_ToolDelete.Click += new System.EventHandler(this.Btn_ToolDelete_Click);
            // 
            // Btn_ToolAdd
            // 
            this.Btn_ToolAdd.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ToolAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ToolAdd.Location = new System.Drawing.Point(41, 88);
            this.Btn_ToolAdd.Name = "Btn_ToolAdd";
            this.Btn_ToolAdd.Size = new System.Drawing.Size(221, 60);
            this.Btn_ToolAdd.TabIndex = 20;
            this.Btn_ToolAdd.Text = "新增刀具";
            this.Btn_ToolAdd.UseVisualStyleBackColor = false;
            this.Btn_ToolAdd.Click += new System.EventHandler(this.Btn_ToolAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(308, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 411);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.Txt_PredictTime);
            this.panel4.Controls.Add(this.Txt_UsedTime);
            this.panel4.Controls.Add(this.Txt_Type);
            this.panel4.Controls.Add(this.Txt_Name);
            this.panel4.Controls.Add(this.Txt_ID);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(4, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 324);
            this.panel4.TabIndex = 1;
            // 
            // Txt_PredictTime
            // 
            this.Txt_PredictTime.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_PredictTime.Location = new System.Drawing.Point(240, 262);
            this.Txt_PredictTime.Name = "Txt_PredictTime";
            this.Txt_PredictTime.Size = new System.Drawing.Size(180, 38);
            this.Txt_PredictTime.TabIndex = 14;
            // 
            // Txt_UsedTime
            // 
            this.Txt_UsedTime.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_UsedTime.Location = new System.Drawing.Point(240, 202);
            this.Txt_UsedTime.Name = "Txt_UsedTime";
            this.Txt_UsedTime.Size = new System.Drawing.Size(180, 38);
            this.Txt_UsedTime.TabIndex = 13;
            // 
            // Txt_Type
            // 
            this.Txt_Type.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_Type.Location = new System.Drawing.Point(240, 139);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.Size = new System.Drawing.Size(180, 38);
            this.Txt_Type.TabIndex = 12;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_Name.Location = new System.Drawing.Point(240, 78);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(180, 38);
            this.Txt_Name.TabIndex = 11;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_ID.Location = new System.Drawing.Point(240, 22);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(180, 38);
            this.Txt_ID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(23, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "預估換刀時間：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(23, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "累積使用時間：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "刀具型別：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "刀具名稱：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "編號：";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.Lb_Tool);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 75);
            this.panel3.TabIndex = 0;
            // 
            // Lb_Tool
            // 
            this.Lb_Tool.AutoSize = true;
            this.Lb_Tool.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_Tool.Location = new System.Drawing.Point(19, 16);
            this.Lb_Tool.Name = "Lb_Tool";
            this.Lb_Tool.Size = new System.Drawing.Size(150, 42);
            this.Lb_Tool.TabIndex = 0;
            this.Lb_Tool.Text = "刀具資訊";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(766, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 411);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.PB_Tool);
            this.panel7.Location = new System.Drawing.Point(4, 84);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 324);
            this.panel7.TabIndex = 2;
            // 
            // PB_Tool
            // 
            this.PB_Tool.Image = ((System.Drawing.Image)(resources.GetObject("PB_Tool.Image")));
            this.PB_Tool.Location = new System.Drawing.Point(84, 3);
            this.PB_Tool.Name = "PB_Tool";
            this.PB_Tool.Size = new System.Drawing.Size(129, 318);
            this.PB_Tool.TabIndex = 0;
            this.PB_Tool.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 75);
            this.panel6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(19, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "刀具示意圖";
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Tool";
            this.Size = new System.Drawing.Size(1074, 423);
            this.Load += new System.EventHandler(this.Tool_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tool)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_ToolSelect;
        private System.Windows.Forms.Button Btn_ToolClear;
        private System.Windows.Forms.Button Btn_ToolSave;
        private System.Windows.Forms.Button Btn_ToolDelete;
        private System.Windows.Forms.Button Btn_ToolAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lb_Tool;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_PredictTime;
        private System.Windows.Forms.TextBox Txt_UsedTime;
        private System.Windows.Forms.TextBox Txt_Type;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox PB_Tool;
    }
}
