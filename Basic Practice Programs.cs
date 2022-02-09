//1- Write a C# Sharp program to swap two numbers.
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Enter two integers to swap them:");
        Console.Write("First integer: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Second integer: ");
        b = int.Parse(Console.ReadLine());
        c = a;
        a = b;
        b = c;
        Console.WriteLine("\nAFTER SWAPPING:");
        Console.WriteLine("First integer: " + a);
        Console.WriteLine("Second integer: " + b);
    }
}


/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/


//2- Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Enter three integers to multiply them: ");
        Console.Write("First integer: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Second integer: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Third integer: ");
        c = int.Parse(Console.ReadLine());
        Console.Write($"\nThe product of these three integers is: {a}*{b}*{c} = ");
        a *= b;
        c *= a;
        Console.Write($"{c}");
    }
}


/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/


//3- Write a C# program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter two integers and get the results of basic mathematical operations on them!");
        Console.Write("First Integer: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Second Integer: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");
    }
}

/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/

//4- Write a C# program that takes a number as input and print its multiplication table.
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a number to print its multiplication table: ");
        num = int.Parse(Console.ReadLine());
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }
}

/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/

//5- Write a C# Sharp program that takes four numbers as input to calculate and print the average.
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int count, sum = 0, avg = 0;
        Console.Write("How many integers you wanna find average of? ");
        count = int.Parse(Console.ReadLine());
        int[] num = new int[count];
        Console.WriteLine($"Enter {count} integers: ");
        for (int i = 0; i < count; i++) 
        {
            num[i] = int.Parse(Console.ReadLine());
            sum += num[i];
        }
        avg = sum / count;
        Console.WriteLine($"The average of all entered numbers is: {avg}");
    }
}

/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/

//6- Write a C#  program that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 
using System;
public class Class1
{
    public static void Main(string [] args)
    {
        int x, y, z, result;
        Console.WriteLine("Enter three numbers:");
        Console.Write("First Number: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("Second Number: ");
        y=int.Parse(Console.ReadLine());
        Console.Write("Third Number: ");
        z =int.Parse(Console.ReadLine());
        result = x + y;
        result *= z;
        Console.WriteLine();
        Console.WriteLine($"(x+y).z = ({x}+{y}).{z} = {result}");
        Console.Write($"x.y + y.z = {x}.{y} + {y}.{z} = ");
        x *= y;
        y *= z;
        result = x + y;
        Console.Write(result);
        Console.WriteLine();
    }
}

/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/
/*--------------------------------------*/

//7- Write a C# program that takes an age (for example 20) as input and prints something as "You look older than 20".
using System;
public class Class1
{
    public static void Main(string[]args)
    {
        int age;
        Console.Write("Enter an integer: ");
        age=int.Parse(Console.ReadLine());
        Console.WriteLine($"You look older than {age}.\n");
    }
}
