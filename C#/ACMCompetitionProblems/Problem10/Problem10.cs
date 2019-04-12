using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string of non-zero digits: ");
            string input = "987654321"; // Console.ReadLine();

            List<List<int>> solutions = new List<List<int>>();
            List<string> possible = Enumerable.Range(1, (int)Math.Pow(2, input.Length-1)-1).Select(n => n.ToBase(2).PadLeft(input.Length-1, '0')).ToList();
            possible.Reverse();

            foreach (String s in possible)
            {
                string num = "";
                for (int i = 0; i < input.Length; i++)
                {
                    num += input[i];
                    if (i != input.Length - 1 && s[i] == '1') num += ',';
                }
                List<int> nums = num.ToIntegerList(",");
                if (nums.IsIncreasing())
                {
                    solutions.Add(nums);
                }

            }

            solutions = solutions.OrderBy(n => n.Last()).ToList();

            Console.WriteLine(String.Join(", ", solutions[0]));

        }

    }
}
