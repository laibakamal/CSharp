//lec 5
//string formatting

using System;
using System.Collections.Generic;
using System.Text;

namespace EAD_Lec5
{
    class Selectors
    {
        static void Main(string[] args)
        {
            //formatting output using positional arguments
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bCount = 56789;

            Console.WriteLine(
                format: "{0} {1}",
                arg0: "Name",
                arg1: "Count");

            Console.WriteLine(
    format: "{0} {1}",
    arg0: bananasText,
    arg1: bCount);

            Console.WriteLine(
    format: "{0} {1}",
    arg0: applesText,
    arg1: applesCount);

            //to separate thousands by commas, add N0 to arg 1
            Console.WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: "Name",
    arg1: "Count");

            Console.WriteLine(
    format: "{0,-8} {1,7:N0}",
    arg0: bananasText,
    arg1: bCount);

            Console.WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);


            //to left or right aligh text, add -ve number with arg 0 to left aligh and +ve to right align to arg 1

            Console.WriteLine(
format: "{0,-8} {1,6:N0}",
arg0: "Name",
arg1: "Count");

            Console.WriteLine(
    format: "{0,-8} {1,7:N0}",
    arg0: bananasText,
    arg1: bCount);

            Console.WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);


            //if (args.Length == 0)
            //{
            //    Console.WriteLine("There are no arguments.");
            //}
            //else if (args.Length >= 2)
            //{
            //    Console.WriteLine("There is at least two argument.");
            //}
            ////else {
            ////    Console.WriteLine("There is at least one argument.");
            //// }
        }
    }
}
