// A Hello World! program in C#.
using System;

namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            Console.WriteLine("Hello World!");
            
            // Keep the console window open in debug mode.
            int a = 2 + 2;
            Console.WriteLine("{0}Press any key to exit.",a);
            Console.ReadKey();
        }
    }
}
