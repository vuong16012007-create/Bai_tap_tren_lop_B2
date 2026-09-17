using System;
using System.Collections.Generic;
using System.Text;

namespace bai7
{
    public class Customer : Person
    {
        public string TenCongTy { get; set; }
        public double TriGiaDonHang { get; set; }
        public Customer(string hoTen, string diaChi, string tenCongTy, double triGiaDonHang)
            : base(hoTen, diaChi)
        {
            TenCongTy = tenCongTy;
            TriGiaDonHang = triGiaDonHang;
        }
        public override string DanhGia()
        {
            return TriGiaDonHang >= 10000000 ? "Khách hàng VIP" : "Khách hàng thường";
        }

        public override string ToString()
        {
            return $"[Khách Hàng] {base.ToString()} | Công ty: {TenCongTy,-10} | Hóa đơn: {TriGiaDonHang:N0} | Đánh giá: {DanhGia()}";
        }
    }
}
