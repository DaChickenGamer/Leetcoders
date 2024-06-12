public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int solution = -2;
        int num1 = 0;
        int num2 = 0;
        int arrayLength = nums.Length;

        while((solution != target))
        {
            if(num2 > (arrayLength - 1))
            {
                Console.WriteLine("Does not Exist");
                return null;
            }
            else if(num1 <= (arrayLength - 1))
            {
                if (!(num1 == num2))
                    solution = nums[num1] + nums[num2];
                if((solution != target))
                {
                    num1++;
                }
            }
            else if(num1 > (arrayLength - 1)){
                num1 = 0;
                num2++;
            }
        }

        int[] myNumbers = {num1,num2};
        //int[] myNumbers = {arrayLength};

        return myNumbers;

    }
}
