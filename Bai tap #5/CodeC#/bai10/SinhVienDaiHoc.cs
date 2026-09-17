using System;
using System.Collections.Generic;
using System.Text;

namespace bai10
{
    public class SinhVienDaiHoc : SinhVien
    {
        public string TenLuanVan { get; set; }

        public override void NhapThongTin()
        {
            Console.WriteLine("--- Nhập thông tin SV Đại Học ---");
            base.NhapThongTin();
            Console.Write("Nhập tên luận văn: ");
            TenLuanVan = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($" | Hệ: Đại Học   | Luận văn: {TenLuanVan}");
        }
    }
}
