using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            int len = 4;
            for (int i = 0; i < 50; i++)
            {
                if (i * 4 - 4 >= input.Length)
                {
                    len = i;
                    break;
                }
            }

            Console.WriteLine(input.Substring(0, len));
            input = input.PadRight(len * 4 - 4, ' ');

            string second = input.Substring(len, len - 2);
            string fourth = input.Substring(len + len - 2 + len, len-2).Reverse();
            string third = input.Substring(len + len - 2, len).Reverse();

            for (int i = 0; i < len-2; i++)
            {
                Console.WriteLine("{0}{1}{2}", fourth[i], "".PadLeft(len - 2, ' '), second[i]);
            }   
            Console.WriteLine(third);
        }
     }
}