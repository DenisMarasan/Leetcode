using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "museuwzbczdejn";
            string str = "lwcjjuasgydqamj";
            Console.WriteLine(LengthOfLongestSubstring(str));
            Console.ReadKey();

            int LengthOfLongestSubstring(string s)
            {
                int pointer = 0;
                int currLength = 0;
                int maxLength = 0;
                string maxString = null;

                var hs = new HashSet<char>();


                Iterate();

                void Iterate()
                {
                    for (int i = pointer; i < s.Length; i++)
                    {
                        Console.WriteLine($"pointer = {pointer}, " +
                            $"currLength = {currLength}, " +
                            $"maxLength = {maxLength}, " +
                            $"s[i] = {s[i]}, " +
                            $"maxString = {maxString}");

                        hs.Add(s[i]);
                        currLength++;

                        if (hs.Count == currLength)
                        {
                            if (currLength > maxLength)
                            {
                                maxLength = currLength;
                                maxString = string.Join("", hs);
                            }

                            continue;
                        }

                        hs.Clear();
                        currLength = 0;
                        pointer++;

                        if (pointer == s.Length)
                            break;

                        Iterate();
                    }
                }

                return maxLength;
            }
        }
    }
}