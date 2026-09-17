using System;
using System.Collections.Generic;
using System.Text;

namespace bai9
{
    public abstract class PhuongTien
    {
        public string TenXe { get; set; }
        public double GiaTri { get; set; }

        public PhuongTien(string tenXe, double giaTri)
        {
            TenXe = tenXe;
            GiaTri = giaTri;
        }

        public abstract double TinhTienThue();

        public virtual void XuatThongTin()
        {
            Console.Write($"Tên xe: {TenXe,-15} | Giá trị: {GiaTri,12:N0} VNĐ | Thuế: {TinhTienThue(),12:N0} VNĐ");
        }
    }
}
