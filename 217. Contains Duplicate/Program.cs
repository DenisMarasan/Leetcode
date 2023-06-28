using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217.Contains_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsDuplicate(ints));
            Console.WriteLine(ContainsDuplicate2(ints));
            Console.WriteLine(ContainsDuplicate3(ints));
            Console.ReadKey();
                        
            bool ContainsDuplicate(int[] nums)
            {
                var hs = new HashSet<int>(nums);

                return nums.Length > hs.Count;
            }

            bool ContainsDuplicate2(int[] nums) => nums.Length > new HashSet<int>(nums).Count();

            bool ContainsDuplicate3(int[] nums) => nums.Length > nums.GroupBy(x => x).Count();

        }
    }
}
