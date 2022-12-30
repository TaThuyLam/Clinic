namespace UngDungQuanLyPhongKham
{
    partial class frmQLThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLThuoc));
            this.cbDonViThuoc_A = new System.Windows.Forms.ComboBox();
            this.gv_ThuocA = new System.Windows.Forms.DataGridView();
            this.txtGiaThuoc_A = new System.Windows.Forms.TextBox();
            this.txtTenThuoc_A = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaThuoc_A = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintThuoc_A = new System.Windows.Forms.Button();
            this.btnCancelThuoc_A = new System.Windows.Forms.Button();
            this.btnAddThuoc_A = new System.Windows.Forms.Button();
            this.btnSearch_HSBN = new System.Windows.Forms.Button();
            this.btnDeleteThuoc_A = new System.Windows.Forms.Button();
            this.txtSearchThuoc_A = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocA)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDonViThuoc_A
            // 
            this.cbDonViThuoc_A.FormattingEnabled = true;
            this.cbDonViThuoc_A.Location = new System.Drawing.Point(913, 93);
            this.cbDonViThuoc_A.Name = "cbDonViThuoc_A";
            this.cbDonViThuoc_A.Size = new System.Drawing.Size(179, 28);
            this.cbDonViThuoc_A.TabIndex = 74;
            // 
            // gv_ThuocA
            // 
            this.gv_ThuocA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.gv_ThuocA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_ThuocA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ThuocA.Location = new System.Drawing.Point(12, 173);
            this.gv_ThuocA.Name = "gv_ThuocA";
            this.gv_ThuocA.RowHeadersWidth = 51;
            this.gv_ThuocA.RowTemplate.Height = 29;
            this.gv_ThuocA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_ThuocA.Size = new System.Drawing.Size(1080, 472);
            this.gv_ThuocA.TabIndex = 71;
            this.gv_ThuocA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_ThuocA_CellContentClick);
            // 
            // txtGiaThuoc_A
            // 
            this.txtGiaThuoc_A.Location = new System.Drawing.Point(701, 93);
            this.txtGiaThuoc_A.Name = "txtGiaThuoc_A";
            this.txtGiaThuoc_A.Size = new System.Drawing.Size(145, 27);
            this.txtGiaThuoc_A.TabIndex = 69;
            this.txtGiaThuoc_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaThuoc_A_KeyPress);
            // 
            // txtTenThuoc_A
            // 
            this.txtTenThuoc_A.Location = new System.Drawing.Point(350, 93);
            this.txtTenThuoc_A.Name = "txtTenThuoc_A";
            this.txtTenThuoc_A.Size = new System.Drawing.Size(232, 27);
            this.txtTenThuoc_A.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(852, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Đơn vị:";
            // 
            // txtMaThuoc_A
            // 
            this.txtMaThuoc_A.Location = new System.Drawing.Point(129, 96);
            this.txtMaThuoc_A.Name = "txtMaThuoc_A";
            this.txtMaThuoc_A.ReadOnly = true;
            this.txtMaThuoc_A.Size = new System.Drawing.Size(103, 27);
            this.txtMaThuoc_A.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã thuốc:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 38);
            this.panel2.TabIndex = 66;
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
            this.panel1.TabIndex = 67;
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
            // btnPrintThuoc_A
            // 
            this.btnPrintThuoc_A.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintThuoc_A.Image")));
            this.btnPrintThuoc_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintThuoc_A.Location = new System.Drawing.Point(285, 12);
            this.btnPrintThuoc_A.Name = "btnPrintThuoc_A";
            this.btnPrintThuoc_A.Size = new System.Drawing.Size(76, 35);
            this.btnPrintThuoc_A.TabIndex = 64;
            this.btnPrintThuoc_A.Text = "Lưu";
            this.btnPrintThuoc_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintThuoc_A.UseVisualStyleBackColor = true;
            this.btnPrintThuoc_A.Click += new System.EventHandler(this.btnPrintThuoc_A_Click);
            // 
            // btnCancelThuoc_A
            // 
            this.btnCancelThuoc_A.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelThuoc_A.Image")));
            this.btnCancelThuoc_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelThuoc_A.Location = new System.Drawing.Point(129, 12);
            this.btnCancelThuoc_A.Name = "btnCancelThuoc_A";
            this.btnCancelThuoc_A.Size = new System.Drawing.Size(67, 35);
            this.btnCancelThuoc_A.TabIndex = 55;
            this.btnCancelThuoc_A.Text = "Hủy";
            this.btnCancelThuoc_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelThuoc_A.UseVisualStyleBackColor = true;
            this.btnCancelThuoc_A.Click += new System.EventHandler(this.btnCancelThuoc_A_Click);
            // 
            // btnAddThuoc_A
            // 
            this.btnAddThuoc_A.Image = global::UngDungQuanLyPhongKham.Properties.Resources.Add;
            this.btnAddThuoc_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddThuoc_A.Location = new System.Drawing.Point(12, 12);
            this.btnAddThuoc_A.Name = "btnAddThuoc_A";
            this.btnAddThuoc_A.Size = new System.Drawing.Size(111, 35);
            this.btnAddThuoc_A.TabIndex = 57;
            this.btnAddThuoc_A.Text = "Thêm mới";
            this.btnAddThuoc_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddThuoc_A.UseVisualStyleBackColor = true;
            this.btnAddThuoc_A.Click += new System.EventHandler(this.btnAddThuoc_A_Click);
            // 
            // btnSearch_HSBN
            // 
            this.btnSearch_HSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch_HSBN.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_HSBN.Image")));
            this.btnSearch_HSBN.Location = new System.Drawing.Point(1052, 16);
            this.btnSearch_HSBN.Name = "btnSearch_HSBN";
            this.btnSearch_HSBN.Size = new System.Drawing.Size(40, 35);
            this.btnSearch_HSBN.TabIndex = 65;
            this.btnSearch_HSBN.UseVisualStyleBackColor = true;
            // 
            // btnDeleteThuoc_A
            // 
            this.btnDeleteThuoc_A.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteThuoc_A.Image")));
            this.btnDeleteThuoc_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteThuoc_A.Location = new System.Drawing.Point(202, 12);
            this.btnDeleteThuoc_A.Name = "btnDeleteThuoc_A";
            this.btnDeleteThuoc_A.Size = new System.Drawing.Size(77, 35);
            this.btnDeleteThuoc_A.TabIndex = 63;
            this.btnDeleteThuoc_A.Text = "Xóa";
            this.btnDeleteThuoc_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteThuoc_A.UseVisualStyleBackColor = true;
            this.btnDeleteThuoc_A.Click += new System.EventHandler(this.btnDeleteThuoc_A_Click);
            // 
            // txtSearchThuoc_A
            // 
            this.txtSearchThuoc_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchThuoc_A.Location = new System.Drawing.Point(713, 20);
            this.txtSearchThuoc_A.Name = "txtSearchThuoc_A";
            this.txtSearchThuoc_A.PlaceholderText = "Tìm thuốc...";
            this.txtSearchThuoc_A.Size = new System.Drawing.Size(333, 27);
            this.txtSearchThuoc_A.TabIndex = 54;
            this.txtSearchThuoc_A.TextChanged += new System.EventHandler(this.txtSearchThuoc_A_TextChanged);
            // 
            // frmQLThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1104, 657);
            this.Controls.Add(this.cbDonViThuoc_A);
            this.Controls.Add(this.gv_ThuocA);
            this.Controls.Add(this.txtGiaThuoc_A);
            this.Controls.Add(this.txtTenThuoc_A);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaThuoc_A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrintThuoc_A);
            this.Controls.Add(this.btnCancelThuoc_A);
            this.Controls.Add(this.btnAddThuoc_A);
            this.Controls.Add(this.btnSearch_HSBN);
            this.Controls.Add(this.btnDeleteThuoc_A);
            this.Controls.Add(this.txtSearchThuoc_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLThuoc";
            this.Text = "frmQLThuoc";
            this.Load += new System.EventHandler(this.frmQLThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbDonViThuoc_A;
        private DataGridView gv_ThuocA;
        private TextBox txtGiaThuoc_A;
        private TextBox txtTenThuoc_A;
        private Label label9;
        private TextBox txtMaThuoc_A;
        private Label label7;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private Panel panel1;
        private Label label1;
        private Button btnPrintThuoc_A;
        private Button btnCancelThuoc_A;
        private Button btnAddThuoc_A;
        private Button btnSearch_HSBN;
        private Button btnDeleteThuoc_A;
        private TextBox txtSearchThuoc_A;
    }
}