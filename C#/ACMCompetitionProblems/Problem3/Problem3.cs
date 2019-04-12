using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem3
    {
        public static string getGrade (double num)
        {
            if (num >= 90) return "A";
            if (num >= 80) return "B";
            if (num >= 70) return "C";
            if (num >= 60) return "D";
            return "F";
        }

        static void Main(string[] args)
        {
            Console.Write("First three exam scores: ");
            List<int> scores = Console.ReadLine().ToIntegerList();

            int sum = scores.Sum();
            double highestAvg = (sum + 100) / 4.0;

            string grade = getGrade(highestAvg);

            if (grade == "F")
                Console.WriteLine("Skip the fourth exam");
            else
                for (int i = 0; i < 100; i++)
                {
                    string grade2 = getGrade((sum + i) / 4.0);
                    if (grade == grade2)
                    {
                        Console.WriteLine("Answer {0} questions on the last exam to earn a grade of {1}.", i, grade);
                        break;
                    }
                }
        }
    }
}