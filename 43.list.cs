﻿using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program 
    {
        static void Main(string[] args)
        {

            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size 
            //        using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            Console.WriteLine(food[0]+"\n");

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            Console.WriteLine(food.Count+"\n");
            Console.WriteLine(food.IndexOf("pizza")+"\n");
            
          Console.WriteLine(food.LastIndexOf("fries")+"\n");
            Console.WriteLine(food.Contains("pizza")+"\n");
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();
          
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}