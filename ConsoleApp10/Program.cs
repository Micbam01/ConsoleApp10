using System;

namespace ConsoleApp3
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int i =0;
            Console.WriteLine("Odd Numbers:");
            for (i = 1; i <= 100; i++) 
            {
                if (i % 100 == 0) 
                {
                    Console.WriteLine(i +" ");
                }
            }
        }
    }
}
