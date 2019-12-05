using System;
using AdventOfCode2019Day1;
using FluentAssertions;
using Xunit;

namespace AdventForCode2019Day1.Tests
{
    public class CalculateFuelTests
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void CalculateFuelPerComponent_ShouldReturnExpectedValue(int mass, int fuel)
        {
            var sut = new Module();

            var result = sut.CalculateFuel(mass);

            result.Should().Be(fuel);
        }

        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void CalculateFuelUntilFullTank_ShouldReturnExpectedValue(int mass, int totalFuel)
        {
            var sut = new Module();

            var result = sut.CalculateFuelUntilFullTank(mass);

            result.Should().Be(totalFuel);
        }
    }
}
