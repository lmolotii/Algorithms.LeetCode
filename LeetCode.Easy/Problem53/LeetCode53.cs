using FluentAssertions;
using Xunit;

namespace LeetCode.Easy.Problem53
{
    public class LeetCode53
    {
        [Theory]
        [InlineData(new [] {-2, 1, -3, 4, -1, 2, 1, -5, 4}, 6 )]
        [InlineData(new [] {1, 2, 3, -5, 1, -2, 8, 3, 1}, 12 )]
        [InlineData(new [] {-2, -3, -5,-4, -5,-3, -5, -4}, -2)]
        public void CheckSolution(int[] input, int result)
        {
            var solution = new Solution();
            int sum = solution.MaxSubArray(input);

           sum.Should().Be(result);
        }
    }
   
}