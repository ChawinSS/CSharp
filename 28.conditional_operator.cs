using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           double temperature =20;
            String message;
          
        message = (temperature >=15) ? "Its warm outside" : "Its cold outside";

          Console.WriteLine("\n"+message);
            Console.ReadKey();
        }
    }
}