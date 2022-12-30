using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class PhieuKham
    {
        public PhieuKham() { }
        public PhieuKham(int maphieukham, int mabenhnhan, DateTime ngaykham, string tenBS, string tenNV)
        {
            Maphieukham = maphieukham;
            Mabenhnhan = mabenhnhan;
            Ngaykham = ngaykham;
            TenBS = tenBS;
            TenNV = tenNV;
        }
    
        public PhieuKham(int maphieukham, DateTime ngaykham, string tenBS, string tenNV, BenhNhan benhNhan) 
        {
            BenhNhan = benhNhan;
            Maphieukham = maphieukham;
            Mabenhnhan = benhNhan.MaBN;
            Ngaykham = ngaykham;
            TenBS = tenBS;
            TenNV = tenNV;
        }
        public PhieuKham(int maphieukham, DateTime ngaykham, string tenBS, string tenNV, string chuanDoan, string benhKemTheo, string diUngThuoc,DateTime ngayTaiKham, BenhNhan benhNhan) 
        {
            BenhNhan = benhNhan;
            Maphieukham = maphieukham;
            Mabenhnhan = benhNhan.MaBN;
            Ngaykham = ngaykham;
            TenBS = tenBS;
            TenNV = tenNV;
            ChuanDoan = chuanDoan;
            BenhKemTheo = benhKemTheo;
            DiUngThuoc = diUngThuoc;
            BenhNhan = benhNhan;
            NgayTaiKham = ngayTaiKham;
        }

        public int Maphieukham { get; set; }
        public int Mabenhnhan { get; set; }
        public DateTime Ngaykham { get; set; }
        public string TenBS { get; set; }
        public string TenNV { get; set; }
        public string ChuanDoan { get; set; }
        public string BenhKemTheo { get; set; }
        public string DiUngThuoc { get; set; }
        public BenhNhan BenhNhan { get; set; }
        public DateTime NgayTaiKham { get; set; }
    }
}
