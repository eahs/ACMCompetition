using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dimensions of cake: ");
            List<int> dims = Console.ReadLine().ToIntegerList();

            Console.WriteLine("Cake on day 1: {0} {1}", dims[0], dims[1]);

            int day = 2;
            while (true)
            {
                int min = (int)Math.Min(dims[0], dims[1]);

                if (dims[0] > dims[1])
                    dims[0] -= min;
                else
                    dims[1] -= min;

                dims.Sort();

                if (dims[0] == 0 || dims[1] == 0)
                {
                    Console.WriteLine("Cake on day {0}: gone", day);
                    break;
                }
                else
                    Console.WriteLine("Cake on day {0}: {1} {2}", day, dims[0], dims[1]);
                day++;
            }
        }
    }
}
