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
    public partial class frmQLThuoc : Form
    {
        Database db;
        public frmQLThuoc()
        {
            InitializeComponent();
            db = new Database();
        }

        private void frmQLThuoc_Load(object sender, EventArgs e)
        {
            txtMaThuoc_A.Text = "";
            txtTenThuoc_A.Text = "";
            txtGiaThuoc_A.Text = "";
            txtSearchThuoc_A.Text = "";
            try
            {
                db.loadData("sp_DanhSachThuoc", gv_ThuocA);
                List<string> donvi = new List<string>() { "Viên", "Gói","Chai","Hộp" };
                cbDonViThuoc_A.DataSource = donvi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddThuoc_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_ThemThuoc N'" + txtTenThuoc_A.Text + "', " + txtGiaThuoc_A.Text + ", N'" + cbDonViThuoc_A.Text + "'");
            db.loadData("sp_DanhSachThuoc", gv_ThuocA);
        }

        private void btnCancelThuoc_A_Click(object sender, EventArgs e)
        {
            frmQLThuoc_Load(sender, e);
        }

        private void btnPrintThuoc_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_ChinhSuaThuoc " + txtMaThuoc_A.Text + ", N'" + txtTenThuoc_A.Text + "', " + txtGiaThuoc_A.Text + ", N'" + cbDonViThuoc_A.Text + "'");
            db.loadData("sp_DanhSachThuoc", gv_ThuocA);
        }

        private void txtSearchThuoc_A_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearchThuoc_A.Text;
            if (s.Length == 0)
            {
                db.loadData("sp_DanhSachThuoc", gv_ThuocA);
            }
            else
            {
                db.loadData("sp_TimKiemThuoc N'" + s + "'", gv_ThuocA);
            }

        }

        private void txtGiaThuoc_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gv_ThuocA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gv_ThuocA.Rows[e.RowIndex];
                txtMaThuoc_A.Text = row.Cells[0].Value.ToString();
                txtTenThuoc_A.Text = row.Cells[1].Value.ToString();
                cbDonViThuoc_A.Text = row.Cells[2].Value.ToString();
                txtGiaThuoc_A.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDeleteThuoc_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_XoaThuoc " + txtMaThuoc_A.Text);
            db.loadData("sp_DanhSachThuoc", gv_ThuocA);
        }
    }
}
