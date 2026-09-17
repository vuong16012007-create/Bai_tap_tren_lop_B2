using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    public class GiaoDichTienTe : GiaoDich
    {
        public double TiGia { get; set; }
        public string LoaiTienTe { get; set; }
        public GiaoDichTienTe(string MaGiaoDich, DateTime NgayGiaoDich, double DonGia, int SoLuong, double tiGia, string loaiTienTe)
            : base(MaGiaoDich, NgayGiaoDich, DonGia, SoLuong)
        {
            TiGia = tiGia;
            LoaiTienTe = loaiTienTe;
        }
        public override double ThanhTien()
        {
            if ( LoaiTienTe == "USD" || LoaiTienTe == "Euro")
            {
                return SoLuong * DonGia * TiGia; 
            }
            else if ( LoaiTienTe == "VN")
            {
                return SoLuong * DonGia;
            }
            return 0;
        }
        public override void toString()
        {
            base.toString();
            Console.WriteLine($"   -> [GD Tiền Tệ] Loại: {LoaiTienTe} | Tỉ giá: {TiGia:N0} | Thành tiền: {ThanhTien():N0} VNĐ\n");
        }
    }
}
