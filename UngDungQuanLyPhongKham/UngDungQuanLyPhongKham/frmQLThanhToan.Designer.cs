namespace UngDungQuanLyPhongKham
{
    partial class frmQLThanhToan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearchPhieuDV_TT = new System.Windows.Forms.Button();
            this.txtSearchPDV_TT = new System.Windows.Forms.TextBox();
            this.gvPK_TT = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvDT_PK = new System.Windows.Forms.DataGridView();
            this.btnSearchDT_TT = new System.Windows.Forms.Button();
            this.txtSearchDT_TT = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPK_TT)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDT_PK)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearchPhieuDV_TT);
            this.tabPage1.Controls.Add(this.txtSearchPDV_TT);
            this.tabPage1.Controls.Add(this.gvPK_TT);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1072, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thanh toán dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearchPhieuDV_TT
            // 
            this.btnSearchPhieuDV_TT.Location = new System.Drawing.Point(453, 21);
            this.btnSearchPhieuDV_TT.Name = "btnSearchPhieuDV_TT";
            this.btnSearchPhieuDV_TT.Size = new System.Drawing.Size(94, 29);
            this.btnSearchPhieuDV_TT.TabIndex = 2;
            this.btnSearchPhieuDV_TT.Text = "Tìm";
            this.btnSearchPhieuDV_TT.UseVisualStyleBackColor = true;
            // 
            // txtSearchPDV_TT
            // 
            this.txtSearchPDV_TT.Location = new System.Drawing.Point(6, 21);
            this.txtSearchPDV_TT.Name = "txtSearchPDV_TT";
            this.txtSearchPDV_TT.PlaceholderText = "Mã phiếu khám....";
            this.txtSearchPDV_TT.Size = new System.Drawing.Size(426, 27);
            this.txtSearchPDV_TT.TabIndex = 1;
            this.txtSearchPDV_TT.TextChanged += new System.EventHandler(this.txtSearchPDV_TT_TextChanged);
            // 
            // gvPK_TT
            // 
            this.gvPK_TT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPK_TT.Location = new System.Drawing.Point(6, 68);
            this.gvPK_TT.Name = "gvPK_TT";
            this.gvPK_TT.RowHeadersWidth = 51;
            this.gvPK_TT.RowTemplate.Height = 29;
            this.gvPK_TT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPK_TT.Size = new System.Drawing.Size(1063, 421);
            this.gvPK_TT.TabIndex = 0;
            this.gvPK_TT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPK_TT_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvDT_PK);
            this.tabPage2.Controls.Add(this.btnSearchDT_TT);
            this.tabPage2.Controls.Add(this.txtSearchDT_TT);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1072, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thanh toán đơn thuốc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvDT_PK
            // 
            this.gvDT_PK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDT_PK.Location = new System.Drawing.Point(6, 67);
            this.gvDT_PK.Name = "gvDT_PK";
            this.gvDT_PK.RowHeadersWidth = 51;
            this.gvDT_PK.RowTemplate.Height = 29;
            this.gvDT_PK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDT_PK.Size = new System.Drawing.Size(1060, 422);
            this.gvDT_PK.TabIndex = 2;
            this.gvDT_PK.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDT_PK_CellDoubleClick);
            // 
            // btnSearchDT_TT
            // 
            this.btnSearchDT_TT.Location = new System.Drawing.Point(577, 18);
            this.btnSearchDT_TT.Name = "btnSearchDT_TT";
            this.btnSearchDT_TT.Size = new System.Drawing.Size(94, 29);
            this.btnSearchDT_TT.TabIndex = 1;
            this.btnSearchDT_TT.Text = "Tìm";
            this.btnSearchDT_TT.UseVisualStyleBackColor = true;
            // 
            // txtSearchDT_TT
            // 
            this.txtSearchDT_TT.Location = new System.Drawing.Point(6, 20);
            this.txtSearchDT_TT.Name = "txtSearchDT_TT";
            this.txtSearchDT_TT.PlaceholderText = "Mã phiếu khám...";
            this.txtSearchDT_TT.Size = new System.Drawing.Size(553, 27);
            this.txtSearchDT_TT.TabIndex = 0;
            this.txtSearchDT_TT.TextChanged += new System.EventHandler(this.txtSearchDT_TT_TextChanged);
            // 
            // frmQLThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 552);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLThanhToan";
            this.Text = "frmQLThanhToan";
            this.Load += new System.EventHandler(this.frmQLThanhToan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPK_TT)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDT_PK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSearchPhieuDV_TT;
        private TextBox txtSearchPDV_TT;
        private DataGridView gvPK_TT;
        private DataGridView gvDT_PK;
        private Button btnSearchDT_TT;
        private TextBox txtSearchDT_TT;
    }
}