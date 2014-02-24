using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursandMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string MinutesInput;
            int Hours, RemainderMinutes, Minutes = 1;

            Console.WriteLine("How many minutes did you work today?");
            MinutesInput = Console.ReadLine();
            Minutes = Convert.ToInt32(MinutesInput);

            Hours = Minutes / 60;
            RemainderMinutes = Minutes % 60;

            Console.WriteLine("You have worked {0} hours and {1} minutes.", Hours, RemainderMinutes);
            
        }
    }
} 
