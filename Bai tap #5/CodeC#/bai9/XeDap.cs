using System;
using System.Collections.Generic;
using System.Text;

namespace bai9
{
    public class XeDap : PhuongTien
    {
        public XeDap(string tenXe, double giaTri) : base(tenXe, giaTri) { }

        public override double TinhTienThue()
        {
            return 0; // Xe đạp không đóng thuế
        }

        public override void XuatThongTin()
        {
            Console.Write("[Xe Đạp]     ");
            base.XuatThongTin();
            Console.WriteLine(); 
        }
    }
}
