namespace WindowsFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_val1 = new System.Windows.Forms.TextBox();
            this.tb_val2 = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_ma = new System.Windows.Forms.Button();
            this.btn_rhq = new System.Windows.Forms.Button();
            this.btn_na = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "결과";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "값1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "값2";
            // 
            // tb_val1
            // 
            this.tb_val1.Location = new System.Drawing.Point(170, 184);
            this.tb_val1.Name = "tb_val1";
            this.tb_val1.Size = new System.Drawing.Size(100, 21);
            this.tb_val1.TabIndex = 3;
            // 
            // tb_val2
            // 
            this.tb_val2.Location = new System.Drawing.Point(392, 184);
            this.tb_val2.Name = "tb_val2";
            this.tb_val2.Size = new System.Drawing.Size(100, 21);
            this.tb_val2.TabIndex = 4;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(170, 121);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(100, 21);
            this.tb_result.TabIndex = 5;
            this.tb_result.Enabled = false;
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_plus.Location = new System.Drawing.Point(12, 330);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(114, 108);
            this.btn_plus.TabIndex = 6;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_ma
            // 
            this.btn_ma.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_ma.Location = new System.Drawing.Point(180, 330);
            this.btn_ma.Name = "btn_ma";
            this.btn_ma.Size = new System.Drawing.Size(114, 108);
            this.btn_ma.TabIndex = 7;
            this.btn_ma.Text = "-";
            this.btn_ma.UseVisualStyleBackColor = true;
            this.btn_ma.Click += new System.EventHandler(this.btn_ma_Click);
            // 
            // btn_rhq
            // 
            this.btn_rhq.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_rhq.Location = new System.Drawing.Point(341, 330);
            this.btn_rhq.Name = "btn_rhq";
            this.btn_rhq.Size = new System.Drawing.Size(114, 108);
            this.btn_rhq.TabIndex = 8;
            this.btn_rhq.Text = "*";
            this.btn_rhq.UseVisualStyleBackColor = true;
            this.btn_rhq.Click += new System.EventHandler(this.btn_rhq_Click);
            // 
            // btn_na
            // 
            this.btn_na.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_na.Location = new System.Drawing.Point(489, 330);
            this.btn_na.Name = "btn_na";
            this.btn_na.Size = new System.Drawing.Size(114, 108);
            this.btn_na.TabIndex = 9;
            this.btn_na.Text = "/";
            this.btn_na.UseVisualStyleBackColor = true;
            this.btn_na.Click += new System.EventHandler(this.btn_na_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 444);
            this.Controls.Add(this.btn_na);
            this.Controls.Add(this.btn_rhq);
            this.Controls.Add(this.btn_ma);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_val2);
            this.Controls.Add(this.tb_val1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_val1;
        private System.Windows.Forms.TextBox tb_val2;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_ma;
        private System.Windows.Forms.Button btn_rhq;
        private System.Windows.Forms.Button btn_na;
    }
}

