using System;

namespace MyFirstProgram
{
    class Program
    {
      static void Main(){
      Random random= new Random();
        bool playAgain=true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        String response;
        while(playAgain){
          guess=0;
          guesses=0;
          response="";
          number =random.Next(min,max+1);
          while(guess!=number){
            Console.WriteLine("Guess number between "+ min+"-"+max+ " : ");
            guess= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Guess " + guess);

            if(guess>number){
                           Console.WriteLine("Too hight");
            }
            else if(guess<number){
                           Console.WriteLine("Too Low");
            }
            guesses+=1;
          }
          Console.WriteLine("You win");
          Console.WriteLine("The number is "+ number);
          Console.WriteLine("Guesses: "+ guesses);

                      Console.WriteLine("Would you like to play again : (y/n)");
            response=Console.ReadLine();
            response= response.ToUpper();
          if(response=="Y"){
            playAgain= true;
          }
          else{
            playAgain=false;
          }
        }
         Console.WriteLine("Thank for playing");
            Console.ReadKey();
        }
    }
}