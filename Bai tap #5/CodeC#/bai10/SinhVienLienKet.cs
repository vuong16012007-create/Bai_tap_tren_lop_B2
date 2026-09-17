using System;
using System.Collections.Generic;
using System.Text;

namespace bai10
{
    public class SinhVienLienKet : SinhVien
    {
        public string QuocGia { get; set; }
        public double DiemIELTS { get; set; }

        public override void NhapThongTin()
        {
            Console.WriteLine("--- Nhập thông tin SV Liên Kết ---");
            base.NhapThongTin();
            Console.Write("Nhập Quốc gia liên kết (Australia/US): ");
            QuocGia = Console.ReadLine();
            Console.Write("Nhập điểm IELTS: ");
            DiemIELTS = double.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($" | Hệ: Liên Kết ({QuocGia}) | IELTS: {DiemIELTS}");
        }
    }
}
