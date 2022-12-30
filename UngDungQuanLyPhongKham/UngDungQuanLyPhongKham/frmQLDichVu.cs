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
    public partial class frmQLDichVu : Form
    {
        Database db;
        public frmQLDichVu()
        {
            InitializeComponent();
           db = new Database();
        }

        private void frmQLDichVu_Load(object sender, EventArgs e)
        {
            
            txtMaDV_A.Text = "";
            txtTenDV_A.Text = "";
            txtGiaDV_A.Text = "";
            txtSearchDV_A.Text = "";
            try
            {
                db.loadData("sp_DanhSachDichVu", gv_DichVuA);
                db.sqlToComboBox("select tenloaidv from LOAIDICHVU", cbLoaiDV_A);
                db.sqlToComboBox("select tenphong from PHONG", cbPhongDV_A);
                List<string> donvi = new List<string>() { "Lần", "Mũi" };
                cbDonViDV_A.DataSource = donvi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gv_DichVuA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gv_DichVuA.Rows[e.RowIndex];
                txtMaDV_A.Text = row.Cells[0].Value.ToString();
                txtTenDV_A.Text = row.Cells[1].Value.ToString();
                txtGiaDV_A.Text = row.Cells[2].Value.ToString();
                cbDonViDV_A.Text = row.Cells[3].Value.ToString();
                cbLoaiDV_A.Text = row.Cells[4].Value.ToString();
                cbPhongDV_A.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnAddDV_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_AddDichVu N'" + txtTenDV_A.Text + "', " + txtGiaDV_A.Text + ", N'" + cbDonViDV_A.Text + "', N'" + cbLoaiDV_A.Text + "', N'" + cbPhongDV_A.Text+"'");
            db.loadData("sp_DanhSachDichVu", gv_DichVuA);
        }

        private void btnCancelDV_A_Click(object sender, EventArgs e)
        {
            frmQLDichVu_Load(sender, e);
        }

        private void btnDeleteDV_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_XoaDichVu " + txtMaDV_A.Text);
            db.loadData("sp_DanhSachDichVu", gv_DichVuA);
        }

        private void btnPrintVD_A_Click(object sender, EventArgs e)
        {
            db.UpdateData("sp_ChinhSuaDichVu " + txtMaDV_A.Text + ", N'" + txtTenDV_A.Text + "', " + txtGiaDV_A.Text + ", N'" + cbDonViDV_A.Text + "', N'" + cbLoaiDV_A.Text + "', N'" + cbPhongDV_A.Text + "'");
            db.loadData("sp_DanhSachDichVu", gv_DichVuA);
        }

        

        private void txtGiaDV_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSearchDV_A_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearchDV_A.Text;
            if( s.Length==0)
            {
                db.loadData("sp_DanhSachDichVu", gv_DichVuA);
            }  
            else
            {
                db.loadData("sp_TimKiemDichVu N'" + s + "'", gv_DichVuA);
            }    
            
        }
    }
}
