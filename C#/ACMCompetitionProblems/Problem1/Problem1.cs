using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 3-digit number: ");
            //List<int> nums = Console.ReadLine().ToInteger().ToIntegerList();
            List<int> nums = Console.ReadLine().PadLeft(3, '0').ToCharArray().Select(n => Convert.ToInt32(n + "")).ToList();
         
            nums.Sort();
            int x = nums[0] * 100 + nums[1] * 10 + nums[2];
            int y = nums[2] * 100 + nums[1] * 10 + nums[0];
            int z = nums[1] * 100 + nums[1] * 10 + nums[1];

            Console.WriteLine("Good luck: {0}", x + y - z);
        }
    }
}
