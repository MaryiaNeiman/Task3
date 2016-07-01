using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Mathematics;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double[,]> listOfArrays = new List<double[,]>();
            Reader r = new Reader();
            listOfArrays = r.ParseFile(ConfigurationManager.AppSettings["Path"]);
            if (listOfArrays == null)
            {
                Console.WriteLine("Incorrect file");
                Console.ReadLine();
                return;
            }
            double[,] result = Matrix.Multiplication(listOfArrays[0], listOfArrays[1]);
            if(result == null)
            {
                Console.WriteLine("Matrices can't be multiplied.");

            }
            else
            {
               
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        Console.Write($"{result[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
