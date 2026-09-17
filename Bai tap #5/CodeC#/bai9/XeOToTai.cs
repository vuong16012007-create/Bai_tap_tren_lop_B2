using System;
using System.Collections.Generic;
using System.Text;

namespace bai9
{
    public class XeOToTai : PhuongTien
    {
        public XeOToTai(string tenXe, double giaTri) : base(tenXe, giaTri) { }

        public override double TinhTienThue()
        {
            // VAT 10% + Trước bạ 2% = 12% (0.12)
            return GiaTri * 0.12;
        }
        public override void XuatThongTin()
        {
            Console.Write("[Ô Tô Tải]   ");
            base.XuatThongTin();
            Console.WriteLine();
        }
    }
}
