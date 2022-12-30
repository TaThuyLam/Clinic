using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace UngDungQuanLyPhongKham
{
    public class DV
    {
        public DV() { }
        public DV(int ma, string ten,string dvt,string phong) {

            this.ma = ma;
            this.ten = ten;
            this.dvt = dvt;
            this.phong = phong;
        }
        public DV(int ma, string ten,  int dongia,string dvt, string loaiDV, string phong)
        {
            this.ma = ma;
            this.ten = ten;
            this.dvt = dvt;
            this.dongia = dongia;
            this.phong = phong;
            this.loaiDV = loaiDV;
        }
    
        public int ma { get; set; }
        public string ten { get; set; }
        public string dvt { get; set; }
        public int dongia { get; set; }
        public string loaiDV { get; set; }
        public string phong { get; set; }



    }
}
