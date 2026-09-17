using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Bai3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<GiaoDich> danhSachGD = new List<GiaoDich>();

            // Khởi tạo 3 GD Vàng (Có 1 giao dịch đơn giá > 1 tỷ để test câu c)
            danhSachGD.Add(new GiaoDichVang("V01", new DateTime(2023, 1, 10), 5500000, 10, "9999"));
            danhSachGD.Add(new GiaoDichVang("V02", new DateTime(2023, 5, 20), 1200000000, 2, "SJC")); // Đơn giá > 1 tỷ
            danhSachGD.Add(new GiaoDichVang("V03", new DateTime(2023, 8, 15), 4000000, 5, "18K"));

            // Khởi tạo 3 GD Tiền Tệ
            danhSachGD.Add(new GiaoDichTienTe("T01", new DateTime(2023, 2, 5), 1000, 50, 24000, "USD"));
            danhSachGD.Add(new GiaoDichTienTe("T02", new DateTime(2023, 3, 12), 500000, 10, 1, "VN"));
            danhSachGD.Add(new GiaoDichTienTe("T03", new DateTime(2023, 7, 22), 2000, 30, 26000, "Euro"));

            double tongGDV = danhSachGD.OfType<GiaoDichVang>().Sum(s => s.ThanhTien());
            double tongGDTT = danhSachGD.OfType<GiaoDichTienTe>().Sum(S => S.ThanhTien());
            Console.WriteLine("=== TỔNG SỐ LƯỢNG GIAO DỊCH ===");
            Console.WriteLine($"- Giao dịch Vàng: {tongGDV} (lượng/chỉ)");
            Console.WriteLine($"- Giao dịch Tiền Tệ: {tongGDTT} (tờ)\n");

            double tbTienTe = danhSachGD.OfType<GiaoDichTienTe>().Average(s => s.ThanhTien());
            Console.WriteLine($"=== TRUNG BÌNH THÀNH TIỀN GIAO DỊCH TIỀN TỆ ===\n-> {tbTienTe:N0} VNĐ\n");

            Console.WriteLine("=== CÁC GIAO DỊCH CÓ ĐƠN GIÁ > 1 TỶ ===");
            var giaodichTyPhu = danhSachGD.Where(s => s.DonGia > 1000000000).ToList();
            if (giaodichTyPhu.Count > 0)
            {
                foreach (var g in giaodichTyPhu)
                {
                    g.toString();
                }
            }
            else
            {
                Console.WriteLine("Không có giao dịch nào trên 1 tỷ.");
            }
            Console.ReadLine();
        }
    }
}