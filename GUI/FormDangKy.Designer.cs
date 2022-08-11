namespace GUI
{
    partial class FormDangKy
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
            this.textBoxNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxMatKhau = new System.Windows.Forms.TextBox();
            this.txtBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNhapLaiMatKhau
            // 
            this.textBoxNhapLaiMatKhau.Location = new System.Drawing.Point(329, 218);
            this.textBoxNhapLaiMatKhau.Multiline = true;
            this.textBoxNhapLaiMatKhau.Name = "textBoxNhapLaiMatKhau";
            this.textBoxNhapLaiMatKhau.PasswordChar = '*';
            this.textBoxNhapLaiMatKhau.Size = new System.Drawing.Size(355, 32);
            this.textBoxNhapLaiMatKhau.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(102, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(403, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hoàn tác";
            // 
            // TextBoxMatKhau
            // 
            this.TextBoxMatKhau.Location = new System.Drawing.Point(329, 156);
            this.TextBoxMatKhau.Multiline = true;
            this.TextBoxMatKhau.Name = "TextBoxMatKhau";
            this.TextBoxMatKhau.PasswordChar = '*';
            this.TextBoxMatKhau.Size = new System.Drawing.Size(355, 32);
            this.TextBoxMatKhau.TabIndex = 34;
            // 
            // txtBoxTaiKhoan
            // 
            this.txtBoxTaiKhoan.Location = new System.Drawing.Point(329, 95);
            this.txtBoxTaiKhoan.Multiline = true;
            this.txtBoxTaiKhoan.Name = "txtBoxTaiKhoan";
            this.txtBoxTaiKhoan.Size = new System.Drawing.Size(355, 33);
            this.txtBoxTaiKhoan.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(125, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(125, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(417, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Đăng ký";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(381, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 53);
            this.button2.TabIndex = 29;
            this.button2.Text = "Đăng ký";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNhapLaiMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxMatKhau);
            this.Controls.Add(this.txtBoxTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "FormDangKy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNhapLaiMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxMatKhau;
        private System.Windows.Forms.TextBox txtBoxTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}