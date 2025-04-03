public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        for(int i = n - 1; i >= 0; i--){
            if(digits[i] < 9){
                digits[i]++;
                return digits;
            }
            else{
                digits[i] = 0;
            }
        }

        int[] digits2 = new int[digits.Length + 1];
        digits2[0] = 1;
        return digits2;
    }
}
