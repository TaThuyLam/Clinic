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
    public partial class frmQLThanhToan : Form
    {
        Database db;
        public frmQLThanhToan()
        {
            InitializeComponent();
            db=new Database();
        }

        private void frmQLThanhToan_Load(object sender, EventArgs e)
        {
            db.loadData("sp_DanhSachPhieuDichVuChuaTT", gvPK_TT);
            db.loadData("sp_DanhSachDonThuocChuaTT", gvDT_PK);
        }

        private void gvDT_PK_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gvDT_PK.Rows[e.RowIndex];
                Form form = new frmChiTietDonThuoc(int.Parse(row.Cells[0].Value.ToString()));
                form.Show();
            }
        }

        private void gvPK_TT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gvPK_TT.Rows[e.RowIndex];
                Form form = new frmChiTietPhieuDV(int.Parse(row.Cells[0].Value.ToString()));
                form.Show();
            }
        }

        private void txtSearchPDV_TT_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchPDV_TT.Text=="")
            {
                db.loadData("sp_DanhSachPhieuDichVuChuaTT", gvPK_TT);
            }
            else
            {
                db.loadData("sp_TimPhieuDichVuChuaTT "+ txtSearchPDV_TT.Text, gvPK_TT);
            }

        }

        private void txtSearchDT_TT_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchDT_TT.Text == "")
            {
                db.loadData("sp_DanhSachDonThuocChuaTT", gvDT_PK);
            }
            else
            {
                db.loadData("sp_TimDonThuocChuaTT "+ txtSearchDT_TT.Text, gvDT_PK);
            }
           

        }
    }
}
