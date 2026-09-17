using System;
using System.Collections.Generic;
using System.Linq;
namespace bai2
{
    public abstract class Sach
    {
        public string MaSach { get; set; }
        public DateTime NgayNhap { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string NhaXuatBan { get; set; }
        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            SoLuong = soLuong;
            NhaXuatBan = nhaXuatBan;
        }
        public abstract double TinhThanhTien();
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Mã: {MaSach} | Nhập: {NhaXuatBan: dd/MM/yyyy} | NXB: {NhaXuatBan} | Giá: {DonGia} | SL: {SoLuong} {DonGia}");

        }
        
    }
}
