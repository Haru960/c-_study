namespace WindowsFormsApp5
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
            this.btn_num = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Result1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_result2 = new System.Windows.Forms.Label();
            this.cb_01 = new System.Windows.Forms.ComboBox();
            this.num_01 = new System.Windows.Forms.NumericUpDown();
            this.num_02 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_02)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. 숫자 비교";
            // 
            // btn_num
            // 
            this.btn_num.Location = new System.Drawing.Point(185, 40);
            this.btn_num.Name = "btn_num";
            this.btn_num.Size = new System.Drawing.Size(75, 23);
            this.btn_num.TabIndex = 1;
            this.btn_num.Text = "클릭";
            this.btn_num.UseVisualStyleBackColor = true;
            this.btn_num.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "첫 번째 숫자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "두 번째 숫자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "결과 : ";
            // 
            // lb_Result1
            // 
            this.lb_Result1.AutoSize = true;
            this.lb_Result1.Location = new System.Drawing.Point(115, 175);
            this.lb_Result1.Name = "lb_Result1";
            this.lb_Result1.Size = new System.Drawing.Size(11, 12);
            this.lb_Result1.TabIndex = 5;
            this.lb_Result1.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(32, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "2. 요일 선택";
            // 
            // btn_sel
            // 
            this.btn_sel.Location = new System.Drawing.Point(185, 260);
            this.btn_sel.Name = "btn_sel";
            this.btn_sel.Size = new System.Drawing.Size(75, 23);
            this.btn_sel.TabIndex = 7;
            this.btn_sel.Text = "클릭";
            this.btn_sel.UseVisualStyleBackColor = true;
            this.btn_sel.Click += new System.EventHandler(this.btn_sel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "결과 : ";
            // 
            // lb_result2
            // 
            this.lb_result2.AutoSize = true;
            this.lb_result2.Location = new System.Drawing.Point(115, 346);
            this.lb_result2.Name = "lb_result2";
            this.lb_result2.Size = new System.Drawing.Size(11, 12);
            this.lb_result2.TabIndex = 9;
            this.lb_result2.Text = "-";
            // 
            // cb_01
            // 
            this.cb_01.FormattingEnabled = true;
            this.cb_01.Items.AddRange(new object[] {
            "일",
            "월",
            "화",
            "수",
            "목",
            "금",
            "토"});
            this.cb_01.Location = new System.Drawing.Point(52, 297);
            this.cb_01.Name = "cb_01";
            this.cb_01.Size = new System.Drawing.Size(121, 20);
            this.cb_01.TabIndex = 10;
            this.cb_01.Text = "일";
            // 
            // num_01
            // 
            this.num_01.Location = new System.Drawing.Point(140, 90);
            this.num_01.Name = "num_01";
            this.num_01.Size = new System.Drawing.Size(120, 21);
            this.num_01.TabIndex = 11;
            // 
            // num_02
            // 
            this.num_02.Location = new System.Drawing.Point(444, 90);
            this.num_02.Name = "num_02";
            this.num_02.Size = new System.Drawing.Size(120, 21);
            this.num_02.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 452);
            this.Controls.Add(this.num_02);
            this.Controls.Add(this.num_01);
            this.Controls.Add(this.cb_01);
            this.Controls.Add(this.lb_result2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_sel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_Result1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_num);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "뷁꿹휅";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Result1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_result2;
        private System.Windows.Forms.ComboBox cb_01;
        private System.Windows.Forms.NumericUpDown num_01;
        private System.Windows.Forms.NumericUpDown num_02;
    }
}

