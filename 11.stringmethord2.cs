using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main()
        {
            String phoneNumber= "123-456-789";
            phoneNumber=phoneNumber.Replace("-","/");
            
            Console.WriteLine(phoneNumber);

            Console.ReadKey();
        }
    }
}