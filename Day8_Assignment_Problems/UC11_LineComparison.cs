using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Assignment_Problems
{
    internal class UC11_LineComparison
    {
        public static void Comparison()
        {
            Console.WriteLine("\nUC11");
            Console.WriteLine("First Line");
            int x1, y1, x2, y2;

            Console.WriteLine("Enter x1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            var Line1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine("Line1 :" + Line1);

            Console.WriteLine("Second Line");
            int x3, y3, x4, y4;

            Console.WriteLine("Enter x3");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y3");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x4");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y4");
            y4 = Convert.ToInt32(Console.ReadLine());

            var Line2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));

            Console.WriteLine("Line2 :" + Line2);

            Console.WriteLine("Comparison");

            Console.WriteLine("Line 1 = " + Line1);
            Console.WriteLine("Line 2 = " + Line2);
            Console.WriteLine("Return value (comparison) = " + Line1.CompareTo(Line2));
        }
    }
}
