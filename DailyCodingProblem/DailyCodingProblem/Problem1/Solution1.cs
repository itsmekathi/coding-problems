namespace DailyCodingProblem
{
    // Given a list of numbers, return whether any two sums to k.
    // For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
    public class Solution1
    {
        public bool Solve(int[] values, int k)
        {
            bool result = false;
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] + values[i + 1] == k)
                {
                    result = true;
                    break;
                }

            }
            return result;
        }
    }
}
