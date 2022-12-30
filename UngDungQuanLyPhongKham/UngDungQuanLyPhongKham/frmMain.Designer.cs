namespace UngDungQuanLyPhongKham
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btn_QuanLyThanhToan = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_HoSoBN = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.content = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.txtNgayHeThong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btn_QuanLyThanhToan);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_HoSoBN);
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 588);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Location = new System.Drawing.Point(0, 210);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(173, 42);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btn_QuanLyThanhToan
            // 
            this.btn_QuanLyThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyThanhToan.Location = new System.Drawing.Point(0, 168);
            this.btn_QuanLyThanhToan.Name = "btn_QuanLyThanhToan";
            this.btn_QuanLyThanhToan.Size = new System.Drawing.Size(173, 42);
            this.btn_QuanLyThanhToan.TabIndex = 1;
            this.btn_QuanLyThanhToan.Text = "Thanh toán";
            this.btn_QuanLyThanhToan.UseVisualStyleBackColor = true;
            this.btn_QuanLyThanhToan.Click += new System.EventHandler(this.btn_QuanLyThanhToan_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 42);
            this.button4.TabIndex = 0;
            this.button4.Text = "Lập phiếu khám";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Danh sách phiếu khám";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tiếp nhận bệnh nhân";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_HoSoBN
            // 
            this.btn_HoSoBN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HoSoBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HoSoBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoSoBN.Location = new System.Drawing.Point(0, 0);
            this.btn_HoSoBN.Name = "btn_HoSoBN";
            this.btn_HoSoBN.Size = new System.Drawing.Size(173, 42);
            this.btn_HoSoBN.TabIndex = 0;
            this.btn_HoSoBN.Text = "Hồ sơ bệnh nhân";
            this.btn_HoSoBN.UseVisualStyleBackColor = false;
            this.btn_HoSoBN.Click += new System.EventHandler(this.btn_HoSoBN_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSetting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSetting.Controls.Add(this.btn_Logout);
            this.panelSetting.Controls.Add(this.btn_Account);
            this.panelSetting.Location = new System.Drawing.Point(1137, 38);
            this.panelSetting.MaximumSize = new System.Drawing.Size(153, 121);
            this.panelSetting.MinimumSize = new System.Drawing.Size(153, 28);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(153, 83);
            this.panelSetting.TabIndex = 5;
            this.panelSetting.Visible = false;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(0, 44);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(153, 29);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Thoát";
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
            this.btn_Account.Location = new System.Drawing.Point(0, 0);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(153, 44);
            this.btn_Account.TabIndex = 5;
            this.btn_Account.Text = "Tài khoản";
            this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Account.UseVisualStyleBackColor = true;
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.Location = new System.Drawing.Point(174, 32);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1154, 557);
            this.content.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.txtNgayHeThong);
            this.panel2.Location = new System.Drawing.Point(174, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 32);
            this.panel2.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(932, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(184, 28);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Name";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNgayHeThong
            // 
            this.txtNgayHeThong.AutoSize = true;
            this.txtNgayHeThong.BackColor = System.Drawing.Color.Transparent;
            this.txtNgayHeThong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNgayHeThong.ForeColor = System.Drawing.Color.White;
            this.txtNgayHeThong.Location = new System.Drawing.Point(13, 8);
            this.txtNgayHeThong.Name = "txtNgayHeThong";
            this.txtNgayHeThong.Size = new System.Drawing.Size(0, 20);
            this.txtNgayHeThong.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1333, 591);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btn_HoSoBN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button6;
        private Button button5;
        private Panel content;
        private Button btnLapDonThuoc;
        private Button btnLapDichVu;
        private Panel panel2;
        private Label txtNgayHeThong;
        private ComboBox cbAccount;
        private Panel panel3;
        private Button btn_Logout;
        private Button btn_Account;
        private Button txtAccount;
        private Panel panelSetting;
        private Button button1;
        private Button btnSetting;
        private Button btnThongKe;
        private Button btn_QuanLyThanhToan;
    }
}