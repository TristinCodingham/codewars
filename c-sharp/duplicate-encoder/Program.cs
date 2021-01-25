using System;

namespace duplicate_encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "recede";
            word += word.ToLower();
            string output = "";
            for (int i = 0; i < word.Length; i++)
            {
                int count = 0;
                foreach (var letter in word)
                    if(word[i] == letter)
                        count++;
                if(count <= 1)
                    output += "(";
                else if(count >= 2)
                    output += ")";
            }
            Console.WriteLine(output);
            // return output;
        }
    }
}
