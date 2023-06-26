using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args) {


            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

          for(int i=0;i<3;i++){
          Console.WriteLine(garage[i].model);
            }

            Console.ReadKey();
        }   
    }
    class Car 
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}