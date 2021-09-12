using System;

namespace Excercise002
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find bigest number !!!!");
            Console.WriteLine("Enter fist number: ");
            var a = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter second number: ");
            var b = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter third number: ");
            var c = Int32.Parse(Console.ReadLine());
            var d = a;
            if (d < b)
            {
                d = b;
            }
            if (d < c)
            {
                d = c;
            }

            Console.WriteLine("the maximum number is: {0}", d);
            Console.ReadLine();
        }
    }
}