using System;
using System.Collections.Generic;
using System.Text;

namespace bai10
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập Mã SV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();
        }

        public virtual void HienThiThongTin()
        {
            Console.Write($"Mã SV: {MaSV,-10} | Họ tên: {HoTen,-20}");
        }
    }
}
