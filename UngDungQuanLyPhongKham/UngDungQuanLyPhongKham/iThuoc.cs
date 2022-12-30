using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyPhongKham
{
    public class iThuoc
    {
       public iThuoc()
        { }
      public iThuoc(int mathuoc, string tenthuoc, string dvthuoc, double dongiathuoc)
        {
            Mathuoc = mathuoc;
            Tenthuoc = tenthuoc;
            Dvthuoc = dvthuoc;
            Dongiathuoc = dongiathuoc;
        }

        public int Mathuoc { get; set; }
        public string Tenthuoc { get; set; }
        public string Dvthuoc { get; set; }
        public double Dongiathuoc { get; set; }
    }
}
