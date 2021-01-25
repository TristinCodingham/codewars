using System;

namespace summation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int answer = 0;
            for(int i = 1; i <= num; i++)
            {
                answer += i;
            }
            Console.WriteLine(answer);
            //return answer;
        }
    }
}
