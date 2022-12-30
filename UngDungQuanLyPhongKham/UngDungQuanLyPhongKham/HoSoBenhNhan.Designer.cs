namespace UngDungQuanLyPhongKham
{
    partial class HoSoBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoSoBenhNhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch_HSBN = new System.Windows.Forms.TextBox();
            this.btnAdd_BenhNhan = new System.Windows.Forms.Button();
            this.btnCancel_HSBN = new System.Windows.Forms.Button();
            this.btnDelete_HSBN = new System.Windows.Forms.Button();
            this.btnPrint_HSBN = new System.Windows.Forms.Button();
            this.btnSearch_HSBN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaBN_HSBN = new System.Windows.Forms.TextBox();
            this.txtHoTen_HSBN = new System.Windows.Forms.TextBox();
            this.dtNgaySinh_HSBN = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi_HSBN = new System.Windows.Forms.TextBox();
            this.txtSDT_HSBN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbGioiTinh_BN = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch_HSBN
            // 
            this.txtSearch_HSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch_HSBN.Location = new System.Drawing.Point(713, 20);
            this.txtSearch_HSBN.Name = "txtSearch_HSBN";
            this.txtSearch_HSBN.Size = new System.Drawing.Size(333, 27);
            this.txtSearch_HSBN.TabIndex = 0;
            this.txtSearch_HSBN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd_BenhNhan
            // 
            this.btnAdd_BenhNhan.Image = global::UngDungQuanLyPhongKham.Properties.Resources.Add;
            this.btnAdd_BenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_BenhNhan.Location = new System.Drawing.Point(12, 12);
            this.btnAdd_BenhNhan.Name = "btnAdd_BenhNhan";
            this.btnAdd_BenhNhan.Size = new System.Drawing.Size(111, 35);
            this.btnAdd_BenhNhan.TabIndex = 1;
            this.btnAdd_BenhNhan.Text = "Thêm mới";
            this.btnAdd_BenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd_BenhNhan.UseVisualStyleBackColor = true;
            this.btnAdd_BenhNhan.Click += new System.EventHandler(this.btnAdd_BenhNhan_Click);
            // 
            // btnCancel_HSBN
            // 
            this.btnCancel_HSBN.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel_HSBN.Image")));
            this.btnCancel_HSBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel_HSBN.Location = new System.Drawing.Point(129, 12);
            this.btnCancel_HSBN.Name = "btnCancel_HSBN";
            this.btnCancel_HSBN.Size = new System.Drawing.Size(67, 35);
            this.btnCancel_HSBN.TabIndex = 1;
            this.btnCancel_HSBN.Text = "Hủy";
            this.btnCancel_HSBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel_HSBN.UseVisualStyleBackColor = true;
            this.btnCancel_HSBN.Click += new System.EventHandler(this.btnCancel_BenhNhan_Click);
            // 
            // btnDelete_HSBN
            // 
            this.btnDelete_HSBN.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_HSBN.Image")));
            this.btnDelete_HSBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete_HSBN.Location = new System.Drawing.Point(202, 12);
            this.btnDelete_HSBN.Name = "btnDelete_HSBN";
            this.btnDelete_HSBN.Size = new System.Drawing.Size(77, 35);
            this.btnDelete_HSBN.TabIndex = 2;
            this.btnDelete_HSBN.Text = "Xóa";
            this.btnDelete_HSBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete_HSBN.UseVisualStyleBackColor = true;
            this.btnDelete_HSBN.Click += new System.EventHandler(this.btnDelete_HSBN_Click);
            // 
            // btnPrint_HSBN
            // 
            this.btnPrint_HSBN.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint_HSBN.Image")));
            this.btnPrint_HSBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint_HSBN.Location = new System.Drawing.Point(285, 12);
            this.btnPrint_HSBN.Name = "btnPrint_HSBN";
            this.btnPrint_HSBN.Size = new System.Drawing.Size(76, 35);
            this.btnPrint_HSBN.TabIndex = 3;
            this.btnPrint_HSBN.Text = "Lưu";
            this.btnPrint_HSBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint_HSBN.UseVisualStyleBackColor = true;
            this.btnPrint_HSBN.Click += new System.EventHandler(this.btnPrint_HSBN_Click);
            // 
            // btnSearch_HSBN
            // 
            this.btnSearch_HSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch_HSBN.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_HSBN.Image")));
            this.btnSearch_HSBN.Location = new System.Drawing.Point(1052, 16);
            this.btnSearch_HSBN.Name = "btnSearch_HSBN";
            this.btnSearch_HSBN.Size = new System.Drawing.Size(40, 35);
            this.btnSearch_HSBN.TabIndex = 6;
            this.btnSearch_HSBN.UseVisualStyleBackColor = true;
            this.btnSearch_HSBN.Click += new System.EventHandler(this.btnSearch_HSBN_Click);
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
            this.panel1.TabIndex = 7;
            this.panel1.Tag = "";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bệnh nhân:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số điện thoại:";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaBN_HSBN
            // 
            this.txtMaBN_HSBN.Location = new System.Drawing.Point(129, 96);
            this.txtMaBN_HSBN.Name = "txtMaBN_HSBN";
            this.txtMaBN_HSBN.ReadOnly = true;
            this.txtMaBN_HSBN.Size = new System.Drawing.Size(232, 27);
            this.txtMaBN_HSBN.TabIndex = 8;
            this.txtMaBN_HSBN.TextChanged += new System.EventHandler(this.txtMaBN_HSBN_TextChanged);
            // 
            // txtHoTen_HSBN
            // 
            this.txtHoTen_HSBN.Location = new System.Drawing.Point(129, 127);
            this.txtHoTen_HSBN.Name = "txtHoTen_HSBN";
            this.txtHoTen_HSBN.Size = new System.Drawing.Size(232, 27);
            this.txtHoTen_HSBN.TabIndex = 8;
            // 
            // dtNgaySinh_HSBN
            // 
            this.dtNgaySinh_HSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgaySinh_HSBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh_HSBN.Location = new System.Drawing.Point(621, 96);
            this.dtNgaySinh_HSBN.Name = "dtNgaySinh_HSBN";
            this.dtNgaySinh_HSBN.Size = new System.Drawing.Size(250, 27);
            this.dtNgaySinh_HSBN.TabIndex = 9;
            // 
            // txtDiaChi_HSBN
            // 
            this.txtDiaChi_HSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi_HSBN.Location = new System.Drawing.Point(621, 127);
            this.txtDiaChi_HSBN.Name = "txtDiaChi_HSBN";
            this.txtDiaChi_HSBN.Size = new System.Drawing.Size(471, 27);
            this.txtDiaChi_HSBN.TabIndex = 8;
            // 
            // txtSDT_HSBN
            // 
            this.txtSDT_HSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT_HSBN.Location = new System.Drawing.Point(621, 156);
            this.txtSDT_HSBN.Name = "txtSDT_HSBN";
            this.txtSDT_HSBN.Size = new System.Drawing.Size(232, 27);
            this.txtSDT_HSBN.TabIndex = 8;
            this.txtSDT_HSBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_HSBN_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 38);
            this.panel2.TabIndex = 7;
            this.panel2.Tag = "";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 301);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbGioiTinh_BN
            // 
            this.cbGioiTinh_BN.FormattingEnabled = true;
            this.cbGioiTinh_BN.Location = new System.Drawing.Point(129, 155);
            this.cbGioiTinh_BN.Name = "cbGioiTinh_BN";
            this.cbGioiTinh_BN.Size = new System.Drawing.Size(232, 28);
            this.cbGioiTinh_BN.TabIndex = 11;
            // 
            // HoSoBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 552);
            this.Controls.Add(this.cbGioiTinh_BN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtNgaySinh_HSBN);
            this.Controls.Add(this.txtSDT_HSBN);
            this.Controls.Add(this.txtDiaChi_HSBN);
            this.Controls.Add(this.txtHoTen_HSBN);
            this.Controls.Add(this.txtMaBN_HSBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch_HSBN);
            this.Controls.Add(this.btnPrint_HSBN);
            this.Controls.Add(this.btnDelete_HSBN);
            this.Controls.Add(this.btnCancel_HSBN);
            this.Controls.Add(this.btnAdd_BenhNhan);
            this.Controls.Add(this.txtSearch_HSBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoSoBenhNhan";
            this.Text = "Hồ sơ bệnh nhân";
            this.Load += new System.EventHandler(this.HoSoBenhNhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btnAdd_BenhNhan;
        private Button btnCancel_HSBN;
        private Button btnDelete_HSBN;
        private Button btnPrint_HSBN;
        private Button btnSearch_HSBN;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMaBN_HSBN;
        private TextBox txtHoTen_HSBN;
        private DateTimePicker dtNgaySinh_HSBN;
        private TextBox txtDiaChi_HSBN;
        private TextBox txtSDT_HSBN;
        private Panel panel2;
        private Label label8;
        private DataGridView dataGridView1;
        private TextBox txtSearch_HSBN;
        private ComboBox cbGioiTinh_BN;
    }
}