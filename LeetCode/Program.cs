public class Solution
{
    static void Main()
    {
        SubstractProductAndSum(234);

        public int SubtractProductAndSum(int n)
        {
            string nString = Convert.ToString(n);
            char[] nChar = nString.ToCharArray();
            int prod = 0, sum = 0;

            for (int i = 0; i < nChar.Length; i++)
            {
                prod += nChar[i];
                sum += nChar[i];
            }

            return prod - sum;
        }

    }

}