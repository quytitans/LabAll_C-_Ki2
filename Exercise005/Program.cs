using System;

namespace Exercise005
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 1 to 20: ");
            var a = Int32.Parse(Console.ReadLine());
            var result = 1; 
            for (int i = 1; i < a+1; i++)
            {
                result = result *i ;
            }

            Console.WriteLine("resuilt is : {0}", result);
            Console.ReadLine();
        }
    }
}