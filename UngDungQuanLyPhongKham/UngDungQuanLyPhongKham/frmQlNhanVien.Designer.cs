namespace UngDungQuanLyPhongKham
{
    partial class frmQlNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQlNhanVien));
            this.cbChucVu_A = new System.Windows.Forms.ComboBox();
            this.gv_NhanVienA = new System.Windows.Forms.DataGridView();
            this.txtTenNV_A = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV_A = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintNV_A = new System.Windows.Forms.Button();
            this.btnCancelNV_A = new System.Windows.Forms.Button();
            this.btnAddNhanVien_A = new System.Windows.Forms.Button();
            this.btnSearch_HSBN = new System.Windows.Forms.Button();
            this.btnDeleteNV_A = new System.Windows.Forms.Button();
            this.txtSearchNV_A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoanTenNV_A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChuyenMon_A = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTrinhDo_A = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pt_ImageNv = new System.Windows.Forms.PictureBox();
            this.btn_ThemAvt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVienA)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ImageNv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChucVu_A
            // 
            this.cbChucVu_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChucVu_A.FormattingEnabled = true;
            this.cbChucVu_A.Location = new System.Drawing.Point(466, 57);
            this.cbChucVu_A.Name = "cbChucVu_A";
            this.cbChucVu_A.Size = new System.Drawing.Size(258, 28);
            this.cbChucVu_A.TabIndex = 91;
            // 
            // gv_NhanVienA
            // 
            this.gv_NhanVienA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_NhanVienA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_NhanVienA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_NhanVienA.Location = new System.Drawing.Point(12, 329);
            this.gv_NhanVienA.Name = "gv_NhanVienA";
            this.gv_NhanVienA.RowHeadersWidth = 51;
            this.gv_NhanVienA.RowTemplate.Height = 29;
            this.gv_NhanVienA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_NhanVienA.Size = new System.Drawing.Size(1080, 316);
            this.gv_NhanVienA.TabIndex = 90;
            this.gv_NhanVienA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_NhanVienA_CellClick);
            // 
            // txtTenNV_A
            // 
            this.txtTenNV_A.Location = new System.Drawing.Point(122, 59);
            this.txtTenNV_A.Name = "txtTenNV_A";
            this.txtTenNV_A.Size = new System.Drawing.Size(232, 27);
            this.txtTenNV_A.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 80;
            this.label9.Text = "Chức vụ:";
            // 
            // txtMaNV_A
            // 
            this.txtMaNV_A.Location = new System.Drawing.Point(122, 26);
            this.txtMaNV_A.Name = "txtMaNV_A";
            this.txtMaNV_A.ReadOnly = true;
            this.txtMaNV_A.Size = new System.Drawing.Size(103, 27);
            this.txtMaNV_A.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mã nhân viên:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 38);
            this.panel2.TabIndex = 85;
            this.panel2.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh sách dữ liệu";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 38);
            this.panel1.TabIndex = 86;
            this.panel1.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chung";
            // 
            // btnPrintNV_A
            // 
            this.btnPrintNV_A.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintNV_A.Image")));
            this.btnPrintNV_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintNV_A.Location = new System.Drawing.Point(285, 12);
            this.btnPrintNV_A.Name = "btnPrintNV_A";
            this.btnPrintNV_A.Size = new System.Drawing.Size(76, 35);
            this.btnPrintNV_A.TabIndex = 83;
            this.btnPrintNV_A.Text = "Lưu";
            this.btnPrintNV_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintNV_A.UseVisualStyleBackColor = true;
            this.btnPrintNV_A.Click += new System.EventHandler(this.btnPrintNV_A_Click);
            // 
            // btnCancelNV_A
            // 
            this.btnCancelNV_A.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelNV_A.Image")));
            this.btnCancelNV_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelNV_A.Location = new System.Drawing.Point(129, 12);
            this.btnCancelNV_A.Name = "btnCancelNV_A";
            this.btnCancelNV_A.Size = new System.Drawing.Size(67, 35);
            this.btnCancelNV_A.TabIndex = 76;
            this.btnCancelNV_A.Text = "Hủy";
            this.btnCancelNV_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelNV_A.UseVisualStyleBackColor = true;
            this.btnCancelNV_A.Click += new System.EventHandler(this.btnCancelNV_A_Click);
            // 
            // btnAddNhanVien_A
            // 
            this.btnAddNhanVien_A.Image = global::UngDungQuanLyPhongKham.Properties.Resources.Add;
            this.btnAddNhanVien_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNhanVien_A.Location = new System.Drawing.Point(12, 12);
            this.btnAddNhanVien_A.Name = "btnAddNhanVien_A";
            this.btnAddNhanVien_A.Size = new System.Drawing.Size(111, 35);
            this.btnAddNhanVien_A.TabIndex = 78;
            this.btnAddNhanVien_A.Text = "Thêm mới";
            this.btnAddNhanVien_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNhanVien_A.UseVisualStyleBackColor = true;
            this.btnAddNhanVien_A.Click += new System.EventHandler(this.btnAddNhanVien_A_Click);
            // 
            // btnSearch_HSBN
            // 
            this.btnSearch_HSBN.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_HSBN.Image")));
            this.btnSearch_HSBN.Location = new System.Drawing.Point(1052, 16);
            this.btnSearch_HSBN.Name = "btnSearch_HSBN";
            this.btnSearch_HSBN.Size = new System.Drawing.Size(40, 35);
            this.btnSearch_HSBN.TabIndex = 84;
            this.btnSearch_HSBN.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNV_A
            // 
            this.btnDeleteNV_A.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteNV_A.Image")));
            this.btnDeleteNV_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV_A.Location = new System.Drawing.Point(202, 12);
            this.btnDeleteNV_A.Name = "btnDeleteNV_A";
            this.btnDeleteNV_A.Size = new System.Drawing.Size(77, 35);
            this.btnDeleteNV_A.TabIndex = 82;
            this.btnDeleteNV_A.Text = "Xóa";
            this.btnDeleteNV_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNV_A.UseVisualStyleBackColor = true;
            this.btnDeleteNV_A.Click += new System.EventHandler(this.btnDeleteNV_A_Click);
            // 
            // txtSearchNV_A
            // 
            this.txtSearchNV_A.Location = new System.Drawing.Point(713, 20);
            this.txtSearchNV_A.Name = "txtSearchNV_A";
            this.txtSearchNV_A.PlaceholderText = "Tìm nhân viên...";
            this.txtSearchNV_A.Size = new System.Drawing.Size(333, 27);
            this.txtSearchNV_A.TabIndex = 75;
            this.txtSearchNV_A.TextChanged += new System.EventHandler(this.txtSearchNV_A_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tài khoản:";
            // 
            // txtTaiKhoanTenNV_A
            // 
            this.txtTaiKhoanTenNV_A.Location = new System.Drawing.Point(122, 92);
            this.txtTaiKhoanTenNV_A.Name = "txtTaiKhoanTenNV_A";
            this.txtTaiKhoanTenNV_A.Size = new System.Drawing.Size(232, 27);
            this.txtTaiKhoanTenNV_A.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Chuyên môn:";
            // 
            // cbChuyenMon_A
            // 
            this.cbChuyenMon_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChuyenMon_A.FormattingEnabled = true;
            this.cbChuyenMon_A.Location = new System.Drawing.Point(466, 91);
            this.cbChuyenMon_A.Name = "cbChuyenMon_A";
            this.cbChuyenMon_A.Size = new System.Drawing.Size(258, 28);
            this.cbChuyenMon_A.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Trình độ:";
            // 
            // cbTrinhDo_A
            // 
            this.cbTrinhDo_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTrinhDo_A.FormattingEnabled = true;
            this.cbTrinhDo_A.Location = new System.Drawing.Point(466, 125);
            this.cbTrinhDo_A.Name = "cbTrinhDo_A";
            this.cbTrinhDo_A.Size = new System.Drawing.Size(258, 28);
            this.cbTrinhDo_A.TabIndex = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbChucVu_A);
            this.groupBox1.Controls.Add(this.cbChuyenMon_A);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbTrinhDo_A);
            this.groupBox1.Controls.Add(this.txtMaNV_A);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV_A);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTaiKhoanTenNV_A);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(325, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 182);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(122, 126);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(232, 27);
            this.dtNgaySinh.TabIndex = 90;
            this.dtNgaySinh.Value = new System.DateTime(2022, 12, 21, 16, 6, 14, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Ngày sinh:";
            // 
            // pt_ImageNv
            // 
            this.pt_ImageNv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pt_ImageNv.BackgroundImage")));
            this.pt_ImageNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pt_ImageNv.Location = new System.Drawing.Point(109, 97);
            this.pt_ImageNv.Name = "pt_ImageNv";
            this.pt_ImageNv.Size = new System.Drawing.Size(159, 151);
            this.pt_ImageNv.TabIndex = 93;
            this.pt_ImageNv.TabStop = false;
            // 
            // btn_ThemAvt
            // 
            this.btn_ThemAvt.Location = new System.Drawing.Point(144, 254);
            this.btn_ThemAvt.Name = "btn_ThemAvt";
            this.btn_ThemAvt.Size = new System.Drawing.Size(94, 29);
            this.btn_ThemAvt.TabIndex = 94;
            this.btn_ThemAvt.Text = "Chọn";
            this.btn_ThemAvt.UseVisualStyleBackColor = true;
            // 
            // frmQlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 657);
            this.Controls.Add(this.btn_ThemAvt);
            this.Controls.Add(this.pt_ImageNv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gv_NhanVienA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrintNV_A);
            this.Controls.Add(this.btnCancelNV_A);
            this.Controls.Add(this.btnAddNhanVien_A);
            this.Controls.Add(this.btnSearch_HSBN);
            this.Controls.Add(this.btnDeleteNV_A);
            this.Controls.Add(this.txtSearchNV_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQlNhanVien";
            this.Text = "frmQlNhanVien";
            this.Load += new System.EventHandler(this.frmQlNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVienA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ImageNv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbChucVu_A;
        private DataGridView gv_NhanVienA;
        private TextBox txtTenNV_A;
        private Label label9;
        private TextBox txtMaNV_A;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private Panel panel1;
        private Label label1;
        private Button btnPrintNV_A;
        private Button btnCancelNV_A;
        private Button btnAddNhanVien_A;
        private Button btnSearch_HSBN;
        private Button btnDeleteNV_A;
        private TextBox txtSearchNV_A;
        private Label label4;
        private TextBox txtTaiKhoanTenNV_A;
        private Label label5;
        private ComboBox cbChuyenMon_A;
        private Label label6;
        private ComboBox cbTrinhDo_A;
        private GroupBox groupBox1;
        private PictureBox pt_ImageNv;
        private Button btn_ThemAvt;
        private DateTimePicker dtNgaySinh;
        private Label label7;
    }
}