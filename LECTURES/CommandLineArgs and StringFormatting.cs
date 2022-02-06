//lec 4
//command line arguments
//string formatting


using System;

namespace EAD_Lec4
{
    class Program
    {
        static void Main(string[] args)
        {

            //COMMAND LINE
            Console.WriteLine(args.Length);
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);

            //can also be done using command prompt
            //steps // enter path of your project folder...............


            //FORMATTING
            int numberofapples = 12;
            decimal priceperapple = 0.35M;

            //simple using +
            Console.WriteLine(numberofapples + " apples costs " +
                (numberofapples * priceperapple));

            ////Formatting output using interpolated strings
            Console.WriteLine($"{numberofapples} apples costs {numberofapples * priceperapple:C}");

            ////using numbered positional arguments
            //1-
            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberofapples,
                arg1: priceperapple * numberofapples
                );

            //2-
            //using format method
            string formattedString = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberofapples,
                arg1: priceperapple * numberofapples
                );
            Console.WriteLine(formattedString);



            //ReadKey
            Console.Write("Press any key combination: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(
                format: "key: {0}, Char: {1}, Modifier: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
                );
        }
    }
}
