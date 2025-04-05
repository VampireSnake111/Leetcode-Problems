public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; // To prevent going out of bounds of array
        void Reverse(int start, int end){
            while(start < end){
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
        Reverse(0, n - 1); // Reverse the whole array (To bring the front to the back and vice versa)
        Reverse(0, k - 1); // Reverse the first k elements (Top preserve their original order)
        Reverse(k, n - 1); // Reverse the rest of the elements (Same as above)
    }
}
