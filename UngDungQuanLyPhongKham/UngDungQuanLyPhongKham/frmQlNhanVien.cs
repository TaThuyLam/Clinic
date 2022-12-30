using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyPhongKham
{
    public partial class frmQlNhanVien : Form
    {
        Database db;
        public frmQlNhanVien()
        {
            InitializeComponent();
            db = new Database();
        }
        private void frmQlNhanVien_Load(object sender, EventArgs e)
        {
            this.Size = Parent.Size;
            txtMaNV_A.Text = "";
            txtTenNV_A.Text = "";
            txtTaiKhoanTenNV_A.Text = "";
            txtSearchNV_A.Text = "";
            dtNgaySinh.Text = DateTime.Now.ToString().Split()[0];
            try
            {
                db.loadData("sp_DanhSachNhanVien", gv_NhanVienA);
                db.sqlToComboBox("select chuyenmon from NHANVIEN group by chuyenmon", cbChuyenMon_A);
                db.sqlToComboBox("select chucvu from NHANVIEN group by chucvu", cbChucVu_A);
                db.sqlToComboBox("select trinhdo from NHANVIEN group by trinhdo", cbTrinhDo_A);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddNhanVien_A_Click(object sender, EventArgs e)
        {

             db.UpdateData("sp_ThemNhanVien N'" + txtTenNV_A.Text + "', N'" + cbTrinhDo_A.Text + "', N'" + cbChuyenMon_A.Text + "', N'" + cbChucVu_A.Text+"','"+txtTaiKhoanTenNV_A.Text + "', '" + dtNgaySinh.Text + "'");
            db.loadData("sp_DanhSachNhanVien", gv_NhanVienA);
        }

        private void btnCancelNV_A_Click(object sender, EventArgs e)
        {
            frmQlNhanVien_Load(sender, e);
        }

        private void btnDeleteNV_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_XoaNhanVien " + txtMaNV_A.Text);
            db.loadData("sp_DanhSachNhanVien", gv_NhanVienA);
        }

        private void btnPrintNV_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_ChinhSuaNhanVien " + txtMaNV_A.Text + ", N'" + txtTenNV_A.Text + "', N'" + cbTrinhDo_A.Text + "', N'" + cbChuyenMon_A.Text + "', N'" + cbChucVu_A.Text + "','" + txtTaiKhoanTenNV_A.Text + "', '" + dtNgaySinh.Text + "'");
        }

        private void txtSearchNV_A_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearchNV_A.Text;
            if (s.Length == 0)
            {
                db.loadData("sp_DanhSachNhanVien", gv_NhanVienA);
            }
            else
            {
                db.loadData("sp_TimKiemNhanVien N'" + s + "'", gv_NhanVienA);
            }
        }

        private void gv_NhanVienA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gv_NhanVienA.Rows[e.RowIndex];
                txtMaNV_A.Text = row.Cells[0].Value.ToString();
                txtTenNV_A.Text = row.Cells[1].Value.ToString();
                cbChucVu_A.Text = row.Cells[2].Value.ToString();
                cbChuyenMon_A.Text = row.Cells[3].Value.ToString();
                cbTrinhDo_A.Text = row.Cells[4].Value.ToString();
                txtTaiKhoanTenNV_A.Text = row.Cells[5].Value.ToString();
                dtNgaySinh.Text=row.Cells[6].Value.ToString();
            }
        }
    }
}
