using System;

namespace MyFirstProgram
{
    class Program 
    {
        static void Main(string[] args)
        {

            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
                                                   { "Corvette", "Camaro", "Silverado" }, 
                                                   { "Corolla", "Camry", "Rav4" } 
                                                 };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            

            Console.ReadKey();
        }
    }
}