public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length;
        int element = nums[0], count = 1;

        for(int i = 1; i < n; i++){
            if(nums[i] == element) count++;
            else{
                count--;
                if(count == 0){
                    element = nums[i];
                    count = 1;
                }
            }
        }
        return element;
    }
}
