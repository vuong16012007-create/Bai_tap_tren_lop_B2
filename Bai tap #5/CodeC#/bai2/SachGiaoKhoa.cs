using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace bai2
{
    public class SachGiaoKhoa : Sach
    {
        public string TinhTrang { get; set;  }
        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, string tinhTrang)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            TinhTrang = tinhTrang;
        }
        public override double TinhThanhTien()
        {
           if (TinhTrang.ToLower() == "mới")
            {
                return SoLuong * DonGia;
            }
           else if (TinhTrang.ToLower() == "cũ")
            {
                return SoLuong * DonGia * 0.5;
            }
            return 0;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"   -> [SGK] Tình trạng: {TinhTrang} | Thành tiền: {TinhThanhTien():N0} VNĐ\n");
        }
    }
}
