using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace ACMCompetition
{
    class Problem4
    {
        static string translate (String word)
        {
            if (word.Length <= 2) return word;

            string word2;
            string prefix = word[0] + "";

            int count = 0;
            for (int i = 1; i < word.Length - 1; i++)
            {
                if (i == 1 && !"aeiouAEIOU".Contains(word[i]))
                {
                    prefix += word[i];
                    continue;
                }
                
                count++;
            }

            word2 = prefix + count + word[word.Length - 1];

            if (word2.Length < word.Length) return word2;
            return word;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            String accum = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    accum += input[i];
                }
                else
                {
                    if (accum.Length != 0)
                    {
                        Console.Write(translate(accum));
                        accum = "";
                    }
                    Console.Write(input[i]);
                }
            }
            if (accum.Length != 0)
            {
                Console.WriteLine(translate(accum));
            }

        }
    }
}