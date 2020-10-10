using System;
using System.Linq;


/// <summary>
/// 
/// </summary>
/// 
// Problem description
// Given an array of integers, find the first missing positive integer in linear time and constant space.
// In other words, find the lowest positive integer that does not exist in the array.
// The array can contain duplicates and negative numbers as well.
// For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
namespace DailyCodingProblem.Problem4
{
    public class Problem4_Solution1
    {
        public int Solve(int[] input)
        {
            int result = 0;

            var min = input.Min();
            var max = input.Max();
            for (int i = min; i <= max + 1; i++)
            {
                if (!input.Contains(i + 1))
                {
                    result = i + 1;
                    break;
                }
            }
            return result;
        }
    }
}
