namespace DailyCodingProblem.Problem2
{
    public class Problem2_Solution1
    {
        public int[] ApplyLogic(int[] input)
        {
            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int computedValue = 1;
                for (int j = 0; j < input.Length; j++)
                {
                    if (i == j) continue;
                    computedValue *= input[j];
                }
                result[i] = computedValue;
            }
            return result;
        }
    }
}
