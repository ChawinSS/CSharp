using System;

class Program 
{
    static void Main() 
  {
      String[] cars =new String[3];

      cars[0]="a";
      cars[1]="b";
      cars[2]="c";
    
      for(int i=0;i<cars.Length;i++){
        Console.WriteLine(cars[i]);
      }
        
        Console.ReadKey();
    }
}