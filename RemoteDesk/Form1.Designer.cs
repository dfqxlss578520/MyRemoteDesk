namespace RemoteDesk
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.axMsTscAxNotSafeForScripting1 = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnBrokenConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMsTscAxNotSafeForScripting1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMsTscAxNotSafeForScripting1
            // 
            this.axMsTscAxNotSafeForScripting1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMsTscAxNotSafeForScripting1.Enabled = true;
            this.axMsTscAxNotSafeForScripting1.Location = new System.Drawing.Point(0, -12);
            this.axMsTscAxNotSafeForScripting1.Name = "axMsTscAxNotSafeForScripting1";
            this.axMsTscAxNotSafeForScripting1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsTscAxNotSafeForScripting1.OcxState")));
            this.axMsTscAxNotSafeForScripting1.Size = new System.Drawing.Size(889, 470);
            this.axMsTscAxNotSafeForScripting1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器ip";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(69, 470);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 21);
            this.txtServerIP.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(233, 471);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(397, 469);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密 码";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(533, 471);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "连 接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnBrokenConnect
            // 
            this.btnBrokenConnect.Location = new System.Drawing.Point(614, 471);
            this.btnBrokenConnect.Name = "btnBrokenConnect";
            this.btnBrokenConnect.Size = new System.Drawing.Size(75, 23);
            this.btnBrokenConnect.TabIndex = 8;
            this.btnBrokenConnect.Text = "断开连接";
            this.btnBrokenConnect.UseVisualStyleBackColor = true;
            this.btnBrokenConnect.Click += new System.EventHandler(this.btnBrokenConnect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 499);
            this.Controls.Add(this.btnBrokenConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axMsTscAxNotSafeForScripting1);
            this.Name = "frmMain";
            this.Text = "主界面";
            ((System.ComponentModel.ISupportInitialize)(this.axMsTscAxNotSafeForScripting1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting axMsTscAxNotSafeForScripting1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnBrokenConnect;
    }
}

