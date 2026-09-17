using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    public abstract class HangHoa
    {
        public string MaHang { get; set; }
        private string tenHang;
        public string TenHang
        {
            get => tenHang;
            set => tenHang = string.IsNullOrWhiteSpace(value) ? "xxx" : value;
        }
        private double donGia;
        public double DonGia
        {
            get => donGia;
            set => donGia = value >= 0 ? value : 0;
        }
        private int soLuong;
        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value >= 0 ? value : 0;
        }
        public HangHoa( string maHang, string tenHang, double donGia, int soLuong)
        {
            if (string.IsNullOrWhiteSpace(maHang)) throw new Exception("Mã hàng không được rỗng!");
            MaHang = maHang;
            TenHang = tenHang;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public abstract double TinhVAT();
        public abstract string DanhGia();

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Mã: {MaHang} | Tên: {TenHang} | Giá: {DonGia:N0} | Tồn: {SoLuong} | VAT: {TinhVAT():N0} | Đánh giá: {DanhGia()}");
        }
    }
}
