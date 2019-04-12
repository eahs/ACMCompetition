using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem5
    {
        // Dynamic Programming - Reusing your results
        public static Dictionary<string, long> solutions = new Dictionary<string, long>();

        public static long findWays (int rolls, int sum)
        {
            long total = 0;
            string key;

            if (sum <= 0)
                return 0;

            if (rolls == 1 && sum <= 6)
            {
                total = 1;
            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    key = (rolls - 1) + "," + (sum - i);

                    if (solutions.ContainsKey(key))
                        total += solutions[key];
                    else
                        total += findWays(rolls - 1, sum - i);
                }
            }

            key = rolls + "," + sum;
            solutions[key] = total;

            return total;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter number of rolls and target sum: ");
            List<int> nums = Console.ReadLine().ToIntegerList();

            int n = nums[0], s = nums[1];

            long ways = findWays(n, s);
            Console.WriteLine("Number of {0}-roll sequences summing to {1}: {2}", n, s, ways);
        }
    }
}
