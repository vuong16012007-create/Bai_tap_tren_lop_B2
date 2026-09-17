using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    internal class ChuyenXeNgoaiThanh : ChuyenXe
    {
        private string noiDen;
        private int soNgayDi;

        public ChuyenXeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu, string noiDen, int soNgayDi)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            this.noiDen = noiDen;
            this.soNgayDi = soNgayDi;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"   -> [Ngoại Thành] Nơi đến: {noiDen} | Số ngày đi: {soNgayDi} ngày\n");
        }
    }
}
