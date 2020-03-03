using System;

namespace Laba1e
{
    class Program
    {
        static public int Example(int x)
        {
            double n = Math.Pow(x, 3) - (4 * Math.Pow(x, 2)) - (5 * x) + 9 + Math.Cos(x);
            Console.WriteLine("y =" + n.ToString());
            return x;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            string s1 = Console.ReadLine();
            int x = int.Parse(s1);
            Example(x);
            Console.ReadLine();
        }
    }
}
