namespace SqlToExcel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbwarn = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clbTableName = new System.Windows.Forms.CheckedListBox();
            this.cbDataName = new System.Windows.Forms.ComboBox();
            this.btndisCon = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.textServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbExcelAdr = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbwarn);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.clbTableName);
            this.groupBox1.Controls.Add(this.cbDataName);
            this.groupBox1.Controls.Add(this.btndisCon);
            this.groupBox1.Controls.Add(this.btnCon);
            this.groupBox1.Controls.Add(this.Pwd);
            this.groupBox1.Controls.Add(this.UID);
            this.groupBox1.Controls.Add(this.textServer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库连接";
            // 
            // lbwarn
            // 
            this.lbwarn.AutoSize = true;
            this.lbwarn.Location = new System.Drawing.Point(183, 334);
            this.lbwarn.Name = "lbwarn";
            this.lbwarn.Size = new System.Drawing.Size(0, 12);
            this.lbwarn.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(114, 334);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "全选";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clbTableName
            // 
            this.clbTableName.FormattingEnabled = true;
            this.clbTableName.Location = new System.Drawing.Point(114, 232);
            this.clbTableName.Name = "clbTableName";
            this.clbTableName.Size = new System.Drawing.Size(234, 100);
            this.clbTableName.TabIndex = 5;
            // 
            // cbDataName
            // 
            this.cbDataName.FormattingEnabled = true;
            this.cbDataName.Location = new System.Drawing.Point(114, 206);
            this.cbDataName.Name = "cbDataName";
            this.cbDataName.Size = new System.Drawing.Size(204, 20);
            this.cbDataName.TabIndex = 4;
            this.cbDataName.SelectedIndexChanged += new System.EventHandler(this.cbDataName_SelectedIndexChanged);
            // 
            // btndisCon
            // 
            this.btndisCon.Location = new System.Drawing.Point(259, 158);
            this.btndisCon.Name = "btndisCon";
            this.btndisCon.Size = new System.Drawing.Size(89, 33);
            this.btndisCon.TabIndex = 3;
            this.btndisCon.Text = "断开";
            this.btndisCon.UseVisualStyleBackColor = true;
            this.btndisCon.Click += new System.EventHandler(this.btndisCon_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(94, 158);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(89, 33);
            this.btnCon.TabIndex = 3;
            this.btnCon.Text = "连接";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // Pwd
            // 
            this.Pwd.Location = new System.Drawing.Point(114, 131);
            this.Pwd.Name = "Pwd";
            this.Pwd.PasswordChar = '*';
            this.Pwd.ReadOnly = true;
            this.Pwd.Size = new System.Drawing.Size(234, 21);
            this.Pwd.TabIndex = 2;
            this.Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pwd_KeyDown);
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(114, 93);
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Size = new System.Drawing.Size(234, 21);
            this.UID.TabIndex = 2;
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(114, 30);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(234, 21);
            this.textServer.TabIndex = 2;
            this.textServer.Text = "(local)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "选择数据库表：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据库名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器名称：";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(253, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Sql server验证";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Windows验证";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "选择Excel存储路径：";
            // 
            // tbExcelAdr
            // 
            this.tbExcelAdr.Location = new System.Drawing.Point(126, 376);
            this.tbExcelAdr.Name = "tbExcelAdr";
            this.tbExcelAdr.Size = new System.Drawing.Size(155, 21);
            this.tbExcelAdr.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(106, 410);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(254, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始导出";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(285, 374);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "浏览";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 455);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbExcelAdr);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlToExcel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbTableName;
        private System.Windows.Forms.ComboBox cbDataName;
        private System.Windows.Forms.Button btndisCon;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbExcelAdr;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbwarn;
    }
}

