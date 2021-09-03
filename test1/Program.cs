using System;

namespace test1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello World");
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
