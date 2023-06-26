using System;

class Program
{
    static void Main() {
        Console.WriteLine("Please enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        if(age>=100)
        {
        Console.WriteLine("Du bist too old");
        }
        else if(age>=18)
        {
        Console.WriteLine("Du bist adult");
        }
        else if(age<0)
        {
        Console.WriteLine("Du bist Babe");
        }
        else
        {
        Console.WriteLine("You need to be 18 to go in");
        }
            Console.ReadKey();
    }
}