using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter name of folder");
            string nameOfFolder = Console.ReadLine();
            string pathToFolder = Resource1.Path;
            if (CreateFolder(pathToFolder, nameOfFolder))
            {
                Console.WriteLine("Folder was created or exists\nEnter name of file");
                string nameOfFile = Console.ReadLine();
                string pathToTheFile = IsFile(pathToFolder, nameOfFolder, nameOfFile);
                if (pathToTheFile.Equals(""))
                {
                    Console.WriteLine($"File \"{nameOfFile}\" already exists");
                }
                else
                {
                    if (!WriteInFile(pathToTheFile))
                    {
                        Console.WriteLine("Bug with file!!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Name of folder is incorrectly");
            }


            Console.ReadLine();
        }


        public static Boolean CreateFolder(String path, String name)
        {

            String a = path + name;
            try
            {
                if (!Directory.Exists(a))
                {
                    string pathString = Path.Combine(path, name);
                    Directory.CreateDirectory(pathString);
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (ArgumentException)
            {
                return false;
            }

        }

        public static String IsFile(String path, String name, String nameOfFile)
        {
            if (name == "")
            {
                name = "New Text Document";
            }
            string pathString = Path.Combine(path, name);
            string allPath = Path.Combine(pathString, nameOfFile) + ".txt";

            if (!File.Exists(allPath))
            {
                return allPath;
            }
            else
            {

                return "";
            }

        }

        public static Boolean WriteInFile(String path)
        {
            try
            {
               
                using (StreamWriter file = new StreamWriter(path))
                {
                    StreamReader file2 = new StreamReader(Resource1.PathToFile);
                    string line;
                    int counter = 0;
                    while ((line = file2.ReadLine()) != null && counter < 20)
                    {
                        file.WriteLine(line);
                        counter++;
                    }
                }
                return true;
            }


            catch (Exception)
            {
                return false;
            }


        }
    }
}
