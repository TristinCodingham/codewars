using System;
using System.Linq;

namespace playing_with_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            DigPow(92, 1);
        }

        static long DigPow(int n, int p)
        {
            double num = n.ToString()
                .ToCharArray()
                .Select(c => ( Math.Pow((c - 48), p++) ))
                .ToArray()
                .Sum();
            int k = n > num ? n / (int)num : (int)num / n;
            
            Console.WriteLine(k >= 1 && num == n * k ? k : -1);
            return k >= 1 && num == n * k ? k : -1;
        }
    }
}
