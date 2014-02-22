using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameInput, SsNInput, PayRateInput, HoursWorkedInput;
            float Name, SsN, PayRate, HoursWorked;

            Console.Write("Enter your name:");
            NameInput = Console.ReadLine();
            Name = Convert.ToInt32(NameInput);

            Console.Write("Social Security Number:");
            SsNInput = Console.ReadLine();
            SsN = Convert.ToInt32(SsNInput);

            Console.Write("Hourly pay rate:");
            PayRateInput = Console.ReadLine();
            PayRate = Convert.ToInt32(PayRateInput);

            Console.Write("Hours worked:");
            HoursWorkedInput = Console.ReadLine();
            HoursWorked = Convert.ToInt32(HoursWorkedInput);

            float GrossPay = PayRate * HoursWorked;

            int intGrossPay;

            Console.WriteLine("Payroll Summary for:{0}", Name);
            Console.WriteLine("SSN:{0}", SsN);
            Console.WriteLine("You earned ${0} at ${1} per hour", PayRate, GrossPay);

            intGrossPay = Convert.ToInt32(GrossPay);

            int FedTax = intGrossPay % 15;

            Console.Write("Gross Pay:                  {0}", GrossPay);                 
            
        }
    }
}
