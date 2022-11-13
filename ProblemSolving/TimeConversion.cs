using System;

/*
 * Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
 */

namespace ProblemSolving
{
    public class TimeConversion
    {
        public static string Compute(string s)
        {
            return DateTime.Parse(s).TimeOfDay.ToString();
        }
    }
}
