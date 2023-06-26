using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza pizza1 = new Pizza("stuffed crust");

            Pizza pizza2 = new Pizza("stuffed crust", "red sauce");
            Pizza pizza3 = new Pizza("stuffed crust", "red sauce", "mozzarella");

            Pizza pizza4 = new Pizza("stuffed crust", "red sauce", "mozzarella","extra salami");

            Console.ReadKey();
        }   
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;
        String topping2;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
              public Pizza(String bread, String sauce, String cheese, String topping, String topping2)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
            this.topping2 = topping2;
        }
    }
}