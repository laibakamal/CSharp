//1- Write a C# Sharp program to swap two numbers.
    
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.Write ("First number: ");
        a=int.Parse(Console.ReadLine());
        Console.Write ("Second number: ");
        b=int.Parse(Console.ReadLine());
        c=a;
        a=b;
        b=c;
        Console.WriteLine("\nAFTER SWAPPING NUMBERS:");
        Console.WriteLine("First Number: "+ a);
        Console.WriteLine("Second Number: "+ b);
    }
}


//2- Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.Write ("First number: ");
        a=int.Parse(Console.ReadLine());
        Console.Write ("Second number: ");
        b=int.Parse(Console.ReadLine());
        Console.Write ("Third number: ");
        c=int.Parse(Console.ReadLine());
        a*=b;
        c*=a;
        Console.WriteLine("The product of these three numbers is: x*y*z: "+ c);
    }
}