namespace WindowsFormsApp13
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윈도우ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.윈도우ToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            resources.ApplyResources(this.파일ToolStripMenuItem, "파일ToolStripMenuItem");
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼1ToolStripMenuItem,
            this.폼2ToolStripMenuItem,
            this.asdToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            // 
            // 폼1ToolStripMenuItem
            // 
            resources.ApplyResources(this.폼1ToolStripMenuItem, "폼1ToolStripMenuItem");
            this.폼1ToolStripMenuItem.Name = "폼1ToolStripMenuItem";
            this.폼1ToolStripMenuItem.Click += new System.EventHandler(this.폼1ToolStripMenuItem_Click);
            // 
            // 폼2ToolStripMenuItem
            // 
            resources.ApplyResources(this.폼2ToolStripMenuItem, "폼2ToolStripMenuItem");
            this.폼2ToolStripMenuItem.Name = "폼2ToolStripMenuItem";
            this.폼2ToolStripMenuItem.Click += new System.EventHandler(this.폼2ToolStripMenuItem_Click);
            // 
            // 윈도우ToolStripMenuItem
            // 
            resources.ApplyResources(this.윈도우ToolStripMenuItem, "윈도우ToolStripMenuItem");
            this.윈도우ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼3ToolStripMenuItem,
            this.폼4ToolStripMenuItem});
            this.윈도우ToolStripMenuItem.Name = "윈도우ToolStripMenuItem";
            // 
            // 폼3ToolStripMenuItem
            // 
            resources.ApplyResources(this.폼3ToolStripMenuItem, "폼3ToolStripMenuItem");
            this.폼3ToolStripMenuItem.Name = "폼3ToolStripMenuItem";
            this.폼3ToolStripMenuItem.Click += new System.EventHandler(this.폼3ToolStripMenuItem_Click);
            // 
            // 폼4ToolStripMenuItem
            // 
            resources.ApplyResources(this.폼4ToolStripMenuItem, "폼4ToolStripMenuItem");
            this.폼4ToolStripMenuItem.Name = "폼4ToolStripMenuItem";
            // 
            // asdToolStripMenuItem
            // 
            resources.ApplyResources(this.asdToolStripMenuItem, "asdToolStripMenuItem");
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
    }
}

