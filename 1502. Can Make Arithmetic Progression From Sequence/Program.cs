using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1502.Can_Make_Arithmetic_Progression_From_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 2, 4 };
            Console.WriteLine(CanMakeArithmeticProgression(array));
            Console.ReadLine();

            bool CanMakeArithmeticProgression(int[] arr)
            {
                Array.Sort(arr);

                int step = arr[1] - arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                    if (arr[i + 1] - arr[i] != step)
                        return false;

                return true;
            }
        }
    }
}
