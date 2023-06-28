using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1232.Check_If_It_Is_a_Straight_Line
{
    internal class Program
    {
        #region Description
        /*
        You are given an array coordinates, coordinates[i] = [x, y], where [x, y] 
        represents the coordinate of a point. Check if these points make a straight 
        line in the XY plane. 
        */
        #endregion

        static void Main(string[] args)
        {
            int[][] coords = { 
                new int [] { 1, 2 },
                new int [] { 2, 3 },
                new int [] { 3, 4 },
                new int [] { 4, 5 },
                new int [] { 5, 6 },
                new int [] { 6, 7 }
                };

            Console.WriteLine(CheckStraightLine(coords));
            Console.ReadKey();


            bool CheckStraightLine(int[][] c)
            {
                if (c.Length == 2) 
                    return true;

                for (int i = 2;i < c.Length; i++)
                    if (!CheckNextPoint(c[i]))
                            return false;

                return true;

                bool CheckNextPoint(int[] newPoint)
                {
                    return ((newPoint[0] - c[0][0]) * (c[1][1] - c[0][1])) 
                        == ((newPoint[1] - c[0][1]) * (c[1][0] - c[0][0]));
                }
            }
        }

    }
}