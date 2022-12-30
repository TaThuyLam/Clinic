using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyPhongKham
{
    public class Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VC5O58E8\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
        public Database()
        {

        }
        public List<DV> LayDSDichVu()
        {
            List<DV> dichVus = new List<DV>();
            con.Open();
            SqlCommand cmdDVs = new SqlCommand("sp_DanhSachDichVu", con);
            SqlDataReader readDVs = cmdDVs.ExecuteReader();
            while (readDVs.Read())
            {
                DV dichVu = new DV();
                dichVu = new DV(readDVs.GetInt32(0), readDVs.GetString(1), readDVs.GetInt32(2), readDVs.GetString(3), readDVs.GetString(4), readDVs.GetString(5));
                dichVus.Add(dichVu);
            }
            con.Close();
            return dichVus;
        }
        public List<LoaiDichVu> LayDSLoaiDV()
        {
            List<LoaiDichVu> loaiDichVus = new List<LoaiDichVu>();
            con.Open();
            SqlCommand cmdloai = new SqlCommand("select * from LOAIDICHVU", con);
            SqlDataReader reader = cmdloai.ExecuteReader();
            while (reader.Read())
            {
                LoaiDichVu loai = new LoaiDichVu();
                loai = new LoaiDichVu(reader.GetInt32(0), reader.GetString(1));
                loaiDichVus.Add(loai);
            }
            con.Close();
            return loaiDichVus;
        }
        public List<iThuoc> LayDSThuoc()
        {
            List<iThuoc> thuocs = new List<iThuoc>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from THUOC", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                iThuoc thuoc = new iThuoc();
                thuoc = new iThuoc(reader.GetInt32(0), reader.GetString(1), reader.GetString(3), reader.GetDouble(2));
                thuocs.Add(thuoc);
            }
            con.Close();
            return thuocs;
        }
        public List<NhanVien> LayDSNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from NHANVIEN", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien = new NhanVien(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                nhanViens.Add(nhanVien);
            }
            con.Close();
            return nhanViens;
        }
        public List<PhieuKham> LayDSPKham()
        {
            List<PhieuKham> phieuKhams = new List<PhieuKham>();
            con.Open();
            SqlCommand cmdpks = new SqlCommand("sp_LayDanhSachPhieuKham", con);
            SqlDataReader reader = cmdpks.ExecuteReader();
            while (reader.Read())
            {
                PhieuKham phieu = new PhieuKham();
                phieu.Maphieukham = reader.GetInt32(0);
                phieu.Ngaykham = reader.GetDateTime(2);
                phieu.TenBS = reader.GetString(3);
                phieu.TenNV = reader.GetString(4);
                phieu.ChuanDoan = reader.GetString(5);
                phieu.BenhKemTheo = reader.GetString(6);
                phieu.DiUngThuoc = reader.GetString(7);
                phieu.BenhNhan = new BenhNhan(reader.GetInt32(9), reader.GetString(10), reader.GetDateTime(11).ToString(), reader.GetString(12), reader.GetString(13), reader.GetString(14));
                phieuKhams.Add(phieu);

            }
            con.Close();
            return phieuKhams;
        }

        public void loadData(string sql,DataGridView dataGridView)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand com = new SqlCommand(sql, con);
            adapter.SelectCommand = com;
            adapter.Fill(table);
            dataGridView.DataSource = table;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void sqlToComboBox(string sql, ComboBox combo)
        {
            List<string> strings = new List<string>();
            con.Open();
            SqlCommand sqlCom = new SqlCommand(sql, con);
            SqlDataReader reader = sqlCom.ExecuteReader();
            while (reader.Read())
            {
                strings.Add(reader.GetString(0));
            }
            combo.DataSource = strings;
            con.Close();
        }
        public string GetStringBySql(string sql)
        {
            string str = "";
            con.Open();
            try
            {
                SqlCommand sqlCom = new SqlCommand(sql, con);
                
                SqlDataReader reader = sqlCom.ExecuteReader();
                while (reader.Read())
                {
                    str = reader.GetString(0);
                    break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return str;

        }
        public int GetIntBySql(string sql)
        {
            int str =0;
            con.Open();
            try
            {
                SqlCommand sqlCom = new SqlCommand(sql, con);

                SqlDataReader reader = sqlCom.ExecuteReader();
                while (reader.Read())
                {
                    str = reader.GetInt32(0);
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return str;

        }
        public void UpdateData(string sql)
        {
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
                con.Close();
            
        }
    }
}
