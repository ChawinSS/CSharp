using System;

class Program
{
    static void Main() {
        Console.WriteLine("Please enter date: ");
        String date = Console.ReadLine();

      switch(date){
      case "monday":
        Console.WriteLine("monday");
        break;
      case "tuesday":
        Console.WriteLine("tuesday");
        break;
      case "wednesday":
        Console.WriteLine("wednesday");
        break;

      default:
        Console.WriteLine("Error");
        break;
      }
      
    
            Console.ReadKey();
    }
}