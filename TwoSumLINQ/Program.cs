using Dumpify;

namespace TwoSumLINQ;

// https://leetcode.com/problems/two-sum/description/

class Program
{
    static void Main(string[] args)
    {
        int[] numsOne = [2, 7, 11, 15]; 
        int targetOne= 9;

        int[] numsTwo = [3, 2, 4];
        int targetTwo = 6;

        int[] numsThree = [3, 3];
        int targetThree = 6;


        TwoSum(numsOne, targetOne).Dump();
        TwoSum(numsTwo, targetTwo).Dump();
        TwoSum(numsThree, targetThree).Dump();

        int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int remainder = target - nums[i];
                var result = nums
                    .Select((number, index) => new { number, index })
                    .FirstOrDefault(x => x.number == remainder && x.index != i);

                if (result != null)
                {
                    
                    return [i, result.index];
                }
            }

            return [0,0];
        }
    }
}