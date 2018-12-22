using System.Collections.Generic;
using System.Runtime.InteropServices;
using FluentAssertions;
using Xunit;

namespace LeetCode.Easy.Problem54
{
    public class LeetCode54
    {
        public static IEnumerable<object[]> ArrayData
        {
            get
            {
                return new[]
                {
                    //new object[] {new int[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}, new int[] {1, 2, 3, 6, 9, 8, 7, 4, 5}},
                    //new object[] {new int[,] {{2, 5, 8}, {4, 0, -1}}, new int[] {2, 5, 8, -1, 0, 4}},
                    new object[] {new int[,] {{1, 11}, {2, 12},{3,13},{4, 14}, {5, 15},{6,16},{7, 17}, {8, 18}, {9,19}, {10,20}}, new int[] {1,11,12,13,14,15,16,17,18,19,20,10,9,8,7,6,5,4,3,2}}
                };
            }
        }

        [Theory]
        [MemberData(nameof(ArrayData))]
        public void CheckSolution(int[,] array,int[] expectedValue)
        {
            var solution = new Solution();
            var result = solution.SpiralOrder(array);

            result.Should().BeEquivalentTo(expectedValue);
        }
    }
}