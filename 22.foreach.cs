using System;
// less flexible
class Program 
{
    static void Main() 
  {
      String[] cars ={"BMW","Mustang","corvett"};

      foreach(String car in cars)
      {
        Console.WriteLine(car);
      }
        
        Console.ReadKey();
    }
}