//lec 9
//static 
//const
//readonly
//obj initializer syntax

using System;
namespace Lecture9
{
    public class Person
    {
        public string name;
        public int age;
        //STATIC DATA MEMBER
        public static string country = "Pakistan";//sary objects k liye same hoga       //accessed through classname
        public const string homePlanet = "Earth";//kabhi bhi change nahi hoga // it is static by default        //accessed through classname
        public readonly string homePlanet2;//accessed through objects

        public Person()
        {
            name = "";
            age = default;
            homePlanet2 = "Moon";
        }
        public Person(string name, int age, string hp2)
        {
            this.name = name;
            this.age = age;
            this.homePlanet2 = hp2;
        }

        //compile time pe evaluate hota hai const
        //example
        public void Calculate(int z)
        {
            const int x = 10, y = 20;
            const int a = x + y;//ok because x and y are known o compile time
            //const int b = x + z;              //error     //because z is not known on compile time
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //INITIALIZING OBJECTS
            //1- default constructor
            Person p = new Person();
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            //2- param constructor
            Person p1 = new Person("ali", 12, "Moon");
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            //3- object initializer syntax
            Person p2 = new Person { name = "ahmad", age = 15 };
            Person p3 = new Person { age = 15, name = "laiba" };
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);


            //STATIC DATA MEMBER
            Console.WriteLine(Person.country);
            //constant DATA MEMBER
            Console.WriteLine(Person.homePlanet);

            //SETTING DATA MEMBERS
            Person.country = "India";
            p1.name = "laiba";

            Console.WriteLine(Person.homePlanet);
            Console.WriteLine(p.homePlanet2);
            //p.homePlanet2 = "Mars";       //error



            //readonly is diffreent for different objects
            Person p10 = new Person("nimra", 20, "earth");
            Person p11 = new Person("komal", 21, "eathhh");
            Console.WriteLine(p10.homePlanet2);
            Console.WriteLine(p11.homePlanet2);
        }
    }
}

