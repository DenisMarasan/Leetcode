using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217.Contains_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsDuplicate(ints));
            Console.WriteLine(ContainsDuplicate2(ints));
            Console.WriteLine(ContainsDuplicate3(ints));
            Console.ReadLine();


            bool ContainsDuplicate(int[] nums)
            {
                HashSet<int> set = new HashSet<int>(nums);

                return set.Count < nums.Length;
            }

            bool ContainsDuplicate2(int[] nums) => nums.Length > nums.GroupBy(x => x).Count();

            bool ContainsDuplicate3(int[] nums) => nums.Length > new HashSet<int>(nums).Count();
        }
    }
}
