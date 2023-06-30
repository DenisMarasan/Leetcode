using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Roman_to_Integer
{
    internal class Program
    {
        /*
        Given a roman numeral, convert it to an integer.

        Constraints:

        1 <= s.length <= 15
        s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
        It is guaranteed that s is a valid roman numeral in the range [1, 3999].
        */

        static void Main(string[] args)
        {
            string str = "MCMXCIV";
            Console.WriteLine($"{str} = {RomanToInt(str)}");
            Console.ReadLine();
            
            int RomanToInt(string s)
            {
                var values = new Dictionary<char, int>()
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 }

                };

                int total = 0;

                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (values[s[i]] >= values[s[i + 1]])
                        total += values[s[i]];
                    else
                        total -= values[s[i]];
                }

                total += values[s[s.Length - 1]]; //adding the last digit to total

                return total;
             }
        }
    }
}