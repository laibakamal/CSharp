//lec 3
//object, dynamic, var
//arrays
//string concatenation

using System;

namespace EAD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //object type
            //This is a special type which can store any type of data
            //compile time pe type check hojati hai.
            object mydata = 12;//int
            object myseconddata = "this is my string";//float
            object anotherdata = 23.45;//float
            string mystring = "this is another string";

            //disadvantage of object data type
            //jesy agr ek objecy type ka var bna k hum ne us me string rkhi hai tou usy dtring wali properties jese string.Length nahi de sken gy hum direct. agr hum ne iays properties ko use krna hai us object var k liye tou us k liye hume (string) kr k typecasting krni pre gi
            //code ki readibility kharab
            //performance kharab (ku k baar baar typecast krna prta hai
            //)//object dataype ko  jitna avoid kr skty, kren

            int lengthofstring = mystring.Length;
            // int lengthofmyanotherstring = (myseconddata).Length;//error
            int lengthofmyanotherstring = ((string)myseconddata).Length;



            //dynamic
            //ye bhi object ki trhan hai
            //bas is me type runtime pe check hoti hai
            dynamic myAnotherString = "this is some other string";
            int lengthofMyThirdString = myAnotherString.Length;//kis ne error nahi dia ku k type runtime pe check honi
            Console.WriteLine(lengthofMyThirdString);

            //var
            //jahan dataype waziya ho bas waha use krty hein var ko
            //define krty huye jo value assign kr dete hain, us k hisaab se datatype assign hojati hai var ko
            var x = "this is something.";
            var y = 234;
            //var z = RunMyFunction();//code readibility kharab hojati hai, isliye aisi jaga pe use nahi krna var


            //underscores
            int population = 66_000_000; //66 Million


            //default values
            Console.WriteLine(default(int));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(string));
            Console.WriteLine(default(decimal));

            //arrays
            string[] names;
            names = new string[4];

            names[0] = "shuja";
            names[1] = "baig";
            names[2] = "alishba";
            names[3] = "ibrahim";

            Console.WriteLine(names[3]);

            //take input from user
            Console.WriteLine("Enter Age:");
            string age = Console.ReadLine();

            Console.WriteLine("you entered:  " + age);



        }
    }
}


