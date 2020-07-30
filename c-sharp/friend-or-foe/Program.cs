using System;
using System.Linq;
namespace friend_or_foe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"John", "Randy", "Randal", "Lias"};
            int arrSize = 0;
            foreach (var name in names)
            {
                if(name.Length == 4)
                    arrSize++;
            }
            
            string[] shortNames = new string[arrSize];
            int count = 0;
            foreach (var name in names)
            {
                if(name.Length == 4) {
                    shortNames[count] = name;
                    count++;
                }
            }
            System.Console.WriteLine(shortNames);
        }

        // static string[] GetShortNames(string[] names) {
        //     foreach (var name in names) => name.Length == 2;
        // }
        
        // static string[] GetNames(string[] names) {
        //     string[] shortNames = new string[names.Length];
        //     int count = 0;
        //     foreach (var name in names)
        //     {
        //         if(name.Length == 4) {
        //             shortNames[count] = name;
        //             count++;
        //         }
        //     }
        //     return shortNames;
        // }
    }
}
