using System.Collections.Generic;

namespace ProblemSolving
{
    public class FineMedian
    {
        public static int Compute(List<int> arr)
        {
            arr.Sort();
            return arr[arr.Count/2];
        }
    }
}
