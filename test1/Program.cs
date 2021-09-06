using System;

namespace test1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter a number:");
            var inps = Console.In.ReadLine();

            var inp  = Int32.Parse(inps);

            Console.WriteLine(IsLeapYear(inp) ? "yay" : "nay");
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return false;
            }

            return year % 4 == 0;
        }
    }
}
