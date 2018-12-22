using FluentAssertions;
using Xunit;

namespace LeetCode.Easy.Problem55
{
    public class LeetCode55
    {
        [Theory]
        [InlineData(new [] {2,3,1,1,4}, true )]
        [InlineData(new [] {3,2,1,0,4}, false )]
        public void CheckSolution(int[] input, bool result)
        {
            var solution = new Solution();
            bool canJump = solution.CanJump(input);

            canJump.Should().Be(result);
        }
    }
}