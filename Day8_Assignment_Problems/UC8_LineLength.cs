using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Assignment_Problems
{
    internal class UC8_LineLength
    {
        public static void LengthofLine()
        {
            Console.WriteLine("\nUC8");
            Console.WriteLine("enter x1,x2,y1,y2 values");

            double x1 = int.Parse(Console.ReadLine());

            double x2 = int.Parse(Console.ReadLine());

            double y1 = int.Parse(Console.ReadLine());

            double y2 = int.Parse(Console.ReadLine());

            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("Length of Line is : " + length);
        }
    }
}
