namespace Git_Paging
{
    partial class MyPage
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_pagecount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_index = new System.Windows.Forms.Label();
            this.txt_pagesize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.lab_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lab_pagecount);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lab_index);
            this.panel3.Controls.Add(this.txt_pagesize);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_last);
            this.panel3.Controls.Add(this.btn_next);
            this.panel3.Controls.Add(this.btn_pre);
            this.panel3.Controls.Add(this.btn_home);
            this.panel3.Controls.Add(this.lab_count);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 34);
            this.panel3.TabIndex = 6;
            // 
            // lab_pagecount
            // 
            this.lab_pagecount.AutoSize = true;
            this.lab_pagecount.Location = new System.Drawing.Point(349, 16);
            this.lab_pagecount.Name = "lab_pagecount";
            this.lab_pagecount.Size = new System.Drawing.Size(11, 12);
            this.lab_pagecount.TabIndex = 12;
            this.lab_pagecount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "/";
            // 
            // lab_index
            // 
            this.lab_index.AutoSize = true;
            this.lab_index.Location = new System.Drawing.Point(296, 16);
            this.lab_index.Name = "lab_index";
            this.lab_index.Size = new System.Drawing.Size(11, 12);
            this.lab_index.TabIndex = 10;
            this.lab_index.Text = "1";
            // 
            // txt_pagesize
            // 
            this.txt_pagesize.Location = new System.Drawing.Point(198, 10);
            this.txt_pagesize.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pagesize.Name = "txt_pagesize";
            this.txt_pagesize.Size = new System.Drawing.Size(55, 21);
            this.txt_pagesize.TabIndex = 9;
            this.txt_pagesize.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "条";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "每页显示：";
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(653, 9);
            this.btn_last.Margin = new System.Windows.Forms.Padding(2);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(56, 20);
            this.btn_last.TabIndex = 5;
            this.btn_last.Text = "末页";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(592, 9);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(56, 21);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "下一页";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(531, 9);
            this.btn_pre.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(56, 20);
            this.btn_pre.TabIndex = 3;
            this.btn_pre.Text = "上一页";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(470, 9);
            this.btn_home.Margin = new System.Windows.Forms.Padding(2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(56, 20);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "首页";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Location = new System.Drawing.Point(72, 13);
            this.lab_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(11, 12);
            this.lab_count.TabIndex = 1;
            this.lab_count.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "总条数：";
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "MyPage";
            this.Size = new System.Drawing.Size(719, 38);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lab_pagecount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_index;
        private System.Windows.Forms.TextBox txt_pagesize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lab_count;
        private System.Windows.Forms.Label label4;
    }
}
