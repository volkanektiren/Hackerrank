using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving
{
    public class SparseArrays
    {
        public static List<int> Compute(List<string> strings, List<string> queries)
        {
            var result = new List<int>();

            foreach (string q in queries)
            {
                result.Add(strings.Where(x => x.Equals(q)).Count());
            }

            return result;
        }
    }
}
