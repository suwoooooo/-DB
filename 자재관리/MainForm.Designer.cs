﻿namespace 자재관리
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.닫기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.물품ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConCheck = new System.Windows.Forms.Button();
            this.장부작성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.닫기XToolStripMenuItem,
            this.직원ToolStripMenuItem,
            this.물품ToolStripMenuItem,
            this.고객ToolStripMenuItem,
            this.장부작성ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 닫기XToolStripMenuItem
            // 
            this.닫기XToolStripMenuItem.Name = "닫기XToolStripMenuItem";
            this.닫기XToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.닫기XToolStripMenuItem.Text = "닫기(&X)";
            this.닫기XToolStripMenuItem.Click += new System.EventHandler(this.닫기XToolStripMenuItem_Click);
            // 
            // 직원ToolStripMenuItem
            // 
            this.직원ToolStripMenuItem.Name = "직원ToolStripMenuItem";
            this.직원ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.직원ToolStripMenuItem.Text = "직원";
            this.직원ToolStripMenuItem.Click += new System.EventHandler(this.직원ToolStripMenuItem_Click);
            // 
            // 물품ToolStripMenuItem
            // 
            this.물품ToolStripMenuItem.Name = "물품ToolStripMenuItem";
            this.물품ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.물품ToolStripMenuItem.Text = "물품";
            this.물품ToolStripMenuItem.Click += new System.EventHandler(this.물품ToolStripMenuItem_Click);
            // 
            // 고객ToolStripMenuItem
            // 
            this.고객ToolStripMenuItem.Name = "고객ToolStripMenuItem";
            this.고객ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.고객ToolStripMenuItem.Text = "고객";
            this.고객ToolStripMenuItem.Click += new System.EventHandler(this.고객ToolStripMenuItem_Click);
            // 
            // btnConCheck
            // 
            this.btnConCheck.Location = new System.Drawing.Point(1013, 0);
            this.btnConCheck.Name = "btnConCheck";
            this.btnConCheck.Size = new System.Drawing.Size(79, 24);
            this.btnConCheck.TabIndex = 7;
            this.btnConCheck.Text = "접속 체크";
            this.btnConCheck.UseVisualStyleBackColor = true;
            this.btnConCheck.Visible = false;
            this.btnConCheck.Click += new System.EventHandler(this.btnConCheck_Click);
            // 
            // 장부작성ToolStripMenuItem
            // 
            this.장부작성ToolStripMenuItem.Name = "장부작성ToolStripMenuItem";
            this.장부작성ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.장부작성ToolStripMenuItem.Text = "장부작성";
            this.장부작성ToolStripMenuItem.Click += new System.EventHandler(this.장부작성ToolStripMenuItem_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 695);

            this.Controls.Add(this.btnConCheck);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "자재관리프로그램";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 닫기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 물품ToolStripMenuItem;
        private System.Windows.Forms.Button btnConCheck;
        private System.Windows.Forms.ToolStripMenuItem 고객ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장부작성ToolStripMenuItem;

    }
}

