using System;
using System.Collections.Generic;
using System.Text;

namespace bai10
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<SinhVien> danhSach = new List<SinhVien>();

            // Tạo đối tượng và gọi hàm Nhập (Đa hình)
            SinhVien sv1 = new SinhVienDaiHoc();
            sv1.NhapThongTin();
            danhSach.Add(sv1);
            Console.WriteLine();

            SinhVien sv2 = new SinhVienLienKet();
            sv2.NhapThongTin();
            danhSach.Add(sv2);
            Console.WriteLine();

            SinhVien sv3 = new SinhVienCaoDang();
            sv3.NhapThongTin();
            danhSach.Add(sv3);
            Console.WriteLine();

            SinhVien sv4 = new SinhVienTrungCap();
            sv3.NhapThongTin();
            danhSach.Add(sv4);
            Console.WriteLine();

            // Hiển thị danh sách
            Console.WriteLine("=== DANH SÁCH SINH VIÊN ===");
            foreach (var sv in danhSach)
            {
                sv.HienThiThongTin();
            }
        }
    }
}
