using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.
*/

namespace ProblemSolving
{
    public class PlusMinus
    {
        public static void Compute(List<int> arr)
        {
            var size = (float)arr.Count;

            Console.WriteLine(((float)(arr.Where(x => x > 0).Count() / size)).ToString("0.000000"));
            Console.WriteLine(((float)(arr.Where(x => x < 0).Count() / size)).ToString("0.000000"));
            Console.WriteLine(((float)(arr.Where(x => x == 0).Count() / size)).ToString("0.000000"));
        }
    }
}
