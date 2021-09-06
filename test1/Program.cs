using System;

namespace test1
{
    public class Program
    {
        public static int Main(String[] args)
        {
            Console.WriteLine("Please enter a number:");
            var inps = Console.In.ReadLine();

            try
            {
                var inp = Int32.Parse(inps);

                if (inp < 1582)
                {
                    Console.WriteLine("Only 1582 and folliwing years are supported");
                    return 1;
                }

                Console.WriteLine(IsLeapYear(inp) ? "yay" : "nay");
                return 0;

            }
            catch (FormatException)
            {
                Console.WriteLine("Please provide a whole number");
                return 1;
            }
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
