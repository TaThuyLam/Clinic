namespace UngDungQuanLyPhongKham
{
    partial class frmChiTietPhieuDV
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
            this.gvChiTietDVDung = new System.Windows.Forms.DataGridView();
            this.btnTTDV_OK = new System.Windows.Forms.Button();
            this.btnCancelDV_TT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC_PDV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDVDung)).BeginInit();
            this.SuspendLayout();
            // 
            // gvChiTietDVDung
            // 
            this.gvChiTietDVDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChiTietDVDung.Location = new System.Drawing.Point(12, 12);
            this.gvChiTietDVDung.Name = "gvChiTietDVDung";
            this.gvChiTietDVDung.RowHeadersWidth = 51;
            this.gvChiTietDVDung.RowTemplate.Height = 29;
            this.gvChiTietDVDung.Size = new System.Drawing.Size(776, 513);
            this.gvChiTietDVDung.TabIndex = 0;
            // 
            // btnTTDV_OK
            // 
            this.btnTTDV_OK.Location = new System.Drawing.Point(612, 652);
            this.btnTTDV_OK.Name = "btnTTDV_OK";
            this.btnTTDV_OK.Size = new System.Drawing.Size(176, 29);
            this.btnTTDV_OK.TabIndex = 1;
            this.btnTTDV_OK.Text = "Xác nhận thanh toán";
            this.btnTTDV_OK.UseVisualStyleBackColor = true;
            this.btnTTDV_OK.Click += new System.EventHandler(this.btnTTDV_OK_Click);
            // 
            // btnCancelDV_TT
            // 
            this.btnCancelDV_TT.Location = new System.Drawing.Point(501, 652);
            this.btnCancelDV_TT.Name = "btnCancelDV_TT";
            this.btnCancelDV_TT.Size = new System.Drawing.Size(105, 29);
            this.btnCancelDV_TT.TabIndex = 1;
            this.btnCancelDV_TT.Text = "Thoát";
            this.btnCancelDV_TT.UseVisualStyleBackColor = true;
            this.btnCancelDV_TT.Click += new System.EventHandler(this.btnCancelDV_TT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng cộng:";
            // 
            // txtTC_PDV
            // 
            this.txtTC_PDV.Location = new System.Drawing.Point(107, 532);
            this.txtTC_PDV.Name = "txtTC_PDV";
            this.txtTC_PDV.Size = new System.Drawing.Size(225, 27);
            this.txtTC_PDV.TabIndex = 3;
            // 
            // frmChiTietPhieuDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.txtTC_PDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelDV_TT);
            this.Controls.Add(this.btnTTDV_OK);
            this.Controls.Add(this.gvChiTietDVDung);
            this.Name = "frmChiTietPhieuDV";
            this.Text = "Hóa đơn dịch vụ";
            this.Load += new System.EventHandler(this.frmChiTietPhieuDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDVDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvChiTietDVDung;
        private Button btnTTDV_OK;
        private Button btnCancelDV_TT;
        private Label label1;
        private TextBox txtTC_PDV;
    }
}