
//lec 13
//operator overloading
//local functions


//box.cs

using System;
using System.Collections.Generic;
using System.Text;


//operator overloading
namespace Lecture13
{
    //operator overloading
    class Box
    {

        private double length;
        private double width;
        private double height;

        //getter setters
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public void PrintBoxDetails()
        {
            Console.WriteLine($" length:{length}, width:{width}  height:{height}");
        }


        //without operator overloading
        //takes two boxes as input, add their dimensions and return a new box with thpse dimensions
        public static Box AddBoxes(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.width = b.width + c.width;
            box.height = b.height + c.height;
            return box;
        }//

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.width = b.width + c.width;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height
               && lhs.width == rhs.width)
            {

                status = true;
            }
            return status;
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length != rhs.length || lhs.height != rhs.height ||
               lhs.width != rhs.width)
            {

                status = true;
            }
            return status;
        }


    }
}




//person.cs
//local functions
namespace Lecture13
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            //calling local func
            return $"{Name} is {Age} year{GenerateAgeSuffix(Age)} old";
            // Define a local function:
            string GenerateAgeSuffix(int age)
            {
                return age > 1 ? "s" : "";
            }
        }

        public static void Display(string str)
        {
            int ctr = 5;
            DisplayText();
            //local func
            void DisplayText()
            {
                for (int i = 0; i < ctr; i++)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}




//program.cs

namespace Lecture13
{
    class Program
    {
        static void Main(string[] args)
        {

            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3;   // Declare Box3 of type Box


            // box 1 specification
            Box1.Length = 6.0;
            Box1.Width = 7.0;
            Box1.Height = 5.0;

            // box 2 specification
            Box2.Length = 12.0;
            Box2.Width = 13.0;
            Box2.Height = 10.0;

            // Add two object as follows:
            //1
            //without operator overloading
            Box3 = Box.AddBoxes(Box1, Box2);

            Box1.PrintBoxDetails();
            Box2.PrintBoxDetails();
            Box3.PrintBoxDetails();

            //2
            //with operator overloading
            Box3 = Box1 + Box2;

            Box1.PrintBoxDetails();
            Box2.PrintBoxDetails();
            Box3.PrintBoxDetails();


            if (Box1 != Box2)
            { Console.WriteLine("Box1 is not equal to Box2"); }

            if (Box1 == Box2)
            { Console.WriteLine("Box1 is equal to Box2"); }
            else
            { Console.WriteLine("Box1 is not equal to Box2"); }
            //*/



            Person p = new Person { Name = "Ali", Age = 2 };
            //local functions usage
            Console.WriteLine(p.ToString());
            Person.Display("Shuja");

        }
    }
}