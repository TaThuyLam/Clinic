using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UngDungQuanLyPhongKham
{
    public partial class frmLapPhieuKham : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VC5O58E8\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
        int mapk;
        PhieuKham phieuKham;
        Database db;
        List<ChitietPhieuDichVu> chitietPhieuDichVus;
        List<ChitietPhieuDichVu> chitietsDaTonTai;
        List<ChitietDonThuoc> chitietDonThuocs;
        List<ChitietDonThuoc> chitietDonTDaTonTais;
        List<iThuoc> thuocs;
        ListViewItem lvitem;

        public frmLapPhieuKham()
        {
            InitializeComponent();
            db = new Database();
        }
        public frmLapPhieuKham(int mapk):this()
        {
            this.phieuKham = db.LayDSPKham().Find(n => n.Maphieukham == mapk);
            dtNgayKham_PK.Text = phieuKham.Ngaykham.ToString();
            txtHoTen_LPK.Text = phieuKham.BenhNhan.TenBN.ToString();
            txtMaPK_PK.Text = phieuKham.Maphieukham.ToString();
            dtNgaySinh_LPK.Text = phieuKham.BenhNhan.NgaySinh;
            cbGioiTinh_LPK.Text = phieuKham.BenhNhan.GioiTinh;
            txtDiaChi_LPK.Text = phieuKham.BenhNhan.DiaChi;
            txtSDT_PK.Text = phieuKham.BenhNhan.SDT;
            txtKhamLamSang.Text = phieuKham.ChuanDoan;
            txtDiUngThuoc.Text = phieuKham.DiUngThuoc;
            txtBenhKemTheo.Text = phieuKham.BenhKemTheo;
        }
        void DSDichVuDung()
        {
            int Stt = 1;
            lvDVChiDinh.Items.Clear();
            foreach (ChitietPhieuDichVu dv in chitietPhieuDichVus)
            {
                lvDVChiDinh.Items.Add(new ListViewItem(new string[] { Stt.ToString(),dv.Tensp,dv.Donvi,dv.Soluong.ToString(),dv.Dongia.ToString(),dv.Thanhtien.ToString(),dv.Phongth }));
                Stt++;
            }
        }
        void DSThuocDung()
        {
            int SttT = 1;
            lvDonThuocChiDinh.Items.Clear();
            foreach (ChitietDonThuoc chitiet in chitietDonThuocs)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(SttT.ToString());
                item.SubItems.Add(chitiet.thuoc.Tenthuoc);
                item.SubItems.Add(chitiet.thuoc.Dvthuoc);
                item.SubItems.Add(chitiet.sang.ToString());
                item.SubItems.Add(chitiet.trua.ToString());
                item.SubItems.Add(chitiet.chieu.ToString());
                item.SubItems.Add(chitiet.toi.ToString());
                item.SubItems.Add(chitiet.sluong.ToString());
                item.SubItems.Add(chitiet.lieudung);
                lvDonThuocChiDinh.Items.Add(item);
                SttT++;
            }
        }
        public void Load_BangDichVu(List<DV> dVs)
        {
            lvDSDichVu.Items.Clear();
            foreach (DV d in dVs)
            {
                lvDSDichVu.Items.Add(new ListViewItem(new string[] { d.ma.ToString(), d.ten, d.dvt, d.phong }));
            }
        }
        public void Load_BangThuoc(List<iThuoc> thuocs)
        {
            lvThuoc.Items.Clear();
            foreach (iThuoc thuoc in thuocs)
            {
                lvThuoc.Items.Add(new ListViewItem(new string[] { thuoc.Mathuoc.ToString(), thuoc.Tenthuoc, thuoc.Dvthuoc, thuoc.Dongiathuoc.ToString() }));
            }
        }
        public void Load_CboxLoaiDV(List<LoaiDichVu> loaiDichVus)
        {
            List<String> list = new List<String>();
            list.Add("Tất cả");
            foreach(LoaiDichVu loaiDichVu in loaiDichVus)
            {
                list.Add(loaiDichVu.tenLoai);
            }
            cbLoaiDichVu.DataSource = list;
        }
        private void frmLapPhieuKham_Load(object sender, EventArgs e)
        {

            Load_BangDichVu(db.LayDSDichVu());
            Load_BangThuoc(db.LayDSThuoc());
            Load_CboxLoaiDV(db.LayDSLoaiDV());
            if (phieuKham!=null)
            {
                // Lấy chi tiết dịch vụ bệnh nhân đã có
                chitietPhieuDichVus = new List<ChitietPhieuDichVu>();
                List<DV> DSDV = db.LayDSDichVu();
                con.Open();
                chitietsDaTonTai = new List<ChitietPhieuDichVu>();
                SqlCommand cmdDVs = new SqlCommand("sp_DanhSachChiTietDichVu " + phieuKham.Maphieukham, con);
                SqlDataReader r = cmdDVs.ExecuteReader();
                while (r.Read())
                {
                    DV dichVu = DSDV.Find(n => n.ma == r.GetInt32(0));
                    ChitietPhieuDichVu chitiet = new ChitietPhieuDichVu(dichVu, r.GetInt32(1), "", "");
                    chitietsDaTonTai.Add(chitiet);
                }
                con.Close();

                // Lấy chi tiết đơn thuốc cỉa bênh nhân đã có
                List<iThuoc> thuocs1 = db.LayDSThuoc();
                con.Open();
                List<ChitietDonThuoc> chitietDonThuocTT = new List<ChitietDonThuoc>();
                SqlCommand command = new SqlCommand("select * from CHITIETDONTHUOC where madonthuoc=" + phieuKham.Maphieukham, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    iThuoc thuoc = thuocs1.Find(n => n.Mathuoc == reader.GetInt32(1));
                    ChitietDonThuoc chitiet = new ChitietDonThuoc(thuoc, reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(8));
                    chitietDonThuocTT.Add(chitiet);
                }
                con.Close();
                if (chitietsDaTonTai.Count != 0)
                {
                    chitietPhieuDichVus = chitietsDaTonTai;
                    DSDichVuDung();
                }
                if(chitietDonThuocTT.Count!=0)
                {
                    chitietDonThuocs = chitietDonThuocTT;
                    DSThuocDung();
                }    
            }
            else
            {
                chitietPhieuDichVus = new List<ChitietPhieuDichVu>();
                chitietDonThuocs = new List<ChitietDonThuoc>();
            }
        
            
        }
      


        private void btnTaiLaiDV_Click(object sender, EventArgs e)
        {
            txtSearchDV.Text = "";
            cbLoaiDichVu.Text = "Tất cả";
        }

        private void lvDSDichVu_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem listViewItem = lvDSDichVu.SelectedItems[0];
            DV dichVu= db.LayDSDichVu().Find(n => n.ten.Contains(listViewItem.SubItems[1].Text));
            ChitietPhieuDichVu chitietPhieuDichVu = new ChitietPhieuDichVu(dichVu, 1, "", "");
            chitietPhieuDichVus.Add(chitietPhieuDichVu);
            DSDichVuDung();
        }


        private void lvDSDichVu_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void btnRedo_DVChiDinh_Click(object sender, EventArgs e)
        {
            chitietPhieuDichVus.Clear();
            DSDichVuDung();

        }

        private void btnXoa_DVCD_Click(object sender, EventArgs e)
        {
            lvitem = lvDVChiDinh.SelectedItems[0];
            ChitietPhieuDichVu chitiet = chitietPhieuDichVus.Find(n => n.Tensp.Contains(lvitem.SubItems[1].Text));
            chitietPhieuDichVus.Remove(chitiet);
            DSDichVuDung();
        }

        private void lvDVChiDinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhatSLDV_Click(object sender, EventArgs e)
        {
            lvitem = lvDVChiDinh.SelectedItems[0];
            ChitietPhieuDichVu chitiet = chitietPhieuDichVus.Find(n => n.Tensp.Contains(lvitem.SubItems[1].Text));
            chitiet.Soluong = Int32.Parse(txtSoLuongDV.Text);
            chitiet.TinhTien();
            DSDichVuDung();
        }

        private void lvDVChiDinh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvitem = lvDVChiDinh.SelectedItems[0];
            ChitietPhieuDichVu chitiet = chitietPhieuDichVus.Find(n => n.Tensp.Contains(lvitem.SubItems[1].Text));
            txtSoLuongDV.Text = chitiet.Soluong.ToString();
        }

        private void btn_LuuThongtinkham_Click(object sender, EventArgs e)
        {
            
            string sql = "sp_CapNhatPhieuKhamBenh  " + txtMaPK_PK.Text + ", N'" + txtKhamLamSang.Text + "', N'" + txtDiUngThuoc.Text + "', N'" + txtBenhKemTheo.Text + "','"+dtNgayKham_PK.Text+"'";
             db.UpdateData(sql);
        }

        private void btnLuuPhieuDV_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("sp_XoaChiTietDichVu  " + phieuKham.Maphieukham, con);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            foreach (ChitietPhieuDichVu chitiet in chitietPhieuDichVus)
            {
                string sql = "sp_ThemChiTietDichVu  " + phieuKham.Maphieukham + "," + chitiet.DV.ma + ", " + chitiet.Soluong;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                    break;
                }
               
            }
            con.Close();
            MessageBox.Show("Cập nhật thành công!");
            this.Refresh();
        }

        private void lvThuoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvitem = lvThuoc.SelectedItems[0];
            iThuoc thuoc = db.LayDSThuoc().Find(n => n.Mathuoc.ToString().Contains(lvitem.SubItems[0].Text));
            ChitietDonThuoc ctthuoc = new ChitietDonThuoc(thuoc, 1, 1, 1, 1, 4, "");
            if (chitietDonThuocs == null)
            {
                chitietDonThuocs = new List<ChitietDonThuoc>();
            }
            if(chitietDonThuocs.Find(n => n.thuoc.Mathuoc.ToString().Contains(lvitem.SubItems[0].Text))==null)
                {
                    chitietDonThuocs.Add(ctthuoc);
            }
           
            DSThuocDung();
        }

        private void btn_Refresh_DT_Click(object sender, EventArgs e)
        {
            chitietDonThuocs.Clear();
            DSThuocDung();
        }

        private void btn_Delete_DT_Click(object sender, EventArgs e)
        {
            lvitem = lvDonThuocChiDinh.SelectedItems[0];
            ChitietDonThuoc chitiet = chitietDonThuocs.Find(n => n.thuoc.Tenthuoc.Contains(lvitem.SubItems[2].Text));
            chitietDonThuocs.Remove(chitiet);
            DSThuocDung();
        }

        private void btn_Save_DT_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("sp_XoaChiTietDonThuoc  " + phieuKham.Maphieukham, con);
                sqlCommand.ExecuteNonQuery();

                sqlCommand= new SqlCommand("sp_CapNhatSoNgayThuoc  " + phieuKham.Maphieukham+", "+txtSoNgayThuoc.Text , con);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            foreach (ChitietDonThuoc chitiet in chitietDonThuocs)
            {
                string sql = "sp_ThemChiTietDonThuoc  " + phieuKham.Maphieukham + "," + chitiet.thuoc.Mathuoc + ", " + chitiet.sang + ", " + chitiet.trua + ", " + chitiet.chieu + ", " + chitiet.toi + ", " + chitiet.sluong + ",N' " + chitiet.lieudung+"'";
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                    break;
                }

            }
            con.Close();
            this.Refresh();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void lvDonThuocChiDinh_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvitem = lvDonThuocChiDinh.SelectedItems[0];
            ChitietDonThuoc chitiet = chitietDonThuocs.Find(n => n.thuoc.Tenthuoc.Contains(lvitem.SubItems[2].Text));
            txtSang.Text = chitiet.sang.ToString();
            txtTrua.Text = chitiet.trua.ToString();
            txtChieu.Text = chitiet.chieu.ToString();
            txtToi.Text = chitiet.toi.ToString();
            txtLieuDung.Text = chitiet.lieudung.ToString();
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            if (lvDonThuocChiDinh.SelectedItems.Count > 0)
            {
                ListViewItem lvitem = lvDonThuocChiDinh.SelectedItems[0];
                ChitietDonThuoc chitiet = chitietDonThuocs.Find(n => n.thuoc.Tenthuoc.Contains(lvitem.SubItems[2].Text));
                chitiet.sang = int.Parse(txtSang.Text);
                chitiet.trua = int.Parse(txtTrua.Text);
                chitiet.chieu = int.Parse(txtChieu.Text);
                chitiet.toi = int.Parse(txtToi.Text);
                chitiet.lieudung = txtLieuDung.Text;
                chitiet.CapNhatSoLuong();
                DSThuocDung();
            }
        }

        private void btnHuyUp_Click(object sender, EventArgs e)
        {
            if(lvDonThuocChiDinh.SelectedItems.Count>0)
            {
                ListViewItem lvitem = lvDonThuocChiDinh.SelectedItems[0];
                ChitietDonThuoc chitiet = chitietDonThuocs.Find(n => n.thuoc.Tenthuoc.Contains(lvitem.SubItems[2].Text));
                txtSang.Text = chitiet.sang.ToString();
                txtTrua.Text = chitiet.trua.ToString();
                txtChieu.Text = chitiet.chieu.ToString();
                txtToi.Text = chitiet.toi.ToString();
                txtLieuDung.Text = chitiet.lieudung.ToString();
            }    
          
        }

        private void cbLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DV> dVs = new List<DV>();
            if(cbLoaiDichVu.SelectedItem.ToString().Contains("Tất cả"))
            {
                dVs = db.LayDSDichVu();
            }  
            else
            {
                foreach (DV dV in db.LayDSDichVu())
                {
                    if (dV.loaiDV.Contains(cbLoaiDichVu.SelectedItem.ToString()))
                    {
                        dVs.Add(dV);
                    }
                }
            }    
          
            Load_BangDichVu(dVs);

        }

        private void txtSearchDV_TextChanged(object sender, EventArgs e)
        {
            List<DV> dVs = new List<DV>();
            foreach (DV dV in db.LayDSDichVu())
            {
                if (dV.ten.ToLower().Contains(txtSearchDV.Text.ToLower()))
                {
                    dVs.Add(dV);
                }
            }
            Load_BangDichVu(dVs);
        }

        private void txtSearchTenThuoc_TextChanged(object sender, EventArgs e)
        {
            List<iThuoc> thuocs = new List<iThuoc>();
            foreach (iThuoc thuoc in db.LayDSThuoc())
            {
                if (thuoc.Tenthuoc.ToLower().Contains(txtSearchThuoc.Text.ToLower()))
                {
                    thuocs.Add(thuoc);
                }
            }
            Load_BangThuoc(thuocs);
        }

        private void btn_Refresh_Thuoc_Click(object sender, EventArgs e)
        {
            txtSearchThuoc.Text = "";
            Load_BangThuoc(db.LayDSThuoc());
        }
    }
    
}
