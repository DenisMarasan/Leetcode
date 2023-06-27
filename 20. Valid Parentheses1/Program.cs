using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "([))]{}";
            Console.WriteLine(IsValid(a));
            Console.ReadKey();
        
            
             bool IsValid(string s)
             {
                if (s.Length % 2 != 0)
                    return false;

                var stack = new Stack<char>();

                foreach (char p in s)
                {
                    char q = ' ';

                    if (p == '(' || p == '[' || p == '{')
                    {
                        stack.Push(p);
                        continue;
                    }

                    if (p == ')' || p == ']' || p == '}')
                    {
                        if (stack.Count == 0)
                            return false;

                        q = stack.Peek();
                    }

                    if (p == ')' && q == '(' || p == ']' && q == '[' || p == '}' && q == '{')
                        stack.Pop();
                    else 
                        return false;
                }

                if (stack.Count != 0)
                    return false;

                return true;
             }
        }
    }
}
