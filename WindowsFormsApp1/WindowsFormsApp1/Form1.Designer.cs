namespace WindowsFormsApp1
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
            this.user_pwd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.user_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user_pwd
            // 
            this.user_pwd.HideSelection = false;
            this.user_pwd.Location = new System.Drawing.Point(130, 77);
            this.user_pwd.Name = "user_pwd";
            this.user_pwd.Size = new System.Drawing.Size(100, 21);
            this.user_pwd.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "登录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(130, 39);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(100, 21);
            this.user_id.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.user_pwd);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox user_pwd;
    }
}

