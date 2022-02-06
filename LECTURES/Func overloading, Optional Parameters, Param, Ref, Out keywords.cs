//lec 11
//function overloading
//optional parameters
//param keyword
//ref and out keywords

using System;
namespace Lecture11
{

    public class Person
    {
        public string name;
        public int age;

        //method overloading
        //1
        public void func()
        {
            Console.WriteLine("1");
        }
        //2
        public void func(int a)
        {
            Console.WriteLine("2");
        }
        //3
        public void func(int a, int b)
        {
            Console.WriteLine("3");
        }

        //optional parameters
        public void MyMethod(string name, int val, double dub = 2.5)
        {
            Console.WriteLine();
        }

        //param keyword
        public void TotalMarks(params int[] data)
        {

        }

        //ref out
        public void refOut(int x, ref int y, out int z)
        {
            z = 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Person p = new Person { name = "Ali", age = 12 };

            //calling overloaded funcions
            p.func();
            p.func(1);
            p.func(1, 2);
            p.func(11, 12);



            p.MyMethod("ali", 123, 85.69);
            p.TotalMarks(1);
            p.TotalMarks(1, 3);
            p.TotalMarks(1, 4, 5, 6);
            p.TotalMarks(1, 2, 3, 4, 5, 67, 8, 9);
            p.TotalMarks(1, 2, 3, 4, 5, 67, 8, 9, 23);
            int a = 10;
            int b = 20;

            Console.WriteLine($"before passing a ={a}, b = {b}");


            //1-
            p.refOut(a, ref a, out int c);
            Console.WriteLine($"after passing a ={a}, b = {b}, c={c}");

            //2-
            int cc = 30;
            p.refOut(a, ref a, out cc);
            Console.WriteLine($"after passing a ={a}, b = {b}, c={c}");
        }
    }
}

