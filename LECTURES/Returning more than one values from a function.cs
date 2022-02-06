//lec 10
//returning more than one values from a function

using System;
namespace Lecture10
{
    public class Person
    {
        public string name;
        public int age;

        public void PrintPersonDetails()
        {
            Console.WriteLine($"Person name is {this.name} and age is {this.age}");
        }

        public string GetPersonName()
        {
            return $"my name is { this.name}";
        }

        //TUPLES
        //1
        //public (string, int) GetPersonDetails()
        //{
        //    return (this.name, this.age);
        //}

        //2
        public (string n, int a) GetPersonDetails()
        {
            return (this.name, this.age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { age = 12, name = "Ali" };
            p.PrintPersonDetails();
            Console.WriteLine(p.GetPersonName());


            //Console.WriteLine("name is "+ p.GetPersonNameAndAge().Text + "and age is "+
            //                  p.GetPersonNameAndAge().Number  );


            //TUPLE
            //1
            //(string, int) personData = p.GetPersonDetails();
            //Console.WriteLine(personData.Item1);//print name
            //Console.WriteLine(personData.Item2);//print age

            //2
            //var personData = p.GetPersonDetails();
            //Console.WriteLine(personData.n);
            //Console.WriteLine(personData.a);

            //3 
            (string n1, int a1) personData = p.GetPersonDetails();
            Console.WriteLine(personData.n1);
            Console.WriteLine(personData.a1);

            //4
            (string n, int a) = p.GetPersonDetails();
            Console.WriteLine(n);
            Console.WriteLine(a);


        }
    }
}

