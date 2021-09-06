using System;
using System.IO;
using Xunit;

namespace test1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void promptUserNonLeapYearNumber()
        {
            var writer = new StringWriter();
            var reader = new StringReader("1999");
            Console.SetOut(writer);
            Console.SetIn(reader);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim().Split("\n");

            Assert.Equal("Please enter a number:", output[0]);
            Assert.Equal("nay", output[1]);
        }

        [Fact]
        public void promptUserLeapYearNumber()
        {
            var writer = new StringWriter();
            var reader = new StringReader("2004");
            Console.SetOut(writer);
            Console.SetIn(reader);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim().Split("\n");

            Assert.Equal("Please enter a number:", output[0]);
            Assert.Equal("yay", output[1]);
        }

        [Fact]
        public void yearDivisibleBy4IsLeapYear()
        {
            var output = Program.IsLeapYear(2004);

            Assert.True(output);
        }

        [Fact]
        public void yearNotDivisbleByForIsNotLeapYear()
        {
            var output = Program.IsLeapYear(1999);
            Assert.False(output);
        }

        [Fact]
        public void every400YearIsNotLeapYear()
        {
            var output = Program.IsLeapYear(2000);
            Assert.False(output);
        }
    }
}
