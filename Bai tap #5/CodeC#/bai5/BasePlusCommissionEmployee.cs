using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public double BaseSalary { get; set; } 

        public BasePlusCommissionEmployee(string firstName, string lastName, string ssn, double grossSales, double commissionRate, double baseSalary)
            : base(firstName, lastName, ssn, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public override double Earnings()
        {
            return base.Earnings() + BaseSalary;
        }

        public override string ToString()
        {
            return $"base salaried {base.ToString()}\nbase salary: {BaseSalary:N0}";
        }
    }
}
