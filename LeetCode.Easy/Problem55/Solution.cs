namespace LeetCode.Easy.Problem55
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int index = nums.Length - 1;
            var newIndex = index;

            while (index > 0 && newIndex > 0)
            {
                newIndex--;
                if (nums[newIndex] >= index - newIndex)
                    index = newIndex;
            }

            return index <= 0;
        }
    }
}   