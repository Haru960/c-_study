namespace WindowsFormsApp3
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
            this.btn_short = new System.Windows.Forms.Button();
            this.btn_int = new System.Windows.Forms.Button();
            this.btn_double = new System.Windows.Forms.Button();
            this.btn_input = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.Main_label = new System.Windows.Forms.Label();
            this.lb_short = new System.Windows.Forms.Label();
            this.lb_int = new System.Windows.Forms.Label();
            this.lb_Exception = new System.Windows.Forms.Label();
            this.lb_double = new System.Windows.Forms.Label();
            this.lb_double_val = new System.Windows.Forms.Label();
            this.lb_Exception_val = new System.Windows.Forms.Label();
            this.lb_int_val = new System.Windows.Forms.Label();
            this.lb_short_val = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_short
            // 
            this.btn_short.Location = new System.Drawing.Point(528, 75);
            this.btn_short.Name = "btn_short";
            this.btn_short.Size = new System.Drawing.Size(92, 23);
            this.btn_short.TabIndex = 0;
            this.btn_short.Text = "short 변환";
            this.btn_short.UseVisualStyleBackColor = true;
            this.btn_short.Click += new System.EventHandler(this.btn_short_Click);
            // 
            // btn_int
            // 
            this.btn_int.Location = new System.Drawing.Point(528, 121);
            this.btn_int.Name = "btn_int";
            this.btn_int.Size = new System.Drawing.Size(92, 23);
            this.btn_int.TabIndex = 1;
            this.btn_int.Text = "int 변환";
            this.btn_int.UseVisualStyleBackColor = true;
            this.btn_int.Click += new System.EventHandler(this.btn_int_Click);
            // 
            // btn_double
            // 
            this.btn_double.Location = new System.Drawing.Point(528, 169);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(92, 23);
            this.btn_double.TabIndex = 2;
            this.btn_double.Text = "double 변환";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(528, 379);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(92, 23);
            this.btn_input.TabIndex = 3;
            this.btn_input.Text = "입력";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("굴림", 12F);
            this.txt_input.Location = new System.Drawing.Point(12, 377);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(510, 26);
            this.txt_input.TabIndex = 4;
            // 
            // Main_label
            // 
            this.Main_label.AutoSize = true;
            this.Main_label.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_label.Location = new System.Drawing.Point(141, 9);
            this.Main_label.Name = "Main_label";
            this.Main_label.Size = new System.Drawing.Size(284, 24);
            this.Main_label.TabIndex = 5;
            this.Main_label.Text = "WinForm_DataType Test";
            this.Main_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_short
            // 
            this.lb_short.AutoSize = true;
            this.lb_short.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_short.Location = new System.Drawing.Point(52, 86);
            this.lb_short.Name = "lb_short";
            this.lb_short.Size = new System.Drawing.Size(46, 16);
            this.lb_short.TabIndex = 6;
            this.lb_short.Text = "short";
            // 
            // lb_int
            // 
            this.lb_int.AutoSize = true;
            this.lb_int.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_int.Location = new System.Drawing.Point(52, 128);
            this.lb_int.Name = "lb_int";
            this.lb_int.Size = new System.Drawing.Size(25, 16);
            this.lb_int.TabIndex = 10;
            this.lb_int.Text = "int";
            // 
            // lb_Exception
            // 
            this.lb_Exception.AutoSize = true;
            this.lb_Exception.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_Exception.Location = new System.Drawing.Point(52, 213);
            this.lb_Exception.Name = "lb_Exception";
            this.lb_Exception.Size = new System.Drawing.Size(81, 16);
            this.lb_Exception.TabIndex = 11;
            this.lb_Exception.Text = "Exception";
            // 
            // lb_double
            // 
            this.lb_double.AutoSize = true;
            this.lb_double.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_double.Location = new System.Drawing.Point(52, 169);
            this.lb_double.Name = "lb_double";
            this.lb_double.Size = new System.Drawing.Size(57, 16);
            this.lb_double.TabIndex = 12;
            this.lb_double.Text = "double";
            // 
            // lb_double_val
            // 
            this.lb_double_val.AutoSize = true;
            this.lb_double_val.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_double_val.Location = new System.Drawing.Point(155, 169);
            this.lb_double_val.Name = "lb_double_val";
            this.lb_double_val.Size = new System.Drawing.Size(16, 16);
            this.lb_double_val.TabIndex = 16;
            this.lb_double_val.Text = "-";
            // 
            // lb_Exception_val
            // 
            this.lb_Exception_val.AutoSize = true;
            this.lb_Exception_val.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_Exception_val.Location = new System.Drawing.Point(155, 213);
            this.lb_Exception_val.Name = "lb_Exception_val";
            this.lb_Exception_val.Size = new System.Drawing.Size(16, 16);
            this.lb_Exception_val.TabIndex = 15;
            this.lb_Exception_val.Text = "-";
            // 
            // lb_int_val
            // 
            this.lb_int_val.AutoSize = true;
            this.lb_int_val.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_int_val.Location = new System.Drawing.Point(155, 128);
            this.lb_int_val.Name = "lb_int_val";
            this.lb_int_val.Size = new System.Drawing.Size(16, 16);
            this.lb_int_val.TabIndex = 14;
            this.lb_int_val.Text = "-";
            // 
            // lb_short_val
            // 
            this.lb_short_val.AutoSize = true;
            this.lb_short_val.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_short_val.Location = new System.Drawing.Point(155, 86);
            this.lb_short_val.Name = "lb_short_val";
            this.lb_short_val.Size = new System.Drawing.Size(16, 16);
            this.lb_short_val.TabIndex = 13;
            this.lb_short_val.Text = "-";
            this.lb_short_val.Click += new System.EventHandler(this.lb_short_val_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 409);
            this.Controls.Add(this.lb_double_val);
            this.Controls.Add(this.lb_Exception_val);
            this.Controls.Add(this.lb_int_val);
            this.Controls.Add(this.lb_short_val);
            this.Controls.Add(this.lb_double);
            this.Controls.Add(this.lb_Exception);
            this.Controls.Add(this.lb_int);
            this.Controls.Add(this.lb_short);
            this.Controls.Add(this.Main_label);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.btn_int);
            this.Controls.Add(this.btn_short);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_short;
        private System.Windows.Forms.Button btn_int;
        private System.Windows.Forms.Button btn_double;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label Main_label;
        private System.Windows.Forms.Label lb_short;
        private System.Windows.Forms.Label lb_int;
        private System.Windows.Forms.Label lb_Exception;
        private System.Windows.Forms.Label lb_double;
        private System.Windows.Forms.Label lb_double_val;
        private System.Windows.Forms.Label lb_Exception_val;
        private System.Windows.Forms.Label lb_int_val;
        private System.Windows.Forms.Label lb_short_val;
    }
}

