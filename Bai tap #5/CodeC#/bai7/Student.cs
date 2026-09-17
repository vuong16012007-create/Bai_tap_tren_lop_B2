using System;
using System.Collections.Generic;
using System.Text;

namespace bai7
{
    public class Student : Person
    {
        public double MonHoc1 { get; set; }
        public double MonHoc2 { get; set; }

        public Student(string hoTen, string diaChi, double monHoc1, double monHoc2)
            : base(hoTen, diaChi)
        {
            MonHoc1 = monHoc1;
            MonHoc2 = monHoc2;
        }

        public double TinhDiemTB() => (MonHoc1 + MonHoc2) / 2;
        public override string DanhGia()
        {
            return TinhDiemTB() >= 5 ? "Đạt" : "Rớt";
        }

        public override string ToString()
        {
            return $"[Sinh Viên]  {base.ToString()} | ĐTB: {TinhDiemTB():0.0} | Đánh giá: {DanhGia()}";
        }
    }
}
