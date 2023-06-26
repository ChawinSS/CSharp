using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num1 = random.Next(1, 7);//dice 1-6
            int num2 = random.Next(1, 21);//dice 1-21

            double num = random.NextDouble();// drandom in decimal from 0-1

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}