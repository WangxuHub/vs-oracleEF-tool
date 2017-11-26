namespace TopLevelMenu
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.txtEdmxSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdmxDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboEdmxList = new System.Windows.Forms.ComboBox();
            this.comboBoxConnString = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(443, 557);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "生成";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库连接字符串：";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Location = new System.Drawing.Point(255, 383);
            this.txtConnStr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConnStr.Multiline = true;
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(600, 90);
            this.txtConnStr.TabIndex = 2;
            // 
            // txtEdmxSrc
            // 
            this.txtEdmxSrc.Location = new System.Drawing.Point(255, 91);
            this.txtEdmxSrc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdmxSrc.Multiline = true;
            this.txtEdmxSrc.Name = "txtEdmxSrc";
            this.txtEdmxSrc.Size = new System.Drawing.Size(600, 90);
            this.txtEdmxSrc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "源Edmx文件的物理路径：";
            // 
            // txtEdmxDes
            // 
            this.txtEdmxDes.Location = new System.Drawing.Point(255, 189);
            this.txtEdmxDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdmxDes.Multiline = true;
            this.txtEdmxDes.Name = "txtEdmxDes";
            this.txtEdmxDes.Size = new System.Drawing.Size(600, 90);
            this.txtEdmxDes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "新生成Edmx文件的物理路径：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "选择edmx文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "选择数据库链接字符串";
            // 
            // comboEdmxList
            // 
            this.comboEdmxList.FormattingEnabled = true;
            this.comboEdmxList.Location = new System.Drawing.Point(255, 34);
            this.comboEdmxList.Name = "comboEdmxList";
            this.comboEdmxList.Size = new System.Drawing.Size(600, 23);
            this.comboEdmxList.TabIndex = 9;
            // 
            // comboBoxConnString
            // 
            this.comboBoxConnString.FormattingEnabled = true;
            this.comboBoxConnString.Location = new System.Drawing.Point(255, 320);
            this.comboBoxConnString.Name = "comboBoxConnString";
            this.comboBoxConnString.Size = new System.Drawing.Size(600, 23);
            this.comboBoxConnString.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 660);
            this.Controls.Add(this.comboBoxConnString);
            this.Controls.Add(this.comboEdmxList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdmxDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdmxSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "EF映射添加注释工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.TextBox txtEdmxSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdmxDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEdmxList;
        private System.Windows.Forms.ComboBox comboBoxConnString;
    }
}

