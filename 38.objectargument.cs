using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args) {

            Car car1 = new Car("Mustang","red");

            ChangeColor(car1,"Silver");

            Console.WriteLine(car1.color + " " + car1.model);

            Console.ReadKey();
        }

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }
    }
    class Car 
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}