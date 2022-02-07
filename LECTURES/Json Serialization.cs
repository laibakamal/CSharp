//lec 16
//json serialization

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using static System.Console;
namespace Lecture16
{
    internal class FileManager
    {
    internal static void ManageFiles()
        {
            StreamWriter sw = new StreamWriter()
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // FileManager.ManageFiles();

            Person p = new Person
            {
                Name = "Ali",
                Age = 12,
                Address = new Address
                {
                    City = "Lahore",
                    Country = "Pakistan",
                    ZIP = 54000
                }
            };

            string jsonOutput = JsonSerializer.Serialize(p);
            Console.WriteLine(jsonOutput);
            File.WriteAllText("myfile.txt", jsonOutput);

            string jsonString = File.ReadAllText("myfile.txt");
            Person p2 = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(p2.Name);
        }
    }
}