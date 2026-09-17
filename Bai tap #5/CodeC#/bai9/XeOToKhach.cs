using System;
using System.Collections.Generic;
using System.Text;

namespace bai9
{
    public class XeOToKhach : PhuongTien
    {
        public int SoCho { get; set; }

        public XeOToKhach(string tenXe, double giaTri, int soCho) : base(tenXe, giaTri)
        {
            SoCho = soCho;
        }

        public override double TinhTienThue()
        {
            double vat = 0.10;
            double truocBa = 0.20;

            // Dùng toán tử 3 ngôi: Nếu Số chỗ >= 5 thì 30% (0.3), ngược lại là 50% (0.5)
            double tieuThuDacBiet = SoCho >= 5 ? 0.30 : 0.50;

            // Tổng thuế = Giá trị * (VAT + Trước bạ + Tiêu thụ đặc biệt)
            return GiaTri * (vat + truocBa + tieuThuDacBiet);
        }

        public override void XuatThongTin()
        {
            Console.Write("[Ô Tô Khách] ");
            base.XuatThongTin();
            Console.WriteLine($" | Số chỗ: {SoCho}");
        }
    }
}
