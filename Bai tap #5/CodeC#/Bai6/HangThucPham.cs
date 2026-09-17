using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Serialization;

namespace Bai6
{
    public class HangThucPham : HangHoa
    {
        public string NhaCungCap;
        private DateTime ngaySanXuat;
        public DateTime NgaySanXuat
        {
            get => ngaySanXuat;
            set => ngaySanXuat = value < DateTime.Now ? value : DateTime.Now;
        }
        private DateTime ngayHetHan;
        public DateTime NgayHetHan
        {
            get => ngayHetHan;
            set => ngayHetHan = value > NgaySanXuat ? value : NgaySanXuat;
        }
        public HangThucPham(string maHang, string tenHang, double donGia, int soLuongTon, string ncc, DateTime nsx, DateTime nhh)
        : base(maHang, tenHang, donGia, soLuongTon)
        {
            NhaCungCap = ncc;
            NgaySanXuat = nsx;
            NgayHetHan = nhh; // Gọi set để kiểm tra điều kiện
        }

        public override double TinhVAT()
        {
            return DonGia * 0.05;
        }
        public override string DanhGia()
        {
            return (SoLuong > 0 && NgayHetHan < DateTime.Now) ? "Khó bán" : "Không đánh giá";
        }
        public override void XuatThongTin()
        {
            Console.Write("[Thực phẩm] ");
            base.XuatThongTin();
        }
    }
}
