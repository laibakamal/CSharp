//lec 7
//implicit type casting
//explicit type casting
//using System.Convert method.
//rounding rules
//interconversion of string and other data types
//exception handling
//checked keyword

using System;

namespace Lecture_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //TYPECASTING
            //implicit
            // a smaller data type can be converted to a larger datatype using implicit typecasting 
            int a = 10;
            double b = a; // an int can be safely cast into a double
            Console.WriteLine(b);

            //explicit 
            double c = 9.8;
            // a larger data type can not be converted to smaller datatype using implicit type casting
            //int d = c; // compiler gives an error for this line
            int d = (int)c;  // d is 9 losing the .8 part
            Console.WriteLine(d);//floor value (9) will be displayed

            // Converting types using System.Convert method.
            double g = 9.8;
            int h = System.Convert.ToInt32(g);//h= ceiling valuee of 9.8 which is 10
            Console.WriteLine($"g is {g} and h is {h}");


            //Understanding rounding rule.//explained in comment below
            double[] doubles = new[]
                       { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (double n in doubles)
            {
                Console.WriteLine($"ToInt({n}) is " +
                    $"{System.Convert.ToInt32(n)}");
            }

            /* //Banker's Rounding,
            • It always rounds down if the decimal part is less than the midpoint .5.
            • It always rounds up if the decimal part is more than the midpoint .5.
            • It will round up if the decimal part is the midpoint .5 and the non-decimal
                part is odd, but it will round down if the non-decimal part is even.
             */


            //traditional way of rounding 
            foreach (double n in doubles)
            {
                Console.WriteLine(Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)
                                    );
            }

            //Converting into String.
            int number = 12;
            Console.WriteLine(number.ToString());
            bool boolean = true;
            Console.WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            object me = new object();
            Console.WriteLine(me.ToString());



            //Converting from string to datatype.
            int age = int.Parse("27");
            char cc = char.Parse("c");
            double dd = double.Parse("19.5");
            Console.WriteLine(age + "   //age");
            Console.WriteLine(cc + "    //cc");
            Console.WriteLine(dd + "    //dd");

            DateTime birthday = DateTime.Parse("4 July 1980");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");

            //int count = int.Parse("abc");


            //EXCEPTION HANDLING
            //1- tryParse
            //2- try catch

            Console.Write("How many eggs are there? ");
            int count;
            string input = Console.ReadLine();
            //explanation of try parse on short notes
            //1- try parse
            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }


            //try catch
            Console.WriteLine("Before parsing");
            Console.Write("What is your age? ");
            input = Console.ReadLine();
            try
            {
                age = int.Parse(input);
                Console.WriteLine($"You are {age} years old.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"your input format is incorrect. please enter age in numbers only.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"your input format is correct. please enter age from 1 to 99.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }



            //checked keyword
            Console.WriteLine($"int range is from {int.MinValue} to {int.MaxValue}");

            int x = int.MaxValue - 1;
            checked//this keyword will through the exception after the max value is reached
            {
                Console.WriteLine($"Initial value: {x}");
                x++;//max value reached
                Console.WriteLine($"After incrementing: {x}");
                x++;//max value me agr inc kren tou negative  me jaany lag jata hai (agr checked ka keyword na use krty tou)
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");

            }


        }
    }
}

