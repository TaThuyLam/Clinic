using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class DonThuoc
    {
        public int madonthuoc;
        public int maphieukham;
        public int songaythuoc;
        public double tongcong;
        public string ghichu;
        public bool trangthaitt;

        public DonThuoc(int madonthuoc, int maphieukham, int songaythuoc, double tongcong, string ghichu, bool trangthaitt)
        {
            this.madonthuoc = madonthuoc;
            this.maphieukham = maphieukham;
            this.songaythuoc = songaythuoc;
            this.tongcong = tongcong;
            this.ghichu = ghichu;
            this.trangthaitt = trangthaitt;
        }
    }
}
