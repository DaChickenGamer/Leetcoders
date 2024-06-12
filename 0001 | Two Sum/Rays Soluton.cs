public class Rays_Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        int currentTarget = 0;
        bool runProgram = true;
        
        while (runProgram)
        {
            for(int i = 0; i < nums.Length; i++){
                for(int n = 0; n < nums.Length; n++){
                    if (i != n){
                        currentTarget = nums[i] + nums[n];

                        if (currentTarget == target)
                        {
                            int[] answer = {i, n};
                            return answer;
                        }
                    }
                }
            }
			
        }
		
        return null;
    }
}