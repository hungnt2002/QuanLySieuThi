namespace GUI
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new CustomControls.RJControls.RJButton();
            this.btnFormNV = new CustomControls.RJControls.RJButton();
            this.btnFormSP = new CustomControls.RJControls.RJButton();
            this.panel_Top.SuspendLayout();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.White;
            this.panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Body.BackgroundImage")));
            this.panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(236, 107);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1380, 846);
            this.panel_Body.TabIndex = 5;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.panel_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Top.BackgroundImage")));
            this.panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(236, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1380, 107);
            this.panel_Top.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(730, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Snow;
            this.panel_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Left.BackgroundImage")));
            this.panel_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Left.Controls.Add(this.pictureBox1);
            this.panel_Left.Controls.Add(this.btnDangXuat);
            this.panel_Left.Controls.Add(this.btnFormNV);
            this.panel_Left.Controls.Add(this.btnFormSP);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(236, 953);
            this.panel_Left.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 104);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangXuat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangXuat.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangXuat.BorderRadius = 0;
            this.btnDangXuat.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 690);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(236, 65);
            this.btnDangXuat.TabIndex = 99;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextColor = System.Drawing.Color.White;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnFormNV
            // 
            this.btnFormNV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFormNV.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFormNV.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnFormNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFormNV.BorderRadius = 0;
            this.btnFormNV.BorderSize = 0;
            this.btnFormNV.FlatAppearance.BorderSize = 0;
            this.btnFormNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormNV.ForeColor = System.Drawing.Color.White;
            this.btnFormNV.Location = new System.Drawing.Point(3, 173);
            this.btnFormNV.Name = "btnFormNV";
            this.btnFormNV.Size = new System.Drawing.Size(236, 65);
            this.btnFormNV.TabIndex = 98;
            this.btnFormNV.Text = "Quản lý nhân viên";
            this.btnFormNV.TextColor = System.Drawing.Color.White;
            this.btnFormNV.UseVisualStyleBackColor = false;
            this.btnFormNV.Click += new System.EventHandler(this.btnFormNV_Click);
            // 
            // btnFormSP
            // 
            this.btnFormSP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFormSP.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFormSP.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnFormSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFormSP.BorderRadius = 0;
            this.btnFormSP.BorderSize = 0;
            this.btnFormSP.FlatAppearance.BorderSize = 0;
            this.btnFormSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFormSP.ForeColor = System.Drawing.Color.White;
            this.btnFormSP.Location = new System.Drawing.Point(3, 107);
            this.btnFormSP.Name = "btnFormSP";
            this.btnFormSP.Size = new System.Drawing.Size(236, 65);
            this.btnFormSP.TabIndex = 97;
            this.btnFormSP.Text = "Quản lý sản phẩm";
            this.btnFormSP.TextColor = System.Drawing.Color.White;
            this.btnFormSP.UseVisualStyleBackColor = false;
            this.btnFormSP.Click += new System.EventHandler(this.btnFormSP_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 953);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Left;
        private CustomControls.RJControls.RJButton btnFormSP;
        private CustomControls.RJControls.RJButton btnDangXuat;
        private CustomControls.RJControls.RJButton btnFormNV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}