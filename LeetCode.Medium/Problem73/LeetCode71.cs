using System;
using FluentAssertions;
using Xunit;

namespace LeetCode.Medium.Problem73
{
    public class LeetCode71
    {
        [Theory]
        //[InlineData("/a/../../b/../c//.//","/c")]
        //[InlineData("/a/./b/../../c/", "/c" )]
        //[InlineData("/a//b////c/d//././/..","/a/b/c")]
        //[InlineData("/home/","/home")]
        //[InlineData("/...","/...")]
        [InlineData("/.../","/...")]
        public void LeetCode71_Path_simplification(string path, string result)
        {
            var solution = new SolutionDefault();
            var actual = solution.SimplifyPath(path);

            actual.Should().Be(result);
        }
    }
}