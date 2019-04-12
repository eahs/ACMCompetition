
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem7
    {
        // YYY and XZX not special?
        public static int CountFast(int len)
        {
            int x = 1, y = 1, z = 1;

            for (int ln = 1; ln < len; ln++)
            {
                int x2 = x, y2 = y, z2 = z;

                x = x2 + z2;
                y = x2 + y2;
                z = x2 + y2 + z2;
            }

            return x + y + z;
        }
        
        // Half credit way
        public static int Count(string word, int len)
        {
            if (word.Length == len)
            {
                if (word.Contains("XY") || word.Contains("YZ")) return 0;
                return 1;
            }

            int sum = 0;
            for (char k = 'X'; k <= 'Z'; k++)
            {
                sum += Count(word + k, len);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Sequence length: ");
            int len = Console.ReadLine().ToInteger();

            long sum = CountFast(len);

            Console.WriteLine("Number of special XYZ sequences: {0}", sum);

            // XX XZ YX YY ZX ZY ZZ

        }
    }
}
