using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    public class HourlyEmployee : Employee
    {
        public double Wage { get; set; }
        public double Hours { get; set; }

        public HourlyEmployee(string firstName, string lastName, string ssn, double wage, double hours)
            : base(firstName, lastName, ssn)
        {
            Wage = wage;
            Hours = hours;
        }

        public override double Earnings()
        {
            if (Hours <= 40)
            {
                return Wage * Hours;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5);
            }
        }

        public override string ToString()
        {
            return $"hourly employee: {base.ToString()}\nhourly wage: {Wage:N0}; hours worked: {Hours}";
        }
    }
}
