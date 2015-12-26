using System;

namespace HelloGoodbye.ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            while (Console.ReadLine() != "Hello")
            {
                Console.WriteLine("Say that again.");
            }
            Console.WriteLine("Goodbye");
        }
    }
}
