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
        public void handleNonNumberInput()
        {
            var writer = new StringWriter();
            var reader = new StringReader("hey");
            Console.SetOut(writer);
            Console.SetIn(reader);

            var exitCode = Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim().Split("\n");

            Assert.Equal("Please provide a whole number", output[1]);
            Assert.Equal(1, exitCode);
        }

        [Fact]
        public void handleYearBefore1582()
        {
            var writer = new StringWriter();
            var reader = new StringReader("1581");
            Console.SetOut(writer);
            Console.SetIn(reader);

            var exitCode = Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim().Split("\n");

            Assert.Equal("Only 1582 and folliwing years are supported", output[1]);
            Assert.Equal(1, exitCode);
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
