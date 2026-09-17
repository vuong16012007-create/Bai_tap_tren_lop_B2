using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Sach> danhSachSach = new List<Sach>();
            danhSachSach.Add(new SachGiaoKhoa("SGK01", new DateTime(2023, 1, 15), 50000, 10, "Giao duc", "mới"));
            danhSachSach.Add(new SachGiaoKhoa("SGK02", new DateTime(2022, 5, 20), 45000, 5, "Tre", "cũ"));
            danhSachSach.Add(new SachGiaoKhoa("SGK03", new DateTime(2023, 8, 10), 60000, 20, "Giao duc", "mới"));

            danhSachSach.Add(new SachThamKhao("STK01", new DateTime(2023, 2, 10), 100000, 5, "Khoa học", 10000));
            danhSachSach.Add(new SachThamKhao("STK02", new DateTime(2021, 11, 5), 150000, 2, "Trẻ", 15000));
            danhSachSach.Add(new SachThamKhao("STK03", new DateTime(2023, 7, 25), 80000, 10, "Kỹ thuật", 8000));

            double tongTienSGK = danhSachSach.OfType<SachGiaoKhoa>().Sum(s => s.TinhThanhTien());
            double tongTienSTK = danhSachSach.OfType<SachThamKhao>().Sum(s => s.TinhThanhTien());

            Console.WriteLine("=== TỔNG THÀNH TIỀN TỪNG LOẠI ===");
            Console.WriteLine($"- Tổng tiền SGK: {tongTienSGK:N0} VNĐ");
            Console.WriteLine($"- Tổng tiền STK: {tongTienSTK:N0} VNĐ\n");

            Console.Write("Nhập tên NXB K cần tìm (VD: Giáo dục): ");
            string nxbK = Console.ReadLine();
            Console.WriteLine($"\n=== SÁCH GIÁO KHOA CỦA NXB '{nxbK}' ===");
            var sgkCuaNxbK = danhSachSach.OfType<SachGiaoKhoa>().Where(s => s.NhaXuatBan.Equals(nxbK, StringComparison.OrdinalIgnoreCase)).ToList();
            if (sgkCuaNxbK.Count > 0)
            {
                foreach (var s in sgkCuaNxbK)
                {
                    s.XuatThongTin();
                }
            }
            else
            {
                Console.WriteLine($"--> Không tìm thấy sách nào cuả nhà xuất bản {nxbK}\n ");
            }

            double maxThanhTien = danhSachSach.Max(s => s.TinhThanhTien());
            Console.WriteLine($"\n== CÁC SÁCH CÓ THÀNH TIỀN CAO NHẤT: {maxThanhTien:N0} VNĐ == ");
            var sachMax = danhSachSach.Where(s => s.TinhThanhTien()  == maxThanhTien);
            foreach (var s in sachMax)
            {
                s.XuatThongTin();
            }
            Console.ReadLine();

        }
    }
}
