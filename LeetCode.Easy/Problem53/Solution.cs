namespace LeetCode.Easy.Problem53
{
    public class Solution {
        
        public int MaxSubArray(int[] nums)
        {
            int[] sumResult = new int[nums.Length];
            sumResult[0] = nums[0];
            int maxNumber = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (sumResult[i - 1] < 0)
                    sumResult[i] = nums[i];
                else
                    sumResult[i] = sumResult[i - 1] + nums[i];

                if (sumResult[i] > maxNumber)
                    maxNumber = sumResult[i];
            }

            return maxNumber;
        }
    }
}