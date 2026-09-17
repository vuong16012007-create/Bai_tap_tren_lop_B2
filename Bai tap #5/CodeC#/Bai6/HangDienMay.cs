using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    public  class HangDienMay : HangHoa
    {
        public int ThoiGianBaoHanh { get; set; }
        public double CongSuat { get; set; }

        public HangDienMay(string maHang, string tenHang, double donGia, int soLuongTon, int baoHanh, double congSuat)
            : base(maHang, tenHang, donGia, soLuongTon)
        {
            ThoiGianBaoHanh = baoHanh >= 0 ? baoHanh : 0;
            CongSuat = congSuat >= 0 ? congSuat : 0;
        }
        public override double TinhVAT() => DonGia * 0.10;

        public override string DanhGia() => SoLuong < 3 ? "Bán được" : "Không đánh giá";

        public override void XuatThongTin()
        {
            Console.Write("[Điện Máy]  ");
            base.XuatThongTin();
        }
    }
}
