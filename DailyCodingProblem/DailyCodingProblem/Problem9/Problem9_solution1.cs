namespace DailyCodingProblem.Problem9
{
    public class Problem9_solution1
    {
        public int solve(int[] array)
        {
            int previous = 0, largest = 0;
            foreach (var amount in array)
            {
                int tmpPrevious = largest;
                largest = Max(largest, previous + amount);
                previous = tmpPrevious;
            }
            return largest;
        }

        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
