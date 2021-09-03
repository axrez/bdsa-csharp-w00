using System;
using System.IO;
using Xunit;

namespace test1.Tests
{
    public class UnitTest1
    {
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
