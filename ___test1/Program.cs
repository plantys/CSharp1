namespace ___test1
{
    using System;

    public class Program
    {
        public static bool CanMake33(int x, int y)
        {
            return (x == 33 || y == 33 || x + y == 33 || x - y == 33);
        }
        /*
        2 socks
        int[] distinctIntegers = ar.Distinct().ToArray();
int[] counts = distinctIntegers.Select(x => ar.Count(y => y == x)).ToArray();
int[] counts1 = counts.Select(x => x / 2).ToArray();
int counts3 = counts1.Sum();
return counts3;



        */
        public static void Main(string[] args)
        {
            Console.WriteLine(CanMake33(22, 11)); // Output: false
        }
    }
}