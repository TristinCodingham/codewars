using System;
using System.Collections.Generic;
using System.Linq;

namespace descending_order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 73495;
            string answer = "";
            int[] intArr = num.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
            int maxIndex = 0;
            foreach (var memory in intArr)
            {
                int max = 0;
                for(int i = 0; i < intArr.Length; i++)
                {
                    if(intArr[i] == -1)
                        continue;
                    else if(intArr[i] > max)
                    {
                        max = intArr[i];
                        maxIndex = Array.IndexOf(intArr, intArr[i]);
                    }
                }
                answer += max;
                intArr[maxIndex] = -1;
            }
            Console.WriteLine(Convert.ToInt32(answer));
            //return answer
        }
    }
}
