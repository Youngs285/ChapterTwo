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
            string MinutesInput, HoursInput;
            double Minutes, Hours;

            Console.WriteLine("How many hours did you work today?");
            MinutesInput = Console.ReadLine();
            Minutes = Convert.ToInt32(MinutesInput);

            Console.WriteLine("How many minutes did you work today?");
            HoursInput = Console.ReadLine();
            Hours = Convert.ToInt32(HoursInput);

            Console.WriteLine("You worked {0} Hours and {1} Minutes today", Minutes, Hours);
            
        }
    }
} 
