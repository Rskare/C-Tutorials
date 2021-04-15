using System;

namespace ConstantsAndLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character Constants

            Console.WriteLine("Hello\tWorld\n\n");
            //output: Hello    World

            Console.WriteLine(@"""hello, dear""");
            Console.WriteLine("\"hello, dear\"");
            //output: "hello, dear"

            Console.WriteLine(@"""hello, \" + "\ndear\"");
            Console.WriteLine("\"hello, \\\ndear\"");
            //output: "hello, \
            //dear"

            Console.WriteLine(@"""hello, "" ""d"" ""ear""");
            Console.WriteLine("\"hello, \" \"d\" \"ear\"");
            //output: "hello, " "d" "ear"

            Console.WriteLine(@"@""hello dear""");
            Console.WriteLine("@\"hello dear\"");
            //output: @"hello dear"
            Console.ReadLine();


            //Defining Constants

            const double pi = 3.14159;

            // constant declaration 
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();


            //Bitwise Operators

            Console.WriteLine((5 && 4), 2);
        }
    }
}
