using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main()
        {
    Console.WriteLine("Enter First side");
    double a= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Second side");
    double b= Convert.ToDouble(Console.ReadLine());
    
    double c= Math.Sqrt((a*a)+(b*b));
    
    Console.WriteLine("The hypothenuse is "+c);
    
            Console.ReadKey();
        }
    }
}