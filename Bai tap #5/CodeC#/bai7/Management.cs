using System;
using System.Collections.Generic;
using System.Text;

namespace bai7
{
    public class Management
    {
        private List<Person> danhSach;
        private int tongSoNguoi;
        private int sucChuaToiDa;
        public Management(int n)
        {
            sucChuaToiDa = n;
            danhSach = new List<Person>();
            tongSoNguoi = 0;
        }

        public bool ThemNguoi(Person p)
        {
            if (tongSoNguoi >= sucChuaToiDa)
            {
                Console.WriteLine("Lỗi: Học viện đã đầy, không thể thêm người mới!");
                return false;
            }
            danhSach.Add(p);
            tongSoNguoi++;
            return true;
        }
        public bool XoaNguoi(string hoTen)
        {
            var nguoi = danhSach.FirstOrDefault(n => n.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase));
            if (nguoi != null)
            {
                danhSach.Remove(nguoi);
                tongSoNguoi--;
                return true;
            }
            return false;
        }
        public void SapXepTheoTen()
        {
            danhSach = danhSach.OrderBy(n => n.HoTen).ToList();
            Console.WriteLine("Đã sắp xếp danh sách theo tên!");
        }
        public void XuatDanhSach()
        {
            Console.WriteLine($"\n--- DANH SÁCH (Sĩ số: {tongSoNguoi}/{sucChuaToiDa}) ---");
            if (tongSoNguoi == 0)
            {
                Console.WriteLine("Danh sách hiện đang trống.");
                return;
            }
            foreach (var p in danhSach)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public class Program
        {
            public static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Management hocVien = new Management(5);
                hocVien.ThemNguoi(new Student("Le Van A", "Q1", 8.5, 9.0));
                hocVien.ThemNguoi(new Employee("Tran Thi B", "Q3", 2.5));
                hocVien.ThemNguoi(new Customer("Nguyen C", "Q5", "TechCorp", 15000000));

                int chon;
                do
                {
                    Console.WriteLine("\n========== QUẢN LÝ HỌC VIỆN ==========");
                    Console.WriteLine("1. Thêm Sinh viên");
                    Console.WriteLine("2. Thêm Nhân viên");
                    Console.WriteLine("3. Thêm Khách hàng");
                    Console.WriteLine("4. Xem danh sách");
                    Console.WriteLine("5. Sắp xếp theo tên");
                    Console.WriteLine("6. Xóa theo tên");
                    Console.WriteLine("0. Thoát");
                    Console.Write("Chọn chức năng: ");

                    if (!int.TryParse(Console.ReadLine(), out chon)) continue;

                    switch (chon)
                    {
                        case 1:
                            if (hocVien.ThemNguoi(new Student("Sinh Vien Moi", "Q.Tan Binh", 6, 7)))
                                Console.WriteLine("Đã thêm Sinh viên!");
                            break;
                        case 2:
                            if (hocVien.ThemNguoi(new Employee("Nhan Vien Moi", "Q.10", 3.2)))
                                Console.WriteLine("Đã thêm Nhân viên!");
                            break;
                        case 3:
                            if (hocVien.ThemNguoi(new Customer("Khach Moi", "Q.7", "ABC Ltd", 5000000)))
                                Console.WriteLine("Đã thêm Khách hàng!");
                            break;
                        case 4:
                            hocVien.XuatDanhSach();
                            break;
                        case 5:
                            hocVien.SapXepTheoTen();
                            hocVien.XuatDanhSach();
                            break;
                        case 6:
                            Console.Write("Nhập chính xác Họ tên người cần xóa: ");
                            string ten = Console.ReadLine();
                            if (hocVien.XoaNguoi(ten))
                                Console.WriteLine("Đã xóa thành công!");
                            else
                                Console.WriteLine("Lỗi: Không tìm thấy người này!");
                            break;
                    }
                } while (chon != 0);
            }
        }
    }
}
