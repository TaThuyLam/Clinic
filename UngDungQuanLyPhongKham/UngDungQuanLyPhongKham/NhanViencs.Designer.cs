namespace AppQLPK
{
    partial class NhanViencs
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNhanVien_dm = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUp_dm = new System.Windows.Forms.Button();
            this.btnXoa_dm = new System.Windows.Forms.Button();
            this.btnThem_dm = new System.Windows.Forms.Button();
            this.txtChucVu_dm = new System.Windows.Forms.TextBox();
            this.txtChuyenMon_dm = new System.Windows.Forms.TextBox();
            this.txtTrinhDo_dm = new System.Windows.Forms.TextBox();
            this.txtHoten_dm = new System.Windows.Forms.TextBox();
            this.txtmanv_dm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNhanVien_dm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 650);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNhanVien_dm);
            this.groupBox2.Location = new System.Drawing.Point(3, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1072, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dtNhanVien_dm
            // 
            this.dtNhanVien_dm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNhanVien_dm.Location = new System.Drawing.Point(11, 46);
            this.dtNhanVien_dm.Name = "dtNhanVien_dm";
            this.dtNhanVien_dm.RowHeadersWidth = 62;
            this.dtNhanVien_dm.RowTemplate.Height = 28;
            this.dtNhanVien_dm.Size = new System.Drawing.Size(1055, 247);
            this.dtNhanVien_dm.TabIndex = 0;
            this.dtNhanVien_dm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNhanVien_dm_CellClick);
            this.dtNhanVien_dm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNhanVien_dm_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUp_dm);
            this.groupBox1.Controls.Add(this.btnXoa_dm);
            this.groupBox1.Controls.Add(this.btnThem_dm);
            this.groupBox1.Controls.Add(this.txtChucVu_dm);
            this.groupBox1.Controls.Add(this.txtChuyenMon_dm);
            this.groupBox1.Controls.Add(this.txtTrinhDo_dm);
            this.groupBox1.Controls.Add(this.txtHoten_dm);
            this.groupBox1.Controls.Add(this.txtmanv_dm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnUp_dm
            // 
            this.btnUp_dm.Location = new System.Drawing.Point(778, 150);
            this.btnUp_dm.Name = "btnUp_dm";
            this.btnUp_dm.Size = new System.Drawing.Size(90, 37);
            this.btnUp_dm.TabIndex = 3;
            this.btnUp_dm.Text = "Cập nhật";
            this.btnUp_dm.UseVisualStyleBackColor = true;
            // 
            // btnXoa_dm
            // 
            this.btnXoa_dm.Location = new System.Drawing.Point(666, 150);
            this.btnXoa_dm.Name = "btnXoa_dm";
            this.btnXoa_dm.Size = new System.Drawing.Size(90, 37);
            this.btnXoa_dm.TabIndex = 3;
            this.btnXoa_dm.Text = "Xóa";
            this.btnXoa_dm.UseVisualStyleBackColor = true;
            // 
            // btnThem_dm
            // 
            this.btnThem_dm.Location = new System.Drawing.Point(551, 150);
            this.btnThem_dm.Name = "btnThem_dm";
            this.btnThem_dm.Size = new System.Drawing.Size(90, 37);
            this.btnThem_dm.TabIndex = 3;
            this.btnThem_dm.Text = "Thêm";
            this.btnThem_dm.UseVisualStyleBackColor = true;
            this.btnThem_dm.Click += new System.EventHandler(this.btnThem_dm_Click);
            // 
            // txtChucVu_dm
            // 
            this.txtChucVu_dm.Location = new System.Drawing.Point(706, 73);
            this.txtChucVu_dm.Name = "txtChucVu_dm";
            this.txtChucVu_dm.Size = new System.Drawing.Size(186, 26);
            this.txtChucVu_dm.TabIndex = 1;
            // 
            // txtChuyenMon_dm
            // 
            this.txtChuyenMon_dm.Location = new System.Drawing.Point(706, 32);
            this.txtChuyenMon_dm.Name = "txtChuyenMon_dm";
            this.txtChuyenMon_dm.Size = new System.Drawing.Size(186, 26);
            this.txtChuyenMon_dm.TabIndex = 1;
            // 
            // txtTrinhDo_dm
            // 
            this.txtTrinhDo_dm.Location = new System.Drawing.Point(138, 115);
            this.txtTrinhDo_dm.Name = "txtTrinhDo_dm";
            this.txtTrinhDo_dm.Size = new System.Drawing.Size(287, 26);
            this.txtTrinhDo_dm.TabIndex = 1;
            // 
            // txtHoten_dm
            // 
            this.txtHoten_dm.Location = new System.Drawing.Point(137, 70);
            this.txtHoten_dm.Name = "txtHoten_dm";
            this.txtHoten_dm.Size = new System.Drawing.Size(288, 26);
            this.txtHoten_dm.TabIndex = 1;
            // 
            // txtmanv_dm
            // 
            this.txtmanv_dm.Location = new System.Drawing.Point(138, 26);
            this.txtmanv_dm.Name = "txtmanv_dm";
            this.txtmanv_dm.Size = new System.Drawing.Size(159, 26);
            this.txtmanv_dm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chuyên môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trình độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(462, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // NhanViencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 674);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanViencs";
            this.Text = "NhanViencs";
            this.Load += new System.EventHandler(this.NhanViencs_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNhanVien_dm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtNhanVien_dm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUp_dm;
        private System.Windows.Forms.Button btnXoa_dm;
        private System.Windows.Forms.Button btnThem_dm;
        private System.Windows.Forms.TextBox txtChucVu_dm;
        private System.Windows.Forms.TextBox txtChuyenMon_dm;
        private System.Windows.Forms.TextBox txtTrinhDo_dm;
        private System.Windows.Forms.TextBox txtHoten_dm;
        private System.Windows.Forms.TextBox txtmanv_dm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}