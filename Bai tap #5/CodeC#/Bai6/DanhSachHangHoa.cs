using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    public class DanhSachHangHoa
    {
        private List<HangHoa> danhSach;
        public DanhSachHangHoa()
        {
            danhSach = new List<HangHoa>();
        }

        public bool ThemHangHoa(HangHoa hh)
        {
            if( danhSach.Any(h => h.MaHang == hh.MaHang))
            {
                Console.WriteLine("Lỗi: Mã hàng đã tồn tại!");
                return false;
            }
            danhSach.Add(hh);
            return true;
        }
        public void XuatToanBo()
        {
            Console.WriteLine("\n=== TOÀN BỘ DANH SÁCH ===");
            foreach (var s in danhSach)
            {
                s.XuatThongTin();
            }
        }
        public void XuatTungLoai()
        {
            Console.WriteLine("\n=== DANH SÁCH HÀNG THỰC PHẨM ===");
            var thucPham = danhSach.OfType<HangThucPham>().ToList();
            foreach (var h in thucPham)
            {
                h.XuatThongTin();
            }
            Console.WriteLine("\n=== DANH SÁCH HÀNG ĐIỆN MÁY ===");
            var dienMay = danhSach.OfType<HangDienMay>().ToList();
            foreach (var h in dienMay) h.XuatThongTin();
            Console.WriteLine("\n=== DANH SÁCH HÀNG SÀNH SỨ ===");
            var sanhSu = danhSach.OfType<HangSanhSu>().ToList();
            foreach (var h in sanhSu) h.XuatThongTin();
        }
        public HangHoa TimKiem(string maHang)
        {
            return danhSach.FirstOrDefault(h => h.MaHang == maHang);
        }
        public void SapXepTheoTenTangDan()
        {
            danhSach  = danhSach.OrderBy(c => c.TenHang).ToList();
            Console.WriteLine("Đã sắp xếp theo tên!");
           
            
        }
        public void SapXepTheoTonGiamDan()
        {
            danhSach = danhSach.OrderByDescending(h => h.SoLuong).ToList();
            Console.WriteLine("Đã sắp xếp theo tồn kho!");
            
        }
        public void XuatThucPhamKhoBan()
        {
            var htpKhoBan = danhSach.OfType<HangThucPham>().Where(h => h.DanhGia() == "Khó bán");
            foreach (var h in htpKhoBan) h.XuatThongTin();
        }
        public void Xoa(string maHang)
        {
            var hh = TimKiem(maHang);
            if (hh != null)
            {
                danhSach.Remove(hh);
                Console.WriteLine("Dã xóa thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã hàng để xóa.");
            }
                
        }
        public void SuaDonGia(string maHang, double giaMoi)
        {
            var hh = TimKiem(maHang);
            if(hh != null)
            {
                hh.DonGia = giaMoi;
                Console.WriteLine("Đã cập nhật giá.");
            }
        }

    }
    public class Program()
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DanhSachHangHoa kho = new DanhSachHangHoa();

            kho.ThemHangHoa(new HangThucPham("Tp01", "Sửa tươi", 30000, 10, "Vinamilk", new DateTime(2023, 6, 1), new DateTime(2023, 6, 1)));
            kho.ThemHangHoa(new HangDienMay("Dm01", "Tủ lạnh", 8000000, 2, 24, 150));
            kho.ThemHangHoa(new HangSanhSu("Ss01", "Chén sứ", 50000, 60, "Minh Long", new DateTime(2023, 6, 1)));

            int chon;
            do
            {
                Console.WriteLine("\n--- QUẢN LÝ KHO SIÊU THỊ ---");
                Console.WriteLine("1. Xem toàn bộ kho");
                Console.WriteLine("2. Sắp xếp kho theo Tên (Tăng dần)");
                Console.WriteLine("3. Sắp xếp kho theo Tồn (Giảm dần)");
                Console.WriteLine("4. Lọc Thực phẩm khó bán");
                Console.WriteLine("5. Xem danh sách theo TỪNG LOẠI"); // Bổ sung tính năng mới
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1: kho.XuatToanBo(); break;
                    case 2: kho.SapXepTheoTenTangDan(); kho.XuatToanBo(); break;
                    case 3: kho.SapXepTheoTonGiamDan(); kho.XuatToanBo(); break;
                    case 4: kho.XuatThucPhamKhoBan(); break;
                    case 5: kho.XuatTungLoai(); break;
                }

            } while (chon != 0);
        }
    }

}
