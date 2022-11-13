using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolving
{
    public class CamelCase4
    {
        public static void Compute()
        {
            var read = Console.ReadLine();

            while (read != null)
            {
                var input = read.Split(';').ToList();

                var operation = input.First();
                input.RemoveAt(0);

                var type = input.First();
                input.RemoveAt(0);

                var content = Regex.Replace(input.First(), @"(!/[()]/g)", "$1");
                if (operation.Equals("S"))
                {
                    if (type.Equals("M"))
                    {
                        content = content.TrimEnd(new char[2] {'(', ')'});
                    }
                    else if (type.Equals("C"))
                    {
                        Console.Write(char.ToLower(content.First()));
                        content = content.Remove(0, 1);
                    }

                    foreach (var c in content)
                    {
                        if (char.IsUpper(c)) Console.Write(" " + char.ToLower(c));
                        else Console.Write(c);
                    }
                }
                else if (operation.Equals("C"))
                {
                    
                    if (type.Equals("C"))
                    {
                        Console.Write(char.ToUpper(content.First()));
                        content = content.Remove(0, 1);
                    }

                    var afterSpace = false;
                    foreach (var c in content)
                    {
                        if (c.Equals(' ')) afterSpace = true;
                        else if (afterSpace)
                        {
                            Console.Write(char.ToUpper(c));
                            afterSpace = false;
                        }
                        else Console.Write(c);
                    }

                    if (type.Equals("M"))
                    {
                        Console.Write("()");
                    }
                }

                Console.WriteLine();

                read = Console.ReadLine();
            }
        }
    }
}
