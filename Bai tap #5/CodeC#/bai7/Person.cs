using System;
using System.Collections.Generic;
using System.Text;

namespace bai7
{
    public abstract class Person
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public Person(string hoTen, string diaChi)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
        }

        public abstract string DanhGia();
        public override string ToString()
        {
            return $"Họ tên: {HoTen,-15} | Địa chỉ: {DiaChi,-10}";
        }
    }
}
