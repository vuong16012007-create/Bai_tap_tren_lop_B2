using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<ChuyenXe> danhSachChuyenXe = new List<ChuyenXe>();
            // Thêm các chuyến xe nội thành
            danhSachChuyenXe.Add(new ChuyenXeNoiThanh("NT001", "Nguyễn Văn A", "29A-12345", 500000, 1, 10));
            danhSachChuyenXe.Add(new ChuyenXeNoiThanh("NT002", "Trần Thị B", "29B-67890", 600000, 2, 15));
            // Thêm các chuyến xe ngoại thành
            danhSachChuyenXe.Add(new ChuyenXeNgoaiThanh("XT001", "Lê Văn C", "30A-54321", 800000, "Hà Nội - Hải Phòng", 2));
            danhSachChuyenXe.Add(new ChuyenXeNgoaiThanh("XT002", "Phạm Thị D", "30B-98765", 900000, "Hà Nội - Quảng Ninh", 3));
            // Xuất thông tin các chuyến xe
            Console.WriteLine("Danh sách các chuyến xe:");
            foreach (var chuyenXe in danhSachChuyenXe)
            {
                chuyenXe.XuatThongTin();
            }
            // Tính tổng doanh thu
            double tongDoanhThu = 0;
            foreach (var chuyenXe in danhSachChuyenXe)
            {
                tongDoanhThu += chuyenXe.DoanhThu;
            }
            Console.WriteLine($"Tổng doanh thu: {tongDoanhThu:N0} VNĐ");
        }
    }
}
