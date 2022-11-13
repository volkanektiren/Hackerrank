using System;
using System.Collections.Generic;

/*
 * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.
*/

namespace ProblemSolving
{
    public class MinMaxSum
    {
        public static void Compute(List<int> arr)
        {
            long minSum = 0;
            long maxSum = 0;

            arr.Sort();

            byte count = 0;
            foreach (var item in arr)
            {
                var index = arr.FindIndex(match: x => x == item, startIndex: count++);

                if (index != 4) minSum += item;
                if (index != 0) maxSum += item;
            }

            Console.Write($"{minSum} {maxSum}");
        }
    }
}
