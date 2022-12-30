using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class BenhNhan
    {
        public BenhNhan()
        {

        }
        public BenhNhan(int maBN, string tenBN, string ngaySinh, string diaChi, string gioiTinh, string sDT)
        {
            MaBN = maBN;
            TenBN = tenBN;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            SDT = sDT;
        }   

        public int MaBN { get; set; }
        public string TenBN { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
    }
}
