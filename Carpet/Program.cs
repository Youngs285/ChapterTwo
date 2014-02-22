using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            string LengthInput, WidthInput, CostInput;
            double Length = 1, Width = 1, Cost = 1;


            Console.WriteLine("Please input the Length of the room");
            LengthInput = Console.ReadLine();
            Length = Convert.ToInt32(LengthInput);

            Console.WriteLine("Pleas input the Width of the room");
            WidthInput = Console.ReadLine();
            Width = Convert.ToInt32(WidthInput);

            Console.WriteLine("Please input the cost of carpet per square foot");
            CostInput = Console.ReadLine();
            Cost = Convert.ToInt32(CostInput);

            double Area = Length * Width, TotalCost = Cost * Area;

            Console.WriteLine("The total cost to carpet the room will be ${0}", TotalCost);

        }
    }
}
