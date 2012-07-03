namespace PingPang
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
            this.rtBoy = new System.Windows.Forms.RichTextBox();
            this.rtGirl = new System.Windows.Forms.RichTextBox();
            this.组队 = new System.Windows.Forms.Button();
            this.rtResult = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtBoy
            // 
            this.rtBoy.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtBoy.Location = new System.Drawing.Point(0, 0);
            this.rtBoy.Name = "rtBoy";
            this.rtBoy.Size = new System.Drawing.Size(200, 277);
            this.rtBoy.TabIndex = 1;
            this.rtBoy.Text = "pubby\n小五\n小六\n石头\njjj\n三哥\n甲文\n小吴\n小袁\n小冯\n小何\n小姚\n昌哥\n西施\n老大\n袁飞";
            // 
            // rtGirl
            // 
            this.rtGirl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtGirl.Location = new System.Drawing.Point(0, 277);
            this.rtGirl.Name = "rtGirl";
            this.rtGirl.Size = new System.Drawing.Size(200, 217);
            this.rtGirl.TabIndex = 2;
            this.rtGirl.Text = "叶子\n酱油\n小虞\n汤圆\n马燕\n小姜\n高磊\n丽燕\n小魏\n小郭\n小席\n波波";
            // 
            // 组队
            // 
            this.组队.Location = new System.Drawing.Point(206, 0);
            this.组队.Name = "组队";
            this.组队.Size = new System.Drawing.Size(83, 23);
            this.组队.TabIndex = 3;
            this.组队.Text = "组队";
            this.组队.UseVisualStyleBackColor = true;
            this.组队.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtResult
            // 
            this.rtResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtResult.Location = new System.Drawing.Point(287, 0);
            this.rtResult.Name = "rtResult";
            this.rtResult.Size = new System.Drawing.Size(272, 494);
            this.rtResult.TabIndex = 1;
            this.rtResult.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtGirl);
            this.panel1.Controls.Add(this.rtBoy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 494);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 494);
            this.Controls.Add(this.rtResult);
            this.Controls.Add(this.组队);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoy;
        private System.Windows.Forms.RichTextBox rtGirl;
        private System.Windows.Forms.Button 组队;
        private System.Windows.Forms.RichTextBox rtResult;
        private System.Windows.Forms.Panel panel1;
    }
}

