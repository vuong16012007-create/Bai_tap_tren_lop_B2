using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    internal class ChuyenXeNoiThanh : ChuyenXe
    {
        private int soTuyen;
        private double soKm;

        public ChuyenXeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu, int soTuyen, double soKm)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            this.soTuyen = soTuyen;
            this.soKm = soKm;
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"   -> [Nội Thành] Tuyến số: {soTuyen} | Số Km đi được: {soKm} km\n");
        }
    }
}
