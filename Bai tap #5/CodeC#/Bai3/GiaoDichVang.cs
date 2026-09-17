using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    internal class GiaoDichVang : GiaoDich
    {
        public string LoaiVang {  get; set; }
        public GiaoDichVang (string MaGiaoDich, DateTime NgayGiaoDich, double DonGia, int SoLuong, string LoaiVang)
            : base(MaGiaoDich, NgayGiaoDich, DonGia, SoLuong)
        {
            this.LoaiVang = LoaiVang;
        }
        public override double ThanhTien()
        {
            return SoLuong * DonGia;
        }
        public override void toString()
        {
            base.toString();
            Console.WriteLine($"   -> [GD Vàng] Loại: {LoaiVang} | Thành tiền: {ThanhTien():N0} VNĐ\n");
        }
    }
}
