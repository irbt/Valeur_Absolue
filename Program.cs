using System;
// See https://aka.ms/new-console-template for more information

namespace exoCSharp
{

    class ValAbsTask
    {
        static int ValAbs (int number)
        {
            
            return number>= 0 ? number : number * -1;
        }

        static void Main(string[] args)
        {
Console.WriteLine("Given an integer, write a method that returns its absolute value.");
            Console.WriteLine(ValAbs(654));
            Console.WriteLine(ValAbs(-54));
            Console.WriteLine(ValAbs(0));
            Console.WriteLine(ValAbs(-69046354));
        }

    }
}

