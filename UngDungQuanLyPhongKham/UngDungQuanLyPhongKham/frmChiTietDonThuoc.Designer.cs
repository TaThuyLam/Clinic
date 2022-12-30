namespace UngDungQuanLyPhongKham
{
    partial class frmChiTietDonThuoc
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
            this.txtTC_DT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelDT_TT = new System.Windows.Forms.Button();
            this.btnTTDT_OK = new System.Windows.Forms.Button();
            this.gvChiTietDTDung = new System.Windows.Forms.DataGridView();
            this.txtSoNgayThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDTDung)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTC_DT
            // 
            this.txtTC_DT.Enabled = false;
            this.txtTC_DT.Location = new System.Drawing.Point(563, 607);
            this.txtTC_DT.Name = "txtTC_DT";
            this.txtTC_DT.Size = new System.Drawing.Size(225, 27);
            this.txtTC_DT.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng cộng:";
            // 
            // btnCancelDT_TT
            // 
            this.btnCancelDT_TT.Location = new System.Drawing.Point(501, 652);
            this.btnCancelDT_TT.Name = "btnCancelDT_TT";
            this.btnCancelDT_TT.Size = new System.Drawing.Size(105, 29);
            this.btnCancelDT_TT.TabIndex = 5;
            this.btnCancelDT_TT.Text = "Thoát";
            this.btnCancelDT_TT.UseVisualStyleBackColor = true;
            this.btnCancelDT_TT.Click += new System.EventHandler(this.btnCancelDT_TT_Click);
            // 
            // btnTTDT_OK
            // 
            this.btnTTDT_OK.Location = new System.Drawing.Point(612, 652);
            this.btnTTDT_OK.Name = "btnTTDT_OK";
            this.btnTTDT_OK.Size = new System.Drawing.Size(176, 29);
            this.btnTTDT_OK.TabIndex = 6;
            this.btnTTDT_OK.Text = "Xác nhận thanh toán";
            this.btnTTDT_OK.UseVisualStyleBackColor = true;
            this.btnTTDT_OK.Click += new System.EventHandler(this.btnTTDT_OK_Click);
            // 
            // gvChiTietDTDung
            // 
            this.gvChiTietDTDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChiTietDTDung.Location = new System.Drawing.Point(12, 12);
            this.gvChiTietDTDung.Name = "gvChiTietDTDung";
            this.gvChiTietDTDung.RowHeadersWidth = 51;
            this.gvChiTietDTDung.RowTemplate.Height = 29;
            this.gvChiTietDTDung.Size = new System.Drawing.Size(776, 513);
            this.gvChiTietDTDung.TabIndex = 4;
            // 
            // txtSoNgayThuoc
            // 
            this.txtSoNgayThuoc.Enabled = false;
            this.txtSoNgayThuoc.Location = new System.Drawing.Point(563, 574);
            this.txtSoNgayThuoc.Name = "txtSoNgayThuoc";
            this.txtSoNgayThuoc.Size = new System.Drawing.Size(225, 27);
            this.txtSoNgayThuoc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số ngày thuốc:";
            // 
            // frmChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.txtSoNgayThuoc);
            this.Controls.Add(this.txtTC_DT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelDT_TT);
            this.Controls.Add(this.btnTTDT_OK);
            this.Controls.Add(this.gvChiTietDTDung);
            this.Name = "frmChiTietDonThuoc";
            this.Text = "Chi tiết đơn thuốc";
            this.Load += new System.EventHandler(this.frmChiTietDonThuoc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDTDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTC_DT;
        private Label label1;
        private Button btnCancelDT_TT;
        private Button btnTTDT_OK;
        private DataGridView gvChiTietDTDung;
        private TextBox txtSoNgayThuoc;
        private Label label2;
    }
}