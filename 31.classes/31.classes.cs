using System;

class Program {
    static void Main() {

      Messages.Hello();
      
      Console.ReadKey();
    }
}

class Messages
{
  void Hello()
  {
    Console.WriteLine("Hello Welcome");
  }

    void Waiting()
  {
    Console.WriteLine("I am waiting");
  }
      void Bye()
  {
    Console.WriteLine("Thank bye");
  }
}