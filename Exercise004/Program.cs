using System;

namespace Exercise004
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter N: ");
            var n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("results: ");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, n, n*i);
            }

            Console.ReadLine();

        }
    }
}