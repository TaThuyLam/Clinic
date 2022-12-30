using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class Phong
    {
        public Phong(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        int ma { get; set; }
        string ten { get; set; }
    }
}
