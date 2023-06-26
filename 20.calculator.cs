using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
          do{
           double num1=0, num2=0, result=0;
          Console.WriteLine("Please enter num 1: "); 
          num1= Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Please enter num 2: "); 
          num2= Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter operation(+-*/): "); 

          switch(Console.ReadLine()){
          case "+":
            result= num1+num2;
            Console.WriteLine($"your result{num1} plus {num2} is : "+ result);
            break;

          case "-":
            result= num1-num2;
            Console.WriteLine($"your result{num1} minus {num2} is : "+ result);
            break;

          case "*":
            result= num1*num2;
            Console.WriteLine($"your result{num1} multiply {num2} is : "+ result);
            break;

          case "/":
            result= num1-num2;
            Console.WriteLine($"your result{num1} divide {num2} is : "+ result);
            break;
            
          default: 
            Console.WriteLine("Invalid operation");
            break;
          }

            Console.WriteLine("Would you like to play agin? (Y/N)");
            }while(Console.ReadLine().ToUpper()=="Y");
          
          Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}