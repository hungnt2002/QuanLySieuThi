namespace GUI
{
    partial class FormQLSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSanPham));
            this.cbPhanLoai = new System.Windows.Forms.ComboBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new CustomControls.RJControls.RJButton();
            this.btnThem = new CustomControls.RJControls.RJButton();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.btnImport = new CustomControls.RJControls.RJButton();
            this.btnExport = new CustomControls.RJControls.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxTimKiem = new GUI.RJTextBox();
            this.txtBoxNhaSanXuat = new GUI.RJTextBox();
            this.txtBoxGia = new GUI.RJTextBox();
            this.txtBoxSoLuong = new GUI.RJTextBox();
            this.txtBoxTenSP = new GUI.RJTextBox();
            this.txtBoxID = new GUI.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPhanLoai
            // 
            this.cbPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbPhanLoai.FormattingEnabled = true;
            this.cbPhanLoai.Items.AddRange(new object[] {
            "Thực phẩm khô",
            "Thức uống",
            "Bánh kẹo"});
            this.cbPhanLoai.Location = new System.Drawing.Point(312, 406);
            this.cbPhanLoai.Name = "cbPhanLoai";
            this.cbPhanLoai.Size = new System.Drawing.Size(251, 30);
            this.cbPhanLoai.TabIndex = 87;
            this.cbPhanLoai.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Items.AddRange(new object[] {
            "Tất cả",
            "Thức uống",
            "Thực phẩm khô",
            "Bánh kẹo"});
            this.cbDanhMuc.Location = new System.Drawing.Point(1073, 142);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(183, 30);
            this.cbDanhMuc.TabIndex = 86;
            this.cbDanhMuc.Text = "Tất cả";
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(149, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 22);
            this.label9.TabIndex = 85;
            this.label9.Text = "Nhà sản xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(149, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 84;
            this.label8.Text = "Phân loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(149, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 22);
            this.label7.TabIndex = 83;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(149, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 82;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(149, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tên Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(149, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 80;
            this.label4.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1069, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Danh mục sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(741, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tìm kiếm sản phẩm";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 15;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1297, 120);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 54);
            this.btnReset.TabIndex = 95;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 15;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::GUI.Properties.Resources._1__6_;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(99, 544);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 54);
            this.btnThem.TabIndex = 96;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::GUI.Properties.Resources._1__13_;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(252, 544);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 54);
            this.btnEdit.TabIndex = 97;
            this.btnEdit.Text = "  Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(554, 544);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 54);
            this.btnClear.TabIndex = 98;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GUI.Properties.Resources._14_Delete_32x32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(401, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 54);
            this.btnDelete.TabIndex = 99;
            this.btnDelete.Text = "  Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnImport.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnImport.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImport.BorderRadius = 15;
            this.btnImport.BorderSize = 0;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(869, 607);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(199, 54);
            this.btnImport.TabIndex = 100;
            this.btnImport.Text = "Import sản phẩm";
            this.btnImport.TextColor = System.Drawing.Color.White;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExport.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExport.BackgroundImage = global::GUI.Properties.Resources._86f027443838fd66a429;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExport.BorderRadius = 15;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1170, 607);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(199, 54);
            this.btnExport.TabIndex = 101;
            this.btnExport.Text = "Export sản phẩm";
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(719, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(831, 328);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTimKiem.BoderCoder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxTimKiem.BorDerSize = 6;
            this.txtBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxTimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxTimKiem.Location = new System.Drawing.Point(719, 139);
            this.txtBoxTimKiem.Multiline = false;
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxTimKiem.PasswordChar = false;
            this.txtBoxTimKiem.ReadOnly = false;
            this.txtBoxTimKiem.Size = new System.Drawing.Size(251, 35);
            this.txtBoxTimKiem.TabIndex = 115;
            this.txtBoxTimKiem.UnderlineStyle = true;
            this.txtBoxTimKiem._TextChanged += new System.EventHandler(this.txtBoxTimKiem_TextChanged);
            // 
            // txtBoxNhaSanXuat
            // 
            this.txtBoxNhaSanXuat.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNhaSanXuat.BoderCoder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxNhaSanXuat.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxNhaSanXuat.BorDerSize = 6;
            this.txtBoxNhaSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxNhaSanXuat.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxNhaSanXuat.Location = new System.Drawing.Point(312, 472);
            this.txtBoxNhaSanXuat.Multiline = false;
            this.txtBoxNhaSanXuat.Name = "txtBoxNhaSanXuat";
            this.txtBoxNhaSanXuat.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxNhaSanXuat.PasswordChar = false;
            this.txtBoxNhaSanXuat.ReadOnly = false;
            this.txtBoxNhaSanXuat.Size = new System.Drawing.Size(251, 35);
            this.txtBoxNhaSanXuat.TabIndex = 114;
            this.txtBoxNhaSanXuat.UnderlineStyle = true;
            // 
            // txtBoxGia
            // 
            this.txtBoxGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxGia.BoderCoder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxGia.BorDerSize = 6;
            this.txtBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxGia.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxGia.Location = new System.Drawing.Point(312, 339);
            this.txtBoxGia.Multiline = false;
            this.txtBoxGia.Name = "txtBoxGia";
            this.txtBoxGia.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxGia.PasswordChar = false;
            this.txtBoxGia.ReadOnly = false;
            this.txtBoxGia.Size = new System.Drawing.Size(251, 35);
            this.txtBoxGia.TabIndex = 113;
            this.txtBoxGia.UnderlineStyle = true;
            // 
            // txtBoxSoLuong
            // 
            this.txtBoxSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSoLuong.BoderCoder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxSoLuong.BorDerSize = 6;
            this.txtBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxSoLuong.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSoLuong.Location = new System.Drawing.Point(312, 279);
            this.txtBoxSoLuong.Multiline = false;
            this.txtBoxSoLuong.Name = "txtBoxSoLuong";
            this.txtBoxSoLuong.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxSoLuong.PasswordChar = false;
            this.txtBoxSoLuong.ReadOnly = false;
            this.txtBoxSoLuong.Size = new System.Drawing.Size(251, 35);
            this.txtBoxSoLuong.TabIndex = 112;
            this.txtBoxSoLuong.UnderlineStyle = true;
            // 
            // txtBoxTenSP
            // 
            this.txtBoxTenSP.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTenSP.BoderCoder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxTenSP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxTenSP.BorDerSize = 6;
            this.txtBoxTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxTenSP.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxTenSP.Location = new System.Drawing.Point(312, 215);
            this.txtBoxTenSP.Multiline = false;
            this.txtBoxTenSP.Name = "txtBoxTenSP";
            this.txtBoxTenSP.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxTenSP.PasswordChar = false;
            this.txtBoxTenSP.ReadOnly = false;
            this.txtBoxTenSP.Size = new System.Drawing.Size(251, 35);
            this.txtBoxTenSP.TabIndex = 111;
            this.txtBoxTenSP.UnderlineStyle = true;
            // 
            // txtBoxID
            // 
            this.txtBoxID.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxID.BoderCoder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxID.BorDerSize = 6;
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxID.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxID.Location = new System.Drawing.Point(312, 152);
            this.txtBoxID.Multiline = false;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxID.PasswordChar = false;
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(251, 35);
            this.txtBoxID.TabIndex = 110;
            this.txtBoxID.UnderlineStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // FormQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1572, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxTimKiem);
            this.Controls.Add(this.txtBoxNhaSanXuat);
            this.Controls.Add(this.txtBoxGia);
            this.Controls.Add(this.txtBoxSoLuong);
            this.Controls.Add(this.txtBoxTenSP);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbPhanLoai);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLSanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbPhanLoai;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btnReset;
        private CustomControls.RJControls.RJButton btnThem;
        private CustomControls.RJControls.RJButton btnEdit;
        private CustomControls.RJControls.RJButton btnClear;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnImport;
        private CustomControls.RJControls.RJButton btnExport;
        private RJTextBox txtBoxID;
        private RJTextBox txtBoxTenSP;
        private RJTextBox txtBoxSoLuong;
        private RJTextBox txtBoxGia;
        private RJTextBox txtBoxNhaSanXuat;
        private RJTextBox txtBoxTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}