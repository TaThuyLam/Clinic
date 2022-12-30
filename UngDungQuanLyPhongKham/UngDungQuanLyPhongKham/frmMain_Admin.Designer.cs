namespace UngDungQuanLyPhongKham
{
    partial class frmMain_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain_Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.btn_QLT = new System.Windows.Forms.Button();
            this.btn_QLDV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SettinhAdmin = new System.Windows.Forms.Button();
            this.txt_Date = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_LogoutAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_QLNV);
            this.panel1.Controls.Add(this.btn_QLT);
            this.panel1.Controls.Add(this.btn_QLDV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 724);
            this.panel1.TabIndex = 0;
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLNV.FlatAppearance.BorderSize = 0;
            this.btn_QLNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QLNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLNV.ForeColor = System.Drawing.Color.White;
            this.btn_QLNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLNV.Image")));
            this.btn_QLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNV.Location = new System.Drawing.Point(0, 145);
            this.btn_QLNV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(166, 40);
            this.btn_QLNV.TabIndex = 6;
            this.btn_QLNV.Text = "Quản lý nhân viên";
            this.btn_QLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLNV.UseVisualStyleBackColor = false;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // btn_QLT
            // 
            this.btn_QLT.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLT.FlatAppearance.BorderSize = 0;
            this.btn_QLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLT.ForeColor = System.Drawing.Color.White;
            this.btn_QLT.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLT.Image")));
            this.btn_QLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLT.Location = new System.Drawing.Point(0, 105);
            this.btn_QLT.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QLT.Name = "btn_QLT";
            this.btn_QLT.Size = new System.Drawing.Size(166, 40);
            this.btn_QLT.TabIndex = 5;
            this.btn_QLT.Text = "Quản lý thuốc";
            this.btn_QLT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLT.UseVisualStyleBackColor = false;
            this.btn_QLT.Click += new System.EventHandler(this.btn_QLT_Click);
            // 
            // btn_QLDV
            // 
            this.btn_QLDV.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLDV.FlatAppearance.BorderSize = 0;
            this.btn_QLDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLDV.ForeColor = System.Drawing.Color.White;
            this.btn_QLDV.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLDV.Image")));
            this.btn_QLDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLDV.Location = new System.Drawing.Point(0, 65);
            this.btn_QLDV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QLDV.Name = "btn_QLDV";
            this.btn_QLDV.Size = new System.Drawing.Size(166, 40);
            this.btn_QLDV.TabIndex = 4;
            this.btn_QLDV.Text = "Quản lý dịch vụ";
            this.btn_QLDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLDV.UseVisualStyleBackColor = false;
            this.btn_QLDV.Click += new System.EventHandler(this.btn_QLDV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_SettinhAdmin);
            this.panel2.Controls.Add(this.txt_Date);
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 43);
            this.panel2.TabIndex = 1;
            // 
            // btn_SettinhAdmin
            // 
            this.btn_SettinhAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SettinhAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_SettinhAdmin.Image")));
            this.btn_SettinhAdmin.Location = new System.Drawing.Point(916, 7);
            this.btn_SettinhAdmin.Name = "btn_SettinhAdmin";
            this.btn_SettinhAdmin.Size = new System.Drawing.Size(195, 31);
            this.btn_SettinhAdmin.TabIndex = 4;
            this.btn_SettinhAdmin.Text = "Admin";
            this.btn_SettinhAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SettinhAdmin.UseVisualStyleBackColor = true;
            this.btn_SettinhAdmin.Click += new System.EventHandler(this.btn_SettinhAdmin_Click);
            // 
            // txt_Date
            // 
            this.txt_Date.AutoSize = true;
            this.txt_Date.BackColor = System.Drawing.Color.Transparent;
            this.txt_Date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Date.ForeColor = System.Drawing.Color.White;
            this.txt_Date.Location = new System.Drawing.Point(21, 10);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(107, 23);
            this.txt_Date.TabIndex = 3;
            this.txt_Date.Text = "dd/mm/yyy";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(166, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 677);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.btn_LogoutAdmin);
            this.panel4.Location = new System.Drawing.Point(1146, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 42);
            this.panel4.TabIndex = 2;
            // 
            // btn_LogoutAdmin
            // 
            this.btn_LogoutAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LogoutAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogoutAdmin.Image")));
            this.btn_LogoutAdmin.Location = new System.Drawing.Point(0, 0);
            this.btn_LogoutAdmin.Name = "btn_LogoutAdmin";
            this.btn_LogoutAdmin.Size = new System.Drawing.Size(90, 29);
            this.btn_LogoutAdmin.TabIndex = 0;
            this.btn_LogoutAdmin.Text = "Thoát";
            this.btn_LogoutAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LogoutAdmin.UseVisualStyleBackColor = true;
            this.btn_LogoutAdmin.Click += new System.EventHandler(this.btn_LogoutAdmin_Click);
            // 
            // frmMain_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 721);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain_Admin";
            this.Text = "Hệ thống";
            this.Load += new System.EventHandler(this.frmMain_Admin_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_Admin_SizeChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label txt_Date;
        private Panel panel3;
        private Button btn_SettinhAdmin;
        private Panel panel4;
        private Button btn_LogoutAdmin;
        private Button btn_QLNV;
        private Button btn_QLT;
        private Button btn_QLDV;
        private PictureBox pictureBox1;
    }
}