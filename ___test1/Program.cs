namespace ___test1
{
    using System;

    public class Program
    {
        public static bool CanMake33(int x, int y)
        {
            return (x == 33 || y == 33 || x + y == 33 || x - y == 33);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(CanMake33(22, 11)); // Output: false
            Console.WriteLine(CanMake33(33, 100)); // Output: true
            Console.WriteLine(CanMake33(10, 23)); // Output: false
            Console.WriteLine(CanMake33(9, 9)); // Output: true
            Console.WriteLine();
        }
    }
}