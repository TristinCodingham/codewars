using System;

namespace find_odd_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 1,1,2,-2,5,2,4,4,-1,-2,5 };
            int oddNumber = seq[0];
            for (int i = 0; i < seq.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < seq.Length; j++)
                {
                    if(i != j && seq[i] == seq[j])
                        count++;
                    else if(seq[j] == 1 || seq[j] == -1)
                        oddNumber = seq[j];
                    if(count > 1 && count != 2 && (count % 2 != 0))
                        oddNumber = seq[j];
                }
            }
            Console.WriteLine(oddNumber);
            // return oddNumber;
        }
    }
}
