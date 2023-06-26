using System;

namespace MyFirstProgram
{
    class Program
    {
      static void Main(){
      Console.WriteLine("How many row");
      int rows = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("How many column");
      int columns = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("What symbol");
      String symbol = Console.ReadLine();
      Console.Write("\n");
      for(int i=0; i<rows;i++){
        for(int j=0; j< columns;j++){
          Console.Write(symbol);
        }
                  Console.Write("\n");
      }
            Console.ReadKey();
        }
    }
}