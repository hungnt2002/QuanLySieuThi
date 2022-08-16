namespace GUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblHoanTac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new CustomControls.RJControls.RJButton();
            this.TxtBoxMatKhau = new GUI.RJTextBox();
            this.txtBoxTaiKhoan = new GUI.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoanTac
            // 
            this.lblHoanTac.AutoSize = true;
            this.lblHoanTac.BackColor = System.Drawing.Color.Transparent;
            this.lblHoanTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoanTac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHoanTac.Location = new System.Drawing.Point(462, 451);
            this.lblHoanTac.Name = "lblHoanTac";
            this.lblHoanTac.Size = new System.Drawing.Size(115, 29);
            this.lblHoanTac.TabIndex = 18;
            this.lblHoanTac.Text = "Hoàn tác";
            this.lblHoanTac.Click += new System.EventHandler(this.lblHoanTac_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(288, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(288, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(438, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Siêu thị GS25";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(450, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 54);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TxtBoxMatKhau
            // 
            this.TxtBoxMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxMatKhau.BoderCoder = System.Drawing.Color.MediumSlateBlue;
            this.TxtBoxMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBoxMatKhau.BorDerSize = 6;
            this.TxtBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtBoxMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBoxMatKhau.Location = new System.Drawing.Point(444, 250);
            this.TxtBoxMatKhau.Multiline = false;
            this.TxtBoxMatKhau.Name = "TxtBoxMatKhau";
            this.TxtBoxMatKhau.Padding = new System.Windows.Forms.Padding(7);
            this.TxtBoxMatKhau.PasswordChar = true;
            this.TxtBoxMatKhau.ReadOnly = false;
            this.TxtBoxMatKhau.Size = new System.Drawing.Size(309, 35);
            this.TxtBoxMatKhau.TabIndex = 84;
            this.TxtBoxMatKhau.UnderlineStyle = true;
            // 
            // txtBoxTaiKhoan
            // 
            this.txtBoxTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTaiKhoan.BoderCoder = System.Drawing.Color.MediumSlateBlue;
            this.txtBoxTaiKhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxTaiKhoan.BorDerSize = 6;
            this.txtBoxTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxTaiKhoan.Location = new System.Drawing.Point(444, 186);
            this.txtBoxTaiKhoan.Multiline = false;
            this.txtBoxTaiKhoan.Name = "txtBoxTaiKhoan";
            this.txtBoxTaiKhoan.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxTaiKhoan.PasswordChar = false;
            this.txtBoxTaiKhoan.ReadOnly = false;
            this.txtBoxTaiKhoan.Size = new System.Drawing.Size(309, 35);
            this.txtBoxTaiKhoan.TabIndex = 83;
            this.txtBoxTaiKhoan.UnderlineStyle = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources._6324e885aaf96fa736e8;
            this.ClientSize = new System.Drawing.Size(925, 548);
            this.Controls.Add(this.TxtBoxMatKhau);
            this.Controls.Add(this.txtBoxTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblHoanTac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHoanTac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJTextBox txtBoxTaiKhoan;
        private RJTextBox TxtBoxMatKhau;
    }
}

