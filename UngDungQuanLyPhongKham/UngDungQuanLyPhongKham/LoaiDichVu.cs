using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class LoaiDichVu
    {
        public LoaiDichVu()
        { }
        public LoaiDichVu(int maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
        }
        public int maLoai { get; set; }
        public string tenLoai { get; set; }
    }
}
