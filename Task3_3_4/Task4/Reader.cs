using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Reader
    {

        public List<double[,]> ParseFile(string path)

        {
            List<double[,]> listOfArrays = new List<double[,]>(); 
            List<string> listOfLines = new List<string>();
            try
            {
                String[] lines = File.ReadAllLines(path);
                listOfLines = new List<string>(lines);
                double[][] mas = new double[listOfLines.Count][];
                int i;
                for (i=0;i< listOfLines.Count;i++)
                {
                    string[] temp = listOfLines[i].Split(' ');
                    mas[i] = new double[temp.Length];
                    int j = 0;
                    foreach(var item in temp)
                    {
                        mas[i][j] = double.Parse(item);
                        j++;
                    }                                 

                }
                
                int rows1 = (int)mas[0][0];
                int cols1 = (int)mas[0][1];
                Console.WriteLine($"rows = {rows1}, cols = {cols1}");
                double[,] arr1 = new double[rows1,cols1];
                for (i=0;i<rows1;i++)
                {
                    for (int j=0;j<cols1;j++)
                    {
                        arr1[i,j] = mas[i + 1][j];
                        Console.Write($"{arr1[i, j]} ");
                    }
                    Console.WriteLine();
                }
                int rows2 = (int)mas[i+1][0];
                int cols2 = (int)mas[i+1][1];
                double[,] arr2 = new double[rows2, cols2];
                Console.WriteLine($"rows2 = {rows2}, cols2 = {cols2}");
                i++;
                for (int k = 0; k < rows2; k++)
                {
                    for (int j = 0; j < cols2; j++)
                    {
                        arr2[k, j] = mas[i + 1][j];
                        Console.Write($"{arr2[k, j]} ");
                    }
                    i++;
                    Console.WriteLine();
                }
                listOfArrays.Add(arr1);
                listOfArrays.Add(arr2);
                return listOfArrays;
            }


                catch (Exception e)
            {
                
                return null;
            }
           
          
        }
    }
}
