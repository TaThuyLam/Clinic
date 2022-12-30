using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class NhanVien
    {
        public int maNV;
        public string hoten;
        public string trinhdo;
        public string chuyenmon;
        public string chucvu;
        public string taikhoan;
        public string matkhau;
        public NhanVien()
        {

        }
        public NhanVien(int maNV,string hoten,string trinhdo,string chuyenmon, string chucvu, string taikhoan, string matkhau)
        {
            this.maNV = maNV;
            this.trinhdo = trinhdo;
            this.chuyenmon = chuyenmon;
            this.chucvu = chucvu;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.hoten = hoten;
        }
    }
}
