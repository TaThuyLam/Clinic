namespace UngDungQuanLyPhongKham
{
    partial class frmTiepDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiepDon));
            this.gvPhieuKham = new System.Windows.Forms.DataGridView();
            this.dtNgaySinh_PK = new System.Windows.Forms.DateTimePicker();
            this.txtSDT_PK = new System.Windows.Forms.TextBox();
            this.txtDiaChi_PK = new System.Windows.Forms.TextBox();
            this.txtHoTen_PK = new System.Windows.Forms.TextBox();
            this.txtMaBN_PK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch_PK = new System.Windows.Forms.Button();
            this.btnPrint_PK = new System.Windows.Forms.Button();
            this.btnDelete_PK = new System.Windows.Forms.Button();
            this.btnCancel_PK = new System.Windows.Forms.Button();
            this.btnAdd_PK = new System.Windows.Forms.Button();
            this.txtSearch_PK = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaPK_PK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtNgayKham_PK = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBacSi_PK = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbNhanVien_PK = new System.Windows.Forms.ComboBox();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDateTo = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh_PK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuKham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvPhieuKham
            // 
            this.gvPhieuKham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.gvPhieuKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhieuKham.Location = new System.Drawing.Point(12, 313);
            this.gvPhieuKham.Name = "gvPhieuKham";
            this.gvPhieuKham.RowHeadersWidth = 51;
            this.gvPhieuKham.RowTemplate.Height = 29;
            this.gvPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPhieuKham.Size = new System.Drawing.Size(1080, 227);
            this.gvPhieuKham.TabIndex = 31;
            this.gvPhieuKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPhieuKham_CellClick);
            // 
            // dtNgaySinh_PK
            // 
            this.dtNgaySinh_PK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh_PK.Location = new System.Drawing.Point(332, 158);
            this.dtNgaySinh_PK.Name = "dtNgaySinh_PK";
            this.dtNgaySinh_PK.Size = new System.Drawing.Size(183, 27);
            this.dtNgaySinh_PK.TabIndex = 30;
            // 
            // txtSDT_PK
            // 
            this.txtSDT_PK.Location = new System.Drawing.Point(129, 221);
            this.txtSDT_PK.Name = "txtSDT_PK";
            this.txtSDT_PK.Size = new System.Drawing.Size(386, 27);
            this.txtSDT_PK.TabIndex = 29;
            this.txtSDT_PK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_PK_KeyPress);
            // 
            // txtDiaChi_PK
            // 
            this.txtDiaChi_PK.Location = new System.Drawing.Point(129, 188);
            this.txtDiaChi_PK.Name = "txtDiaChi_PK";
            this.txtDiaChi_PK.Size = new System.Drawing.Size(386, 27);
            this.txtDiaChi_PK.TabIndex = 27;
            // 
            // txtHoTen_PK
            // 
            this.txtHoTen_PK.Location = new System.Drawing.Point(129, 127);
            this.txtHoTen_PK.Name = "txtHoTen_PK";
            this.txtHoTen_PK.Size = new System.Drawing.Size(386, 27);
            this.txtHoTen_PK.TabIndex = 26;
            // 
            // txtMaBN_PK
            // 
            this.txtMaBN_PK.Location = new System.Drawing.Point(129, 96);
            this.txtMaBN_PK.Name = "txtMaBN_PK";
            this.txtMaBN_PK.ReadOnly = true;
            this.txtMaBN_PK.Size = new System.Drawing.Size(114, 27);
            this.txtMaBN_PK.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Họ và tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã bệnh nhân:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 38);
            this.panel2.TabIndex = 23;
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
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 38);
            this.panel1.TabIndex = 24;
            this.panel1.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin bệnh nhân";
            // 
            // btnSearch_PK
            // 
            this.btnSearch_PK.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_PK.Image")));
            this.btnSearch_PK.Location = new System.Drawing.Point(1052, 16);
            this.btnSearch_PK.Name = "btnSearch_PK";
            this.btnSearch_PK.Size = new System.Drawing.Size(40, 35);
            this.btnSearch_PK.TabIndex = 22;
            this.btnSearch_PK.UseVisualStyleBackColor = true;
            this.btnSearch_PK.Click += new System.EventHandler(this.btnSearch_PK_Click);
            // 
            // btnPrint_PK
            // 
            this.btnPrint_PK.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint_PK.Image")));
            this.btnPrint_PK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint_PK.Location = new System.Drawing.Point(285, 12);
            this.btnPrint_PK.Name = "btnPrint_PK";
            this.btnPrint_PK.Size = new System.Drawing.Size(76, 35);
            this.btnPrint_PK.TabIndex = 21;
            this.btnPrint_PK.Text = "Lưu";
            this.btnPrint_PK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint_PK.UseVisualStyleBackColor = true;
            this.btnPrint_PK.Click += new System.EventHandler(this.btnPrint_PK_Click);
            // 
            // btnDelete_PK
            // 
            this.btnDelete_PK.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_PK.Image")));
            this.btnDelete_PK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete_PK.Location = new System.Drawing.Point(202, 12);
            this.btnDelete_PK.Name = "btnDelete_PK";
            this.btnDelete_PK.Size = new System.Drawing.Size(77, 35);
            this.btnDelete_PK.TabIndex = 20;
            this.btnDelete_PK.Text = "Xóa";
            this.btnDelete_PK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete_PK.UseVisualStyleBackColor = true;
            this.btnDelete_PK.Click += new System.EventHandler(this.btnDelete_PK_Click);
            // 
            // btnCancel_PK
            // 
            this.btnCancel_PK.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel_PK.Image")));
            this.btnCancel_PK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel_PK.Location = new System.Drawing.Point(129, 12);
            this.btnCancel_PK.Name = "btnCancel_PK";
            this.btnCancel_PK.Size = new System.Drawing.Size(67, 35);
            this.btnCancel_PK.TabIndex = 12;
            this.btnCancel_PK.Text = "Hủy";
            this.btnCancel_PK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel_PK.UseVisualStyleBackColor = true;
            // 
            // btnAdd_PK
            // 
            this.btnAdd_PK.Image = global::UngDungQuanLyPhongKham.Properties.Resources.Add;
            this.btnAdd_PK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_PK.Location = new System.Drawing.Point(12, 12);
            this.btnAdd_PK.Name = "btnAdd_PK";
            this.btnAdd_PK.Size = new System.Drawing.Size(111, 35);
            this.btnAdd_PK.TabIndex = 15;
            this.btnAdd_PK.Text = "Thêm mới";
            this.btnAdd_PK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd_PK.UseVisualStyleBackColor = true;
            this.btnAdd_PK.Click += new System.EventHandler(this.btnAdd_PK_Click);
            // 
            // txtSearch_PK
            // 
            this.txtSearch_PK.Location = new System.Drawing.Point(845, 20);
            this.txtSearch_PK.Name = "txtSearch_PK";
            this.txtSearch_PK.PlaceholderText = "Tên bệnh nhân...";
            this.txtSearch_PK.Size = new System.Drawing.Size(201, 27);
            this.txtSearch_PK.TabIndex = 11;
            this.txtSearch_PK.TextChanged += new System.EventHandler(this.txtSearch_PK_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(589, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 38);
            this.panel3.TabIndex = 25;
            this.panel3.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thông tin phiếu khám";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mã phiếu khám:";
            // 
            // txtMaPK_PK
            // 
            this.txtMaPK_PK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPK_PK.Location = new System.Drawing.Point(709, 96);
            this.txtMaPK_PK.Name = "txtMaPK_PK";
            this.txtMaPK_PK.ReadOnly = true;
            this.txtMaPK_PK.Size = new System.Drawing.Size(183, 27);
            this.txtMaPK_PK.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Từ ngày:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(589, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ngày khám:";
            // 
            // dtNgayKham_PK
            // 
            this.dtNgayKham_PK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgayKham_PK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKham_PK.Location = new System.Drawing.Point(709, 127);
            this.dtNgayKham_PK.Name = "dtNgayKham_PK";
            this.dtNgayKham_PK.Size = new System.Drawing.Size(183, 27);
            this.dtNgayKham_PK.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(589, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Bác sĩ:";
            // 
            // cbBacSi_PK
            // 
            this.cbBacSi_PK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBacSi_PK.FormattingEnabled = true;
            this.cbBacSi_PK.Location = new System.Drawing.Point(709, 158);
            this.cbBacSi_PK.Name = "cbBacSi_PK";
            this.cbBacSi_PK.Size = new System.Drawing.Size(383, 28);
            this.cbBacSi_PK.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(589, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Nhân viên:";
            // 
            // cbNhanVien_PK
            // 
            this.cbNhanVien_PK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNhanVien_PK.FormattingEnabled = true;
            this.cbNhanVien_PK.Location = new System.Drawing.Point(709, 192);
            this.cbNhanVien_PK.Name = "cbNhanVien_PK";
            this.cbNhanVien_PK.Size = new System.Drawing.Size(383, 28);
            this.cbNhanVien_PK.TabIndex = 32;
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Location = new System.Drawing.Point(493, 20);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(123, 27);
            this.dtDateFrom.TabIndex = 30;
            this.dtDateFrom.ValueChanged += new System.EventHandler(this.dtDateFrom_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(622, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Đến ngày:";
            // 
            // dtDateTo
            // 
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Location = new System.Drawing.Point(703, 20);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(123, 27);
            this.dtDateTo.TabIndex = 30;
            this.dtDateTo.ValueChanged += new System.EventHandler(this.dtDateTo_ValueChanged);
            // 
            // cbGioiTinh_PK
            // 
            this.cbGioiTinh_PK.FormattingEnabled = true;
            this.cbGioiTinh_PK.Location = new System.Drawing.Point(129, 158);
            this.cbGioiTinh_PK.Name = "cbGioiTinh_PK";
            this.cbGioiTinh_PK.Size = new System.Drawing.Size(114, 28);
            this.cbGioiTinh_PK.TabIndex = 33;
            // 
            // frmTiepDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 552);
            this.Controls.Add(this.cbGioiTinh_PK);
            this.Controls.Add(this.cbNhanVien_PK);
            this.Controls.Add(this.cbBacSi_PK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gvPhieuKham);
            this.Controls.Add(this.dtNgayKham_PK);
            this.Controls.Add(this.dtDateTo);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.dtNgaySinh_PK);
            this.Controls.Add(this.txtSDT_PK);
            this.Controls.Add(this.txtDiaChi_PK);
            this.Controls.Add(this.txtHoTen_PK);
            this.Controls.Add(this.txtMaPK_PK);
            this.Controls.Add(this.txtMaBN_PK);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch_PK);
            this.Controls.Add(this.btnPrint_PK);
            this.Controls.Add(this.btnDelete_PK);
            this.Controls.Add(this.btnCancel_PK);
            this.Controls.Add(this.btnAdd_PK);
            this.Controls.Add(this.txtSearch_PK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTiepDon";
            this.Text = "Tiếp nhận bệnh nhân";
            this.Load += new System.EventHandler(this.frmTiepDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuKham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dtNgaySinh_PK;
        private TextBox txtSDT_PK;
        private TextBox txtDiaChi_PK;
        private TextBox txtHoTen_PK;
        private TextBox txtMaBN_PK;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private Panel panel1;
        private Label label1;
        private Button btnSearch_PK;
        private Button btnPrint_PK;
        private Button btnDelete_PK;
        private Button btnCancel_PK;
        private Button btnAdd_PK;
        private TextBox txtSearch_PK;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private TextBox txtMaPK_PK;
        private Label label11;
        private Label label12;
        private DateTimePicker dtNgayKham_PK;
        private Label label13;
        private ComboBox cbBacSi_PK;
        private Label label14;
        private ComboBox cbNhanVien_PK;
        private DataGridView gvPhieuKham;
        private DateTimePicker dtDateFrom;
        private Label label15;
        private DateTimePicker dtDateTo;
        private ComboBox cbGioiTinh;
        private ComboBox cbGioiTinh_PK;
    }
}