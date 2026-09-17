using System;
using System.Collections.Generic;
using System.Text;

namespace bai7
{
    public class Employee : Person
    {
        public double HeSoLuong { get; set; }
        private const double LuongCoBan = 1500000; // Giả sử mức lương cơ bản

        public Employee( string hoTen, string diaChi, double heSoLuong) : base(hoTen, diaChi)
        {
            HeSoLuong = heSoLuong;
        }

        public double TinhLuong() => HeSoLuong * LuongCoBan;

        public override string DanhGia()
        {
            return HeSoLuong >= 3.0 ? "Xuất sắc" : "Tốt";
        }
        public override string ToString()
        {
            return $"[Nhân Viên]  {base.ToString()} | Lương: {TinhLuong():N0} | Đánh giá: {DanhGia()}";
        }
    }
}
