namespace WindowsFormsApp6
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
            this.btn_for = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.bnt_foreach = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_dowhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(492, 12);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(182, 82);
            this.btn_for.TabIndex = 0;
            this.btn_for.Text = "For문";
            this.btn_for.UseVisualStyleBackColor = false;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 12);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(474, 346);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // bnt_foreach
            // 
            this.bnt_foreach.Location = new System.Drawing.Point(492, 100);
            this.bnt_foreach.Name = "bnt_foreach";
            this.bnt_foreach.Size = new System.Drawing.Size(182, 82);
            this.bnt_foreach.TabIndex = 2;
            this.bnt_foreach.Text = "Foreach문";
            this.bnt_foreach.UseVisualStyleBackColor = true;
            this.bnt_foreach.Click += new System.EventHandler(this.bnt_foreach_Click);
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(492, 188);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(182, 82);
            this.btn_while.TabIndex = 3;
            this.btn_while.Text = "While 문";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_dowhile
            // 
            this.btn_dowhile.Location = new System.Drawing.Point(492, 276);
            this.btn_dowhile.Name = "btn_dowhile";
            this.btn_dowhile.Size = new System.Drawing.Size(182, 82);
            this.btn_dowhile.TabIndex = 4;
            this.btn_dowhile.Text = "doWhile문";
            this.btn_dowhile.UseVisualStyleBackColor = true;
            this.btn_dowhile.Click += new System.EventHandler(this.btn_dowhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 366);
            this.Controls.Add(this.btn_dowhile);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.bnt_foreach);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btn_for);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button bnt_foreach;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_dowhile;
    }
}

