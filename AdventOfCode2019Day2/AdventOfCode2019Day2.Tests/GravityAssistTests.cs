using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2019Day2.Tests
{
    public class GravityAssistTests
    {
        [Theory]
        [MemberData(nameof(Intcodes))]
        public void RestoreGravity_Part1(int[] inputCodes, int[] expectedCodes)
        {
            var sut = new GravityAssist();

            var result = sut.RestoreGravity(inputCodes);

            result.Should().BeEquivalentTo(expectedCodes, options => options.WithStrictOrdering());
        }

        public static IEnumerable<object[]> Intcodes =>
            new List<object[]>
            {
                new object[] {new int[] {1, 0, 0, 0, 99}, new int[] {2, 0, 0, 0, 99}},
                new object[] {new int[] {2, 3, 0, 3, 99}, new int[] {2, 3, 0, 6, 99}},
                new object[] {new int[] {2, 4, 4, 5, 99, 0}, new int[] {2, 4, 4, 5, 99, 9801}},
                new object[] {new int[] {1, 1, 1, 4, 99, 5, 6, 0, 99}, new int[] {30, 1, 1, 4, 2, 5, 6, 0, 99}}
            };
    }
}