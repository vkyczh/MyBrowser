namespace MyBrowser
{
    partial class FormWeb
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
            this.pHead = new System.Windows.Forms.Panel();
            this.pTool = new System.Windows.Forms.Panel();
            this.pTitle = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.webKitBrowser1 = new WebKit.WebKitBrowser();
            this.btnExecuteScript = new System.Windows.Forms.Button();
            this.pHead.SuspendLayout();
            this.pTool.SuspendLayout();
            this.pContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHead
            // 
            this.pHead.Controls.Add(this.pTool);
            this.pHead.Controls.Add(this.pTitle);
            this.pHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHead.Location = new System.Drawing.Point(0, 0);
            this.pHead.Name = "pHead";
            this.pHead.Size = new System.Drawing.Size(677, 100);
            this.pHead.TabIndex = 0;
            // 
            // pTool
            // 
            this.pTool.Controls.Add(this.btnExecuteScript);
            this.pTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTool.Location = new System.Drawing.Point(0, 37);
            this.pTool.Name = "pTool";
            this.pTool.Size = new System.Drawing.Size(677, 63);
            this.pTool.TabIndex = 1;
            // 
            // pTitle
            // 
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(677, 37);
            this.pTitle.TabIndex = 0;
            // 
            // pContent
            // 
            this.pContent.Controls.Add(this.webKitBrowser1);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 100);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(677, 400);
            this.pContent.TabIndex = 1;
            // 
            // webKitBrowser1
            // 
            this.webKitBrowser1.AllowDrop = true;
            this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            this.webKitBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKitBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webKitBrowser1.Name = "webKitBrowser1";
            this.webKitBrowser1.Password = null;
            this.webKitBrowser1.PrivateBrowsing = false;
            this.webKitBrowser1.Size = new System.Drawing.Size(677, 400);
            this.webKitBrowser1.TabIndex = 0;
            this.webKitBrowser1.Url = null;
            this.webKitBrowser1.Username = null;
            // 
            // btnExecuteScript
            // 
            this.btnExecuteScript.Location = new System.Drawing.Point(240, 22);
            this.btnExecuteScript.Name = "btnExecuteScript";
            this.btnExecuteScript.Size = new System.Drawing.Size(138, 23);
            this.btnExecuteScript.TabIndex = 0;
            this.btnExecuteScript.Text = "ExecuteScript";
            this.btnExecuteScript.UseVisualStyleBackColor = true;
            this.btnExecuteScript.Click += new System.EventHandler(this.btnExecuteScript_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 500);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pHead.ResumeLayout(false);
            this.pTool.ResumeLayout(false);
            this.pContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHead;
        private System.Windows.Forms.Panel pTool;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Panel pContent;
        private WebKit.WebKitBrowser webKitBrowser1;
        private System.Windows.Forms.Button btnExecuteScript;
    }
}

