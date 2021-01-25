using System;

namespace WalkingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] walk = {"w","e","w","e","w","e","w","e","w","e","w","e"};
            Direction point = new Direction();
            foreach (var dir in walk)
            {
                switch (dir)
                {
                    case "n":
                        point.y++;
                        break;
                    case "s":
                        point.y--;
                        break;
                    case "e":
                        point.x++;
                        break;
                    case "w":
                        point.x--;
                        break;
                    default:
                        break;
                }
            }
            bool isTenMinWalk = (walk.Length == 10 && (point.x == 0) && (point.y == 0));
            System.Console.WriteLine($"{point.x}, {point.y}");
            System.Console.WriteLine(isTenMinWalk);
            
        }

        class Direction
        {
            public int x = 0;
            public int y = 0;
        }
    }
}
