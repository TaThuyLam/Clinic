using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class ChitietDonThuoc
    {

        public iThuoc thuoc;
        public int sang;
        public int trua;
        public int chieu;
        public int toi;
        public int sluong;
        public double thanhtien;
        public string lieudung;

        public ChitietDonThuoc(iThuoc thuoc, int sang, int trua, int chieu, int toi, int sluong, string lieudung)
        {
            this.thuoc = thuoc;
            this.sang = sang;
            this.trua = trua;
            this.chieu = chieu;
            this.toi = toi;
            this.sluong = sang +trua+chieu+toi;
           // this.thanhtien = thuoc.Dongiathuoc*sluong*1.0;
            this.lieudung = lieudung;
        }

        public void CapNhatSoLuong()
        {
            sluong = sang + trua + chieu + toi;
        }
    }
}
