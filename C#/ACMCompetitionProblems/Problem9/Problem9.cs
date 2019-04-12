using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter order and starting letter: ");
            List<string> input = Console.ReadLine().ToStringList();

            int order = Convert.ToInt32(input[0]);
            int start = (int)(input[1][0] - 'A');

            int[,] grid = new int[order, order];
            grid[0, 0] = start + 1; 

            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("{0} ", (char)(grid[i,j] + 'A' - 1));
                        continue;
                    }

                    List<int> row = ACM.GetRow(grid, i).ToList();
                    List<int> column = ACM.GetColumn(grid, j).ToList();

                    List<int> left = Enumerable.Range(1, order).Except(row).Except(column).ToList();

                    if (left.Count == 0)
                    {
                        // Done
                        return;
                    }

                    int result = left.Min();
                    
                    grid[i, j] = result;
                    Console.Write("{0} ", (char)(result + 'A' - 1));
                }
                Console.WriteLine();
            }
        }
    }
}