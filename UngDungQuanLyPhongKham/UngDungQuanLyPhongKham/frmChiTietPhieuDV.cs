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
    public partial class frmChiTietPhieuDV : Form
    {
        int maphieu;
        Database db;
        public frmChiTietPhieuDV(int maphieu)
        {
            InitializeComponent();
            db = new Database();
            this.maphieu = maphieu;
        }

        private void frmChiTietPhieuDV_Load(object sender, EventArgs e)
        {
            db.loadData("sp_DanhSachChiTietPhieuDichVu " + maphieu,gvChiTietDVDung);
            txtTC_PDV.Text = db.GetIntBySql("select tongcong from PHIEUDICHVU where maphieukham= " + maphieu).ToString();
        }

        private void btnCancelDV_TT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTTDV_OK_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_XacNhanPhieuDVTT " + maphieu);
        }
    }
}
