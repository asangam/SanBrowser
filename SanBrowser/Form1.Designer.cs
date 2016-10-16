namespace SanBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlStop = new System.Windows.Forms.Panel();
            this.pnlBackward = new System.Windows.Forms.Panel();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.pnlForward = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(217, 12);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(538, 31);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://";
            this.txtUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlHome);
            this.panel1.Controls.Add(this.pnlStop);
            this.panel1.Controls.Add(this.pnlBackward);
            this.panel1.Controls.Add(this.pnlRefresh);
            this.panel1.Controls.Add(this.pnlForward);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 56);
            this.panel1.TabIndex = 1;
            // 
            // pnlHome
            // 
            this.pnlHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHome.BackgroundImage")));
            this.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlHome.Location = new System.Drawing.Point(176, 10);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(36, 33);
            this.pnlHome.TabIndex = 24;
            // 
            // pnlStop
            // 
            this.pnlStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlStop.BackgroundImage")));
            this.pnlStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlStop.Location = new System.Drawing.Point(133, 10);
            this.pnlStop.Name = "pnlStop";
            this.pnlStop.Size = new System.Drawing.Size(36, 33);
            this.pnlStop.TabIndex = 21;
            // 
            // pnlBackward
            // 
            this.pnlBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackward.BackgroundImage")));
            this.pnlBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackward.Location = new System.Drawing.Point(44, 10);
            this.pnlBackward.Name = "pnlBackward";
            this.pnlBackward.Size = new System.Drawing.Size(36, 33);
            this.pnlBackward.TabIndex = 22;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRefresh.BackgroundImage")));
            this.pnlRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRefresh.Location = new System.Drawing.Point(88, 10);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(36, 33);
            this.pnlRefresh.TabIndex = 23;
            // 
            // pnlForward
            // 
            this.pnlForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlForward.BackgroundImage")));
            this.pnlForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlForward.Location = new System.Drawing.Point(1, 10);
            this.pnlForward.Name = "pnlForward";
            this.pnlForward.Size = new System.Drawing.Size(36, 33);
            this.pnlForward.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.webBrowser);
            this.panel7.Location = new System.Drawing.Point(0, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(755, 375);
            this.panel7.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(751, 371);
            this.webBrowser.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 437);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SanBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlStop;
        private System.Windows.Forms.Panel pnlBackward;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Panel pnlForward;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

