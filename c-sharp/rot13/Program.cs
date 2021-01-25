using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "abcdefghijklmnopqrstuvwxyz";
            char[] messageArr = message.ToCharArray();
            List<char> output = new List<char>();

            string alphabetStr = "abcdefghijklmnopqrstuvwxyz";
            foreach (var letter in messageArr)
            {
                if(Char.IsWhiteSpace(letter))
                    output.Add(' ');
                else if(!Char.IsLetter(letter))
                    output.Add(letter);
                else if(Char.IsLetter(letter))
                {
                    int position = (alphabetStr.IndexOf(letter.ToString().ToLowerInvariant()));
                    int index = position + 13;
                    char rot13;
                    if(index >= 26)
                        index -= 26;
                    if(Char.IsUpper(letter))
                        rot13 = Char.ToUpper(alphabetStr[index]);
                    else
                        rot13 = Char.ToLower(alphabetStr[index]);
                    output.Add(rot13);
                }
                
            }
            string final = string.Join("", output);
            System.Console.WriteLine(final);
        }
    }
}
