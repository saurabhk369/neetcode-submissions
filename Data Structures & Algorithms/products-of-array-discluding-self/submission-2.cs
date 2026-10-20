public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] products = new int[nums.Length];
        int totalProduct = 1;
        int zeroCount = 0;

        for(int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0)
                zeroCount++;
            else 
                totalProduct *= nums[i];
        }

        // Console.WriteLine($"Zero Count: {zeroCount}");
        // Console.WriteLine($"Total Prodcut: {totalProduct}");

        if (zeroCount > 1)
            return products;

        for(int i = 0; i < nums.Length; i++) {
            // Console.WriteLine($"Value at {i}: {nums[i]}");
            if (zeroCount == 1)
                products[i] = nums[i] == 0 ? totalProduct : 0;
            else
                products[i] = totalProduct / nums[i];
            // Console.WriteLine($"Product at {i}: {products[i]}");
        }

        return products;
    }
}
