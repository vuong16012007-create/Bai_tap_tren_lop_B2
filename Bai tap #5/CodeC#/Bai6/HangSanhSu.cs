using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    public class HangSanhSu : HangHoa
    {
        public string NhaSanXuat { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public HangSanhSu(string maHang, string tenHang, double donGia, int soLuongTon, string nsx, DateTime ngayNhap)
        : base(maHang, tenHang, donGia, soLuongTon)
        {
            NhaSanXuat = nsx;
            NgayNhapKho = ngayNhap < DateTime.Now ? ngayNhap : DateTime.Now;
        }
        public override double TinhVAT() => DonGia * 0.10;
        public override string DanhGia()
        {
            TimeSpan thoigianluukho = DateTime.Now - NgayNhapKho;
            return (thoigianluukho.TotalDays > 10 && SoLuong > 50) ? "Bán chậm" : "Không đánh giá";
        }
        public override void XuatThongTin()
        {
            Console.Write("[Sành Sứ]   ");
            base.XuatThongTin();
        }
    }
}
