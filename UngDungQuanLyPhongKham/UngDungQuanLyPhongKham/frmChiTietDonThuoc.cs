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
    public partial class frmChiTietDonThuoc : Form
    {
        int mapk;
        Database db;
        public frmChiTietDonThuoc(int mapk)
        {
            InitializeComponent();
            this.mapk = mapk;
            db=new Database();
        }

        private void frmChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            db.loadData("sp_DanhSachChiTietDonThuoc " + mapk, gvChiTietDTDung);
        }

        private void btnTTDT_OK_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_XacNhanDonThuocTT " + mapk);
            this.Close();
        }

        private void btnCancelDT_TT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietDonThuoc_Load_1(object sender, EventArgs e)
        {
            db.loadData("sp_DanhSachChiTietDonThuoc " + mapk, gvChiTietDTDung);
            txtSoNgayThuoc.Text = db.GetIntBySql("select songaythuoc from DONTHUOC where maphieukham= " + mapk).ToString();
            txtTC_DT.Text = db.GetIntBySql("select tongcong from DONTHUOC where maphieukham= " + mapk).ToString();
        }
    }
}
