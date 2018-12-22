using FluentAssertions;
using Xunit;

namespace LeetCode.Easy.Problem121
{
    public class LetCode121
    {
        [Theory]
        [InlineData(new [] {7, 1, 5, 3, 6, 4}, 5 )]
        [InlineData(new [] {7, 6, 4, 3, 1}, 0 )]
        [InlineData(new [] {7, 2, 5, 8, 1, 10}, 9 )]
        public void CheckSolution(int[] input, int result)
        {
            var solution = new Solution();
            int sum = solution.MaxProfit(input);

            sum.Should().Be(result);
        }
    }
}