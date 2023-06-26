using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // logical operators = Can be used to check if more than 1 condition is true/false

            // && (AND)
            // || (OR)

            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();

          while(name==""){
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
          }
            Console.WriteLine("Hello " + name);
          
            Console.ReadKey();
        }
    }
}