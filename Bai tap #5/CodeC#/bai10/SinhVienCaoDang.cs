using System;
using System.Collections.Generic;
using System.Text;

namespace bai10
{
    public class SinhVienCaoDang : SinhVien
    {
        public double DiemThiTotNghiep { get; set; }

        public override void NhapThongTin()
        {
            Console.WriteLine("--- Nhập thông tin SV Cao Đẳng ---");
            base.NhapThongTin();
            Console.Write("Nhập điểm thi tốt nghiệp: ");
            DiemThiTotNghiep = double.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($" | Hệ: Cao Đẳng    | Điểm TN: {DiemThiTotNghiep}");
        }
    }
}
