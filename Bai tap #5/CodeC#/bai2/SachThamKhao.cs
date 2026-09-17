using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    public class SachThamKhao : Sach
    {
        public double Thue {  get; set; }
        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }
        public override double TinhThanhTien()
        {
            return Thue * SoLuong * DonGia;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"   -> [STK] Thuế: {Thue:N0} | Thành tiền: {TinhThanhTien():N0} VNĐ\n");
        }
    }
}
