using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class ChitietPhieuDichVu
    {

        public ChitietPhieuDichVu(DV dV, int soluong, string trangthai, string ketqua)
        {
            Tensp = dV.ten;
            Dongia = dV.dongia;
            Donvi = dV.dvt;
            Soluong = soluong;
            Trangthai = trangthai;
            Ketqua = ketqua;
            Thanhtien = Soluong * Dongia;
            Phongth = dV.phong;
            this.DV = dV;
        }

        public DV DV { get; set; }
        public string Tensp { get;set; }
        public int Dongia { get; set; }
        public string Donvi { get; set; }
        public int Soluong { get; set; }
        public string Trangthai { get; set; }
        public string Ketqua { get; set; }
        public string Phongth { get; set; }
        public int Thanhtien { get; set; }
        public int MaDV { get; set; }

        public void TinhTien()
        {
            Thanhtien = Dongia * Soluong;
        }
    }
}
