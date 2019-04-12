using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem8
    {
        static void Main(string[] args)
        {
            Console.Write("How many boxes? ");
            int boxes = Console.ReadLine().ToInteger();

            List<int> boxHeights = new List<int>();

            int remaining = boxes;
            while (remaining > 0)
            {
                int height = (int)Math.Sqrt(remaining);  // get the highest odd sqrt

                if (height % 2 == 0 && height != 2) height--;

                boxHeights.Add(height);

                remaining -= (height*height);
            }

            int max = boxHeights.Max();
            List<string> output = new List<string>();

            for (int i = 0; i < max; i++)
            {
                string line = "";
                foreach (int height in boxHeights)
                {
                    if (i < height)
                    {
                        line += "".PadLeft(i, ' ') + "".PadLeft((height-i) * 2 - 1, '#') + "".PadLeft(i, ' ') + " ";
                    }
                }
                output.Insert(0, line);

            }

            foreach (string line in output)
            {
                Console.WriteLine(line);
            }
        }
    }
}