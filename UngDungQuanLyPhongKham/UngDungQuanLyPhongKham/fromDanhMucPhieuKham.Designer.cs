namespace UngDungQuanLyPhongKham
{
    partial class fromDanhMucPhieuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromDanhMucPhieuKham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTraCuuTen = new System.Windows.Forms.Button();
            this.btnTraCuuNgay = new System.Windows.Forms.Button();
            this.gvChuaKham = new System.Windows.Forms.DataGridView();
            this.gvTraCuu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuaKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Name = "label2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnTraCuuTen
            // 
            resources.ApplyResources(this.btnTraCuuTen, "btnTraCuuTen");
            this.btnTraCuuTen.Name = "btnTraCuuTen";
            this.btnTraCuuTen.UseVisualStyleBackColor = true;
            // 
            // btnTraCuuNgay
            // 
            resources.ApplyResources(this.btnTraCuuNgay, "btnTraCuuNgay");
            this.btnTraCuuNgay.Name = "btnTraCuuNgay";
            this.btnTraCuuNgay.UseVisualStyleBackColor = true;
            // 
            // gvChuaKham
            // 
            resources.ApplyResources(this.gvChuaKham, "gvChuaKham");
            this.gvChuaKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChuaKham.Name = "gvChuaKham";
            this.gvChuaKham.RowTemplate.Height = 29;
            this.gvChuaKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvChuaKham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChuaKham_CellDoubleClick);
            // 
            // gvTraCuu
            // 
            resources.ApplyResources(this.gvTraCuu, "gvTraCuu");
            this.gvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTraCuu.Name = "gvTraCuu";
            this.gvTraCuu.RowTemplate.Height = 29;
            this.gvTraCuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTraCuu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTraCuu_CellDoubleClick);
            // 
            // fromDanhMucPhieuKham
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvTraCuu);
            this.Controls.Add(this.gvChuaKham);
            this.Controls.Add(this.btnTraCuuNgay);
            this.Controls.Add(this.btnTraCuuTen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fromDanhMucPhieuKham";
            this.Load += new System.EventHandler(this.fromDanhMucPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvChuaKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnTraCuuTen;
        private Button btnTraCuuNgay;
        private DataGridView gvChuaKham;
        private DataGridView gvTraCuu;
    }
}