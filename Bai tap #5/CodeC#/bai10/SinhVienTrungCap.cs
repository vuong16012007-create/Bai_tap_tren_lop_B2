using System;
using System.Collections.Generic;
using System.Text;

namespace bai10
{
    public class SinhVienTrungCap : SinhVien
    {
        public int ThoiGianThucTap { get; set; }
        public override void NhapThongTin()
        {
            Console.WriteLine("--- Nhập thông tin SV Trung Cấp ---");
            base.NhapThongTin();
            Console.Write("Nhập thời gian thực tập (tháng): ");
            ThoiGianThucTap = int.Parse(Console.ReadLine());
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($" | Hệ: Trung Cấp | TG Thực tập: {ThoiGianThucTap} tháng");
        }
    }
}
