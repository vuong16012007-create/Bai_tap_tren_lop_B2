using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    public class CommissionEmployee : Employee
    {
        public double GrossSales { get; set; } 
        public double CommissionRate { get; set; }

        public CommissionEmployee(string firstName, string lastName, string ssn, double grossSales, double commissionRate)
            : base(firstName, lastName, ssn)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public override double Earnings()
        {
            return CommissionRate * GrossSales;
        }

        public override string ToString()
        {
            return $"commission employee: {base.ToString()}\ngross sales: {GrossSales:N0}; commission rate: {CommissionRate}";
        }
    }
}
