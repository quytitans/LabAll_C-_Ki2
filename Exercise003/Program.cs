using System;

namespace Exercise003
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger from 1 - 7 : ");
            var a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("today is Monday");
                    break;
                case 2:
                    Console.WriteLine("today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("today is Friday");
                    break;
                case 6:
                    Console.WriteLine("today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("today is Sunday");
                    break;
                
            }
        }
    }
}