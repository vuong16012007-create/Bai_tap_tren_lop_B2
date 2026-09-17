using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    public class SalariedEmployee : Employee
    {
        public double WeeklySalary { get; set; }

        public SalariedEmployee(string firstName, string lastName, string ssn, double weeklySalary)
            : base(firstName, lastName, ssn)
        {
            WeeklySalary = weeklySalary;
        }

        public override double Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return $"salaried employee: {base.ToString()}\nweekly salary: {WeeklySalary:N0}";
        }
    }
}
