namespace ArrayProblems
{
    // Given an array arr[] of n integers, construct a Product Array prod[] (of same size)
    // such that prod[i] is equal to the product of all the elements of arr[] except arr[i]. 
    // Solve it without division operator in O(n) time.
    // Input: arr[]  = {10, 3, 5, 6, 2}
    // Output: prod[]  = {180, 600, 360, 300, 900}
    // 3 * 5 * 6 * 2 product of other array
    // elements except 10 is 180
    // 10 * 5 * 6 * 2 product of other array
    // elements except 3 is 600
    // 10 * 3 * 6 * 2 product of other array
    // elements except 5 is 360
    // 10 * 3 * 5 * 2 product of other array
    // elements except 6 is 300
    // 10 * 3 * 6 * 5 product of other array
    // elements except 2 is 900
    public class ProductArrayPuzzle
    {
        // Has a runtime of O(n^2) as for producing one result
        // we loop the array twice, one in the main loop and other while multiplying.
        public int[] Solution1(int[] data)
        {
            int[] result = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                result[i] = SkipProduct(data, i);
            }
            return result;
        }

        // Try to produce results with less than O(n^2) runtime.
        // Approach is as per geeksforgeeks by creating two array: https://www.geeksforgeeks.org/a-product-array-puzzle/
        // It uses two arrays to compute temporary results which are later
        // used to compute the final result.
        public int[] Solution2(int[] data)
        {
            int N = data.Length;
            int[] result = new int[N];
            int[] left = new int[N];
            int[] right = new int[N];

            // Left most element of left array is always 1 
            left[0] = 1;

            // Rightmost element of right array is always 1
            right[N - 1] = 1;

            //Construct the left array
            for (int i = 1; i < N; i++)
            {
                left[i] = data[i - 1] * left[i - 1];
            }

            //Construct the right array
            for (int i = N - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * data[i + 1];
            }

            for (int i = 0; i < N; i++)
            {
                result[i] = left[i] * right[i];
            }
            return result;
        }

        // Solution 3: My approach using conditional statements to handle
        // zeroes in the array and set the result accordingly.
        // Runtime = O(n)
        public int[] Solution3(int[] data)
        {
            int N = data.Length;
            int[] result = new int[N];
            int totalProduct = SkipProductWithZero(data, out bool hasZeroes, out bool hasMultipleZeroes);
            for (int i = 0; i < N; i++)
            {
                if (hasMultipleZeroes) return result;
                result[i] = hasZeroes ? (data[i] == 0 ? totalProduct : 0) : (totalProduct / data[i]);
            }
            return result;
        }

        private int SkipProduct(int[] data, int skipIndex)
        {
            int result = 1;
            for (int i = 0; i < data.Length; i++)
            {
                if (i != skipIndex) result *= data[i];
            }
            return result;
        }

        private int SkipProductWithZero(int[] data, out bool hasZeroes, out bool hasMultipleZeroes)
        {
            int result = 1;
            int zeroCount = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != 0)
                {
                    result *= data[i];
                }
                else
                {
                    zeroCount++;
                }
            }
            hasZeroes = zeroCount > 0;
            hasMultipleZeroes = zeroCount > 1;
            return result;
        }
    }
}
