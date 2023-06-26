using System;

class Program {
  
    static void Main() 
  {
      String name="chawin";
      int age=21;
    
      hbdfunction(name, age);
      
    Console.WriteLine(" ");
      hbdfunction(name, age);
    }
  static void hbdfunction(String name, int age){
            Console.WriteLine("Hello, happybirth day!");
            Console.WriteLine("Happybirth day!");
            Console.WriteLine("Happybirth day! " + name +" "+age);
  }
}