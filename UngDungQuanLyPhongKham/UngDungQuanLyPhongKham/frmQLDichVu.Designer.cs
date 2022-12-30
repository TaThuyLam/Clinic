namespace UngDungQuanLyPhongKham
{
    partial class frmQLDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDichVu));
            this.cbLoaiDV_A = new System.Windows.Forms.ComboBox();
            this.gv_DichVuA = new System.Windows.Forms.DataGridView();
            this.txtTenDV_A = new System.Windows.Forms.TextBox();
            this.txtMaDV_A = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintVD_A = new System.Windows.Forms.Button();
            this.btnCancelDV_A = new System.Windows.Forms.Button();
            this.btnAddDV_A = new System.Windows.Forms.Button();
            this.btnSearch_HSBN = new System.Windows.Forms.Button();
            this.btnDeleteDV_A = new System.Windows.Forms.Button();
            this.txtSearchDV_A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPhongDV_A = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaDV_A = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDonViDV_A = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DichVuA)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLoaiDV_A
            // 
            this.cbLoaiDV_A.FormattingEnabled = true;
            this.cbLoaiDV_A.Location = new System.Drawing.Point(471, 126);
            this.cbLoaiDV_A.Name = "cbLoaiDV_A";
            this.cbLoaiDV_A.Size = new System.Drawing.Size(232, 28);
            this.cbLoaiDV_A.TabIndex = 53;
            // 
            // gv_DichVuA
            // 
            this.gv_DichVuA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.gv_DichVuA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_DichVuA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DichVuA.Location = new System.Drawing.Point(12, 214);
            this.gv_DichVuA.Name = "gv_DichVuA";
            this.gv_DichVuA.RowHeadersWidth = 51;
            this.gv_DichVuA.RowTemplate.Height = 29;
            this.gv_DichVuA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_DichVuA.Size = new System.Drawing.Size(1080, 431);
            this.gv_DichVuA.TabIndex = 52;
            this.gv_DichVuA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_DichVuA_CellContentClick);
            // 
            // txtTenDV_A
            // 
            this.txtTenDV_A.Location = new System.Drawing.Point(129, 127);
            this.txtTenDV_A.Name = "txtTenDV_A";
            this.txtTenDV_A.Size = new System.Drawing.Size(232, 27);
            this.txtTenDV_A.TabIndex = 48;
            // 
            // txtMaDV_A
            // 
            this.txtMaDV_A.Location = new System.Drawing.Point(129, 96);
            this.txtMaDV_A.Name = "txtMaDV_A";
            this.txtMaDV_A.ReadOnly = true;
            this.txtMaDV_A.Size = new System.Drawing.Size(232, 27);
            this.txtMaDV_A.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã dịch vụ:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 38);
            this.panel2.TabIndex = 45;
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
            this.panel1.TabIndex = 46;
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
            // btnPrintVD_A
            // 
            this.btnPrintVD_A.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintVD_A.Image")));
            this.btnPrintVD_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintVD_A.Location = new System.Drawing.Point(285, 12);
            this.btnPrintVD_A.Name = "btnPrintVD_A";
            this.btnPrintVD_A.Size = new System.Drawing.Size(76, 35);
            this.btnPrintVD_A.TabIndex = 43;
            this.btnPrintVD_A.Text = "Lưu";
            this.btnPrintVD_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintVD_A.UseVisualStyleBackColor = true;
            this.btnPrintVD_A.Click += new System.EventHandler(this.btnPrintVD_A_Click);
            // 
            // btnCancelDV_A
            // 
            this.btnCancelDV_A.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDV_A.Image")));
            this.btnCancelDV_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelDV_A.Location = new System.Drawing.Point(129, 12);
            this.btnCancelDV_A.Name = "btnCancelDV_A";
            this.btnCancelDV_A.Size = new System.Drawing.Size(67, 35);
            this.btnCancelDV_A.TabIndex = 34;
            this.btnCancelDV_A.Text = "Hủy";
            this.btnCancelDV_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelDV_A.UseVisualStyleBackColor = true;
            this.btnCancelDV_A.Click += new System.EventHandler(this.btnCancelDV_A_Click);
            // 
            // btnAddDV_A
            // 
            this.btnAddDV_A.Image = global::UngDungQuanLyPhongKham.Properties.Resources.Add;
            this.btnAddDV_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDV_A.Location = new System.Drawing.Point(12, 12);
            this.btnAddDV_A.Name = "btnAddDV_A";
            this.btnAddDV_A.Size = new System.Drawing.Size(111, 35);
            this.btnAddDV_A.TabIndex = 37;
            this.btnAddDV_A.Text = "Thêm mới";
            this.btnAddDV_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDV_A.UseVisualStyleBackColor = true;
            this.btnAddDV_A.Click += new System.EventHandler(this.btnAddDV_A_Click);
            // 
            // btnSearch_HSBN
            // 
            this.btnSearch_HSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch_HSBN.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_HSBN.Image")));
            this.btnSearch_HSBN.Location = new System.Drawing.Point(1052, 16);
            this.btnSearch_HSBN.Name = "btnSearch_HSBN";
            this.btnSearch_HSBN.Size = new System.Drawing.Size(40, 35);
            this.btnSearch_HSBN.TabIndex = 44;
            this.btnSearch_HSBN.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDV_A
            // 
            this.btnDeleteDV_A.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDV_A.Image")));
            this.btnDeleteDV_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDV_A.Location = new System.Drawing.Point(202, 12);
            this.btnDeleteDV_A.Name = "btnDeleteDV_A";
            this.btnDeleteDV_A.Size = new System.Drawing.Size(77, 35);
            this.btnDeleteDV_A.TabIndex = 42;
            this.btnDeleteDV_A.Text = "Xóa";
            this.btnDeleteDV_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteDV_A.UseVisualStyleBackColor = true;
            this.btnDeleteDV_A.Click += new System.EventHandler(this.btnDeleteDV_A_Click);
            // 
            // txtSearchDV_A
            // 
            this.txtSearchDV_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDV_A.Location = new System.Drawing.Point(713, 20);
            this.txtSearchDV_A.Name = "txtSearchDV_A";
            this.txtSearchDV_A.PlaceholderText = "Tìm dịch vụ...";
            this.txtSearchDV_A.Size = new System.Drawing.Size(333, 27);
            this.txtSearchDV_A.TabIndex = 33;
            this.txtSearchDV_A.TextChanged += new System.EventHandler(this.txtSearchDV_A_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Phòng:";
            // 
            // cbPhongDV_A
            // 
            this.cbPhongDV_A.FormattingEnabled = true;
            this.cbPhongDV_A.Location = new System.Drawing.Point(814, 127);
            this.cbPhongDV_A.Name = "cbPhongDV_A";
            this.cbPhongDV_A.Size = new System.Drawing.Size(232, 28);
            this.cbPhongDV_A.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Đơn giá:";
            // 
            // txtGiaDV_A
            // 
            this.txtGiaDV_A.Location = new System.Drawing.Point(471, 93);
            this.txtGiaDV_A.Name = "txtGiaDV_A";
            this.txtGiaDV_A.Size = new System.Drawing.Size(232, 27);
            this.txtGiaDV_A.TabIndex = 48;
            this.txtGiaDV_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaDV_A_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(724, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Đơn vị:";
            // 
            // cbDonViDV_A
            // 
            this.cbDonViDV_A.FormattingEnabled = true;
            this.cbDonViDV_A.Location = new System.Drawing.Point(814, 93);
            this.cbDonViDV_A.Name = "cbDonViDV_A";
            this.cbDonViDV_A.Size = new System.Drawing.Size(232, 28);
            this.cbDonViDV_A.TabIndex = 53;
            // 
            // frmQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 657);
            this.Controls.Add(this.cbDonViDV_A);
            this.Controls.Add(this.cbPhongDV_A);
            this.Controls.Add(this.cbLoaiDV_A);
            this.Controls.Add(this.gv_DichVuA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaDV_A);
            this.Controls.Add(this.txtTenDV_A);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaDV_A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrintVD_A);
            this.Controls.Add(this.btnCancelDV_A);
            this.Controls.Add(this.btnAddDV_A);
            this.Controls.Add(this.btnSearch_HSBN);
            this.Controls.Add(this.btnDeleteDV_A);
            this.Controls.Add(this.txtSearchDV_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLDichVu";
            this.Text = "frmQLDichVu";
            this.Load += new System.EventHandler(this.frmQLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DichVuA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbLoaiDV_A;
        private DataGridView gv_DichVuA;
        private TextBox txtTenDV_A;
        private TextBox txtMaDV_A;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private Panel panel1;
        private Label label1;
        private Button btnPrintVD_A;
        private Button btnCancelDV_A;
        private Button btnAddDV_A;
        private Button btnSearch_HSBN;
        private Button btnDeleteDV_A;
        private TextBox txtSearch_HSBN;
        private Label label5;
        private Label label6;
        private ComboBox cbPhongDV_A;
        private Label label7;
        private TextBox txtGiaDV_A;
        private Label label9;
        private ComboBox cbDonViDV_A;
        private TextBox txtSearchDV_A;
    }
}