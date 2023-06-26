using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants  = immutable values which are known at compile time
            //              and do not change for the life of the program

            double a = 3.14;

            int b=Convert.ToInt32(a);

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            
            int c = 123;
            double d = Convert.ToDouble(c)+0.1;

            Console.WriteLine("\n"+c);
            Console.WriteLine(c.GetType());
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            int e = 321;
            String f = Convert.ToString(e);
            
            Console.WriteLine("\n"+e);
            Console.WriteLine(e.GetType());
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            String g="$";
            char h= Convert.ToChar(g);
            
            Console.WriteLine("\n"+g);
            Console.WriteLine(g.GetType());
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());
            
            String i = "true";
            bool j = Convert.ToBoolean(i);
            
            Console.WriteLine("\n"+i);
            Console.WriteLine(i.GetType());
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}