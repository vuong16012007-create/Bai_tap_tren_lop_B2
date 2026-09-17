using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    public abstract class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public GiaoDich (string MaGiaoDich, DateTime NgayGiaoDich, double DonGia, int SoLuong)
        {
            this.MaGiaoDich = MaGiaoDich;
            this.NgayGiaoDich = NgayGiaoDich;
            this.DonGia = DonGia;
            this.SoLuong = SoLuong;
        }

        public abstract double ThanhTien();

        public virtual void toString()
        {
            Console.WriteLine($"Mã GD: {MaGiaoDich} | Ngày: {NgayGiaoDich:dd/MM/yyyy} | Đơn giá: {DonGia:N0} | SL: {SoLuong}");
        }
    }
}
