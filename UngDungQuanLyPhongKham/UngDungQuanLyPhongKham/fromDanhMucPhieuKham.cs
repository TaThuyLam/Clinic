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
    public partial class fromDanhMucPhieuKham : Form
    {
        Database db;
        public fromDanhMucPhieuKham()
        {
            InitializeComponent();
            db=new Database();
        }

        private void fromDanhMucPhieuKham_Load(object sender, EventArgs e)
        {
            db.loadData("sp_LayDanhSachPhieuKhamChuaKham", gvChuaKham);
            db.loadData("sp_LayDanhSachTatCa", gvTraCuu);
        }

        private void gvTraCuu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gvTraCuu.Rows[e.RowIndex];
                frmMain frm = new frmMain();
                frm.Hide();
                frmLapPhieuKham frmLapPhieuKham = new frmLapPhieuKham(int.Parse(row.Cells[0].Value.ToString()));
                frm.Nav(frmLapPhieuKham);
                this.Controls.Clear();
                this.Controls.Add(frmLapPhieuKham);
            }
           

        }

        private void gvChuaKham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gvChuaKham.Rows[e.RowIndex];
                frmMain frm = new frmMain();
                frm.Hide();
                frmLapPhieuKham frmLapPhieuKham = new frmLapPhieuKham(int.Parse(row.Cells[0].Value.ToString()));
                frm.Nav(frmLapPhieuKham);
                this.Controls.Clear();
                this.Controls.Add(frmLapPhieuKham);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                db.loadData("sp_LayDanhSachTatCa", gvTraCuu);
            }   
            else
            db.loadData("sp_LayDanhSachPKTheoTenBN "+textBox1.Text, gvTraCuu);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            db.loadData("sp_LayDanhSachPKTheoNgayK '" + dateTimePicker1.Text+"'", gvTraCuu);
        }
    }
}
