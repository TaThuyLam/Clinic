using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyPhongKham
{
    public partial class frmTiepDon : Form
    {
        Database db;
        public frmTiepDon()
        {
            InitializeComponent();
            db=new Database();
        }
        private void frmTiepDon_Load(object sender, EventArgs e)
        {
            List<string> strings = new List<string>() { "Nam", "Nữ" };
            cbGioiTinh_PK.DataSource = strings;
            db.loadData("sp_DanhSachPhieuKham", gvPhieuKham);
            db.sqlToComboBox("select hoten from NHANVIEN where chucvu=N'Bác sĩ'", cbBacSi_PK);
            db.sqlToComboBox("select hoten from NHANVIEN where chucvu=N'Nhân viên tiếp nhận'", cbNhanVien_PK);
        }
        private void btnAdd_PK_Click(object sender, EventArgs e)
        {
            string sql = "sp_TaoPhieuKhamBenh N'" + txtHoTen_PK.Text + "', '" + dtNgaySinh_PK.Text + "', N'" + txtDiaChi_PK.Text + "', N'" + cbGioiTinh_PK.Text + "',' " + txtSDT_PK.Text + "', N' " + cbBacSi_PK.Text + "',N' " + cbNhanVien_PK.Text + "'";
         //   MessageBox.Show(sql);
            db.UpdateData(sql);
            db.loadData("sp_DanhSachPhieuKham", gvPhieuKham);
        }
       

        private void btnDelete_PK_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_XoaPhieuKham "+txtMaPK_PK.Text);
            db.loadData("sp_DanhSachPhieuKham", gvPhieuKham);
        }

        private void gvPhieuKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gvPhieuKham.Rows[e.RowIndex];
                txtMaPK_PK.Text = row.Cells[0].Value.ToString();
                dtNgayKham_PK.Text = row.Cells[1].Value.ToString();
                txtHoTen_PK.Text = row.Cells[2].Value.ToString();
                dtNgaySinh_PK.Text = row.Cells[3].Value.ToString();
                txtDiaChi_PK.Text = row.Cells[4].Value.ToString();
                cbGioiTinh_PK.Text = row.Cells[5].Value.ToString();
                cbBacSi_PK.Text = row.Cells[6].Value.ToString();
                cbNhanVien_PK.Text = row.Cells[7].Value.ToString();
                txtMaBN_PK.Text = db.GetIntBySql("select B.mabn from PHIEUKHAMBENH P,BENHNHAN B where  P.mabn=B.mabn and P.maphieukham= " + txtMaPK_PK.Text).ToString();
                txtSDT_PK.Text = db.GetStringBySql("select sodienthoai from PHIEUKHAMBENH P,BENHNHAN B where  P.mabn=B.mabn and P.maphieukham= " + txtMaPK_PK.Text);

            }
        }

        private void btnPrint_PK_Click(object sender, EventArgs e)
        {
            string sql = "sp_ChinhSuaPhieuKhamBenh  "+txtMaPK_PK.Text+","+txtMaBN_PK.Text+",N'" +txtHoTen_PK.Text + "', '" + dtNgaySinh_PK.Text + "', N'" + txtDiaChi_PK.Text + "', N'" + cbGioiTinh_PK.Text + "',' " + txtSDT_PK.Text + "', N' " + cbBacSi_PK.Text + "',N' " + cbNhanVien_PK.Text + "'";
           db.UpdateData(sql);
        }

        private void btnSearch_PK_Click(object sender, EventArgs e)
        {
            if(txtSearch_PK.Text == "")
            {
                db.loadData("sp_DanhSachPhieuKham", gvPhieuKham);
            }
            else
            {
                db.loadData("sp_TimKiemPhieuKham '"+ txtSearch_PK.Text + "'", gvPhieuKham);
            }
        }
        private void txtSDT_PK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void txtSearch_PK_TextChanged(object sender, EventArgs e)
        {
            string s = txtHoTen_PK.Text;
            if (s.Length == 0)
            {
                db.loadData("sp_DanhSachPhieuKham", gvPhieuKham);
            }
            else
            {
                db.loadData("sp_TimPhieuKham N'" + s + "'", gvPhieuKham);
            }
        }
        private void dtDateFrom_ValueChanged(object sender, EventArgs e)
        {
            db.loadData("sp_DanhSachPhieuKham '" + dtDateFrom.Text + "','" + dtDateTo.Text + "'", gvPhieuKham);
        }
        private void dtDateTo_ValueChanged(object sender, EventArgs e)
        {
            db.loadData("sp_DanhSachPhieuKham '" + dtDateFrom.Text + "','" + dtDateTo.Text + "'", gvPhieuKham);
        }
    }
}
