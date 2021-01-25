using System;
using System.Collections.Generic;
using System.Linq;

namespace reverse_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This  is an example!";
            string[] answer = str.Split(" ").Select(c => new string(c.Reverse().ToArray())).ToArray();
            Console.WriteLine(string.Join(" ", answer).TrimEnd());
            //return string.Join(" ", answer).TrimEnd();
        }
    }
}
