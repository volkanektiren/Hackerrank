using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving
{
    public class DivisibleSumPairs
    {
        public static int Compute(int n, int k, List<int> ar)
        {
            int count = 0;

            for (int i = 0 ; i < ar.Count ; i++)
            {
                int startIndex = i + 1;
                count += ar.GetRange(startIndex, ar.Count - startIndex).Where(j => (ar[i] + j) % k == 0).Count();
            }

            return count;
        }
    }
}
