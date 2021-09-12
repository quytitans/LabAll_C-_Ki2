using System;
using System.Runtime.InteropServices;

namespace Exercise001
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            var address = Console.ReadLine();
            Console.WriteLine("Please enter your phone: ");
            var phone = Console.ReadLine();
            Console.WriteLine("Name is {0}, Address is {1}, Phone number is {2}", name, address, phone);
            Console.ReadLine();
        }
    }
}