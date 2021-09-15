using Excercise01;
using System;

namespace Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Excercise 02==");

            string Number = "";

            Console.WriteLine("Enter your number: ");
            Number = Console.ReadLine().ToString().Replace(",","");

            Console.WriteLine("Your number in words: \n"+ Excercise.Towards(Convert.ToInt64(Number)));
            Console.ReadLine();
        }
    }
}
