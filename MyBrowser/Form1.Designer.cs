namespace MyBrowser
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
            this.pHead = new System.Windows.Forms.Panel();
            this.pTool = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeparate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnExecuteScript = new System.Windows.Forms.Button();
            this.pTitle = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.pHead.SuspendLayout();
            this.pTool.SuspendLayout();
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
            this.pTool.Controls.Add(this.button1);
            this.pTool.Controls.Add(this.btnSeparate);
            this.pTool.Controls.Add(this.groupBox1);
            this.pTool.Controls.Add(this.btnMove);
            this.pTool.Controls.Add(this.btnExecuteScript);
            this.pTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTool.Location = new System.Drawing.Point(0, 37);
            this.pTool.Name = "pTool";
            this.pTool.Size = new System.Drawing.Size(677, 63);
            this.pTool.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // btnSeparate
            // 
            this.btnSeparate.Location = new System.Drawing.Point(545, 22);
            this.btnSeparate.Name = "btnSeparate";
            this.btnSeparate.Size = new System.Drawing.Size(75, 23);
            this.btnSeparate.TabIndex = 3;
            this.btnSeparate.Text = "Separate";
            this.btnSeparate.UseVisualStyleBackColor = true;
            this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
            this.btnSeparate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSeparate_MouseDown);
            this.btnSeparate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSeparate_MouseMove);
            this.btnSeparate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSeparate_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(34, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragEnter);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(421, 22);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnExecuteScript
            // 
            this.btnExecuteScript.Location = new System.Drawing.Point(277, 22);
            this.btnExecuteScript.Name = "btnExecuteScript";
            this.btnExecuteScript.Size = new System.Drawing.Size(138, 23);
            this.btnExecuteScript.TabIndex = 0;
            this.btnExecuteScript.Text = "ExecuteScript";
            this.btnExecuteScript.UseVisualStyleBackColor = true;
            this.btnExecuteScript.Click += new System.EventHandler(this.btnExecuteScript_Click);
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
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 100);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(677, 400);
            this.pContent.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHead;
        private System.Windows.Forms.Panel pTool;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Button btnExecuteScript;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeparate;
        private System.Windows.Forms.Button button1;
    }
}

