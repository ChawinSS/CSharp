using System;

class Program 
{
    static void Main() 
  {
      String[] cars ={"BMW","Mustang","corvett"};

    cars[0]="Tesla";
    
        Console.WriteLine(cars[0]);
        Console.WriteLine(cars[1]);
        Console.WriteLine(cars[2]);
        
        Console.ReadKey();
    }
}