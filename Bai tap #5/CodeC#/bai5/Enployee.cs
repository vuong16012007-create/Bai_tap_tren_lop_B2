using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace bai5
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; } // Social Security Number

        public Employee(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }

        public abstract double Earnings();

        public override string ToString()
        {
            return $"{FirstName} {LastName}\nsocial security number: {SSN}";
        }

    }
}
