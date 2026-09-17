using System;
using System.Collections.Generic;
using System.Text;

namespace bai9
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<PhuongTien> danhSachXe = new List<PhuongTien>();

            // Thêm dữ liệu mẫu vào chung một danh sách (Thể hiện tính Đa hình)
            danhSachXe.Add(new XeDap("Martin 107", 3000000));
            danhSachXe.Add(new XeMay("Honda Vision", 35000000));
            danhSachXe.Add(new XeOToTai("Hyundai H150", 400000000));
            danhSachXe.Add(new XeOToKhach("Kia Morning", 350000000, 4));  // 4 chỗ -> Thuế TTĐB 50%
            danhSachXe.Add(new XeOToKhach("Ford Transit", 900000000, 16)); // 16 chỗ -> Thuế TTĐB 30%

            Console.WriteLine("=== BẢNG TÍNH THUẾ PHƯƠNG TIỆN GIAO THÔNG ===\n");
            foreach (var xe in danhSachXe)
            {
                xe.XuatThongTin();
            }
        }
    }
}
