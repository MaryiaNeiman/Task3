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
                for (i = 0; i < listOfLines.Count; i++)
                {
                    string[] temp = listOfLines[i].Split(' ');
                    mas[i] = new double[temp.Length];
                    int j = 0;
                    foreach (var item in temp)
                    {
                        mas[i][j] = double.Parse(item);
                        j++;
                    }

                }
                i = 0;
                double[,] arr1 = ReadFromFile(mas, ref i);
                double[,] arr2 = ReadFromFile(mas, ref i);

                listOfArrays.Add(arr1);
                listOfArrays.Add(arr2);
                return listOfArrays;
            }


            catch (Exception e)
            {

                return null;
            }


        }

        private static double[,] ReadFromFile(double[][] mas, ref int i)
        {
            int rows1 = (int)mas[i][0];
            int cols1 = (int)mas[i][1];
            i++;
            double[,] arr = new double[rows1, cols1];
            for (int k = 0; k < rows1; k++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    arr[k, j] = mas[i][j];
                }
                i++;

            }
            return arr;
        }
    }
}
