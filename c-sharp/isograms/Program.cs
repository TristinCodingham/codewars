using System;

namespace isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Dermatoglyphics";
            word = word.ToLower();
            bool output = true;
            for (int i = 0; i < word.Length; i++)
            {
                int count = 0;
                foreach (var letter in word)
                    if(word[i] == letter)
                        count++;
                if(count >= 2)
                    output = false;
            }
            Console.WriteLine(output);
            // return output;
        }
    }
}
