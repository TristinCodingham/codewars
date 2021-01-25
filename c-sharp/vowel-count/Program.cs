using System;
using System.Linq;

namespace vowel_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "become a legend";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                    default: continue;
                }
            }
            Console.WriteLine(count);
            //return count;
        }
    }
}
