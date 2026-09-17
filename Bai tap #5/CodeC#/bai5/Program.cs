using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Employee> danhSachNV = new List<Employee>();
            danhSachNV.Add(new SalariedEmployee("Nguyễn", "Văn A", "SSN-001", 15000000));
            danhSachNV.Add(new HourlyEmployee("Trần", "Thị B", "SSN-002", 50000, 45)); // Làm dư 5 tiếng
            danhSachNV.Add(new CommissionEmployee("Lê", "Văn C", "SSN-003", 50000000, 0.1)); // Hoa hồng 10%
            danhSachNV.Add(new BasePlusCommissionEmployee("Phạm", "Thị D", "SSN-004", 40000000, 0.05, 5000000));

            Console.WriteLine("========== BẢNG LƯƠNG NHÂN VIÊN ==========\n");

            foreach (Employee nv in danhSachNV)
            {
                Console.WriteLine(nv.ToString());
                Console.WriteLine($"-> THỰC LÃNH: {nv.Earnings():N0} VNĐ");
                Console.WriteLine("------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}