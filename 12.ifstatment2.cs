using System;

class Program
{
    static void Main() {
        Console.WriteLine("Please enter name: ");
        String name = Console.ReadLine();
        
        if(name=="")
        {
        Console.WriteLine("Eneter something pls");
        }
        else
        {
        Console.WriteLine("Hello " + name);
        }
            Console.ReadKey();
    }
}