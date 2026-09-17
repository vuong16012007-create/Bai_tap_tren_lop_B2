using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class ChuyenXe
    {
        protected string maSoChuyen;
        protected string hoTenTaiXe;
        protected string soXe;
        protected double doanhThu;

        public double DoanhThu { get => doanhThu; set => doanhThu = value; }

        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu)
        {
            this.maSoChuyen = maSoChuyen;
            this.hoTenTaiXe = hoTenTaiXe;
            this.soXe = soXe;
            this.doanhThu = doanhThu;
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Mã chuyến: {maSoChuyen} | Tài xế: {hoTenTaiXe} | Số xe: {soXe} | Doanh thu: {doanhThu:N0} VNĐ");
        }
    }
}
