using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Assignment_Problems
{
    internal class UC9_EqualityOfTwoLines
    {
        public static void TwoLinesareEqual()
        {
            Console.WriteLine("\nUC9");
            Console.WriteLine("enter x1,x2,y1,y2 values");

            double x1 = int.Parse(Console.ReadLine());

            double x2 = int.Parse(Console.ReadLine());

            double y1 = int.Parse(Console.ReadLine());

            double y2 = int.Parse(Console.ReadLine());

            double Length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("enter x3,x4,y3,y4 values");
            double x3 = int.Parse(Console.ReadLine());

            double x4 = int.Parse(Console.ReadLine());

            double y3 = int.Parse(Console.ReadLine());

            double y4 = int.Parse(Console.ReadLine());

            double Length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            Console.WriteLine("Length is equals or not : " + Length1.Equals(Length2));
        }
    }
}
