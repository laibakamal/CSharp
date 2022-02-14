//file handling
//var, dynamic, nullable, array syntax
//foreach loop
//param keyword

using System;
using System.IO;
namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //write data to the file
            int i = 9;
            FileStream fout = new FileStream("MyFile.txt", FileMode.Create);
            fout.WriteByte((byte)i);
            fout.Close();

            //read data from the file
            FileStream f = new FileStream("MyFile.txt", FileMode.Open);
            Console.WriteLine((char)f.ReadByte());
            f.Close();

            //stream reader and stream writer
            FileStream R = new FileStream("MyFile.txt", FileMode.Open);
            FileStream f1 = new FileStream("amna.txt", FileMode.Create);
            StreamReader sr = new StreamReader(R);
            StreamWriter sw = new StreamWriter(f);
            string s = sr.ReadLine();
            while (s != null)
            {
                Console.WriteLine(s);
                sw.WriteLine(s);
                s = sr.ReadLine();
            }
            sr.Close();
            sw.Close();
            R.Close();

            //var vs dynamic
            //var
            var a = 10;
            Console.WriteLine(a);
           // a = "laiba";  //error

            //dynamic
            dynamic j = "laiba";
            j = 10;

            //nullable 
            int? n = null;

            //array syntax
            int[] arr = { 1, 2, 3, 4 };//1
            int[] arrr = new int[5] { 1, 2, 3, 4, 5 };//2

            //foreach loop
            foreach (int k in arr)
            {
                Console.WriteLine(arr[k]);
            }

            //param keyword
            void minVal(params int[] num)
            {
                Console.WriteLine(num[2]);
            }
            minVal(1, 2, 3);
        }
    }
}