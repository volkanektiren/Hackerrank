using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving
{
    public class BreakRecords
    {
        public static List<int> Compute(List<int> scores)
        {
            int leastCount = 0;
            int mostCount = 0;

            int leastScore = scores.First();
            int mostScore = scores.First();

            scores.RemoveAt(0);

            foreach (int score in scores)
            {
                if (score > mostScore)
                {
                    mostScore = score;
                    mostCount++;
                    continue;
                }
                if (score < leastScore)
                {
                    leastScore = score;
                    leastCount++;
                }
            }

            return new List<int> { mostCount, leastCount };
        }
    }
}
