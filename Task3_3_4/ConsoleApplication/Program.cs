using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log();
            if (log.CheckIsLogFileExist())
            {

                Display();
            }
            else
            {
                Console.WriteLine("Log file is absent");
            }
            Console.ReadLine();
                
        }
        public static void Display()
        {
            while (true)
            {
                string key;
                printmenu();
                key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                       
                        List<double> list = new List <double>();
                        list = InputParameterLE();
                        LinearEquation le = new LinearEquation();
                        Console.WriteLine(MakeResultLE(le.Solve(list), list));                        
                        Console.ReadLine();
                        break;
                    case "2":
                        List<double> listQE = new List<double>();
                        list = InputParameterQE();
                        QuadraticEquation qe = new QuadraticEquation();
                        Console.WriteLine(MakeResultQE(qe.Solve(list), list));
                        Console.ReadLine();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:

                     break;
                }
                Console.Clear();

            }
        }
        public static void printmenu()
        {
            Console.WriteLine("Enter '1' to solve the linear equation");
            Console.WriteLine("Enter '2' to to solve a quadratic equation");
            Console.WriteLine("Enter '3' to exit");
        }
        public static List<double> InputParameterLE()
        {
            List<string> listOfString = new List<string>();
            List<double> listOfDouble = new List<double>();
            String sep = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            double num;
            int flag = 0;
            String[] mark = { ".", "," };
            while (listOfDouble.Count != 2)
            {
            if(flag !=0 )
                {
                    foreach (var item in listOfDouble)
                    {
                        Log.WriteInFile($"It isn't correct parameter: {item}");
                    }
                }
                Console.Clear();
                Console.WriteLine("Enter A:");
                listOfString.Add(Console.ReadLine());
                Console.WriteLine("Enter B:");
                listOfString.Add(Console.ReadLine());

                foreach (var item in listOfString)
                {
                    if (mark[0].Equals(sep))
                    {
                        if (AddDouble(sep, mark[0], mark[1], item) != Double.PositiveInfinity)
                        {
                            listOfDouble.Add(AddDouble(sep, mark[0], mark[1], item));
                        }
                    }
                    else
                    {

                        if (AddDouble(sep, mark[1], mark[0], item) != Double.PositiveInfinity)
                        {
                            listOfDouble.Add(AddDouble(sep, mark[1], mark[0], item));
                        }
                    }
                }
                flag++;
            }
            return listOfDouble;

        }
        public static double AddDouble(string sep, string mark1, string mark2, string item)
        {
            double num;
            if (item.Contains(mark1))
            {
                if (Double.TryParse(item, out num))
                {
                    return num;
                }

            }
            else
            {

                var tempitem = item.Replace(mark2, mark1);

                if (Double.TryParse(tempitem, out num))
                {
                    return num;
                }


            }
            return Double.PositiveInfinity;
        }

        public static string MakeResultLE(List<double>list, List<double> listOfParameters)
        {
            string massage="";
            if (list.Count == 0)
            {

                Log.WriteInFile("Error A = 0 X equation doesn't have roots");
                massage = "Equation doesn't have roots";
            }
            else
            {
                if (list[0] == Double.PositiveInfinity)
                {
                    Log.WriteInFile($"X takes any value, A = {listOfParameters[0]} B =  {listOfParameters[1]} ");
                    massage = "X takes any value";
                }
                else
                {
                  
                  Log.WriteInFile($" A = {listOfParameters[0]} B =  {listOfParameters[1]} Result: X=  {list[0]}");
                  massage = "Result: X= " + list[0].ToString("0.00");

                  
                }
            }

            return massage;

        }

        public static List<double> InputParameterQE()
        {
            List<string> listOfString = new List<string>();
            List<double> listOfDouble = new List<double>();
            String sep = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            double num;
            String[] mark = { ".", "," };
            while (listOfDouble.Count !=3)
            {
                Console.Clear();
                Console.WriteLine("Enter A:");
                listOfString.Add(Console.ReadLine());
                Console.WriteLine("Enter B:");
                listOfString.Add(Console.ReadLine());
                Console.WriteLine("Enter C:");
                listOfString.Add(Console.ReadLine());
                foreach (var item in listOfString)
                {
                    if (mark[0].Equals(sep))
                    {
                        if (AddDouble(sep, mark[0], mark[1], item) != Double.PositiveInfinity)
                        {
                            listOfDouble.Add(AddDouble(sep, mark[0], mark[1], item));
                        }
                    }
                    else
                    {

                        if (AddDouble(sep, mark[1], mark[0], item) != Double.PositiveInfinity)
                        {
                            listOfDouble.Add(AddDouble(sep, mark[1], mark[0], item));
                        }
                    }
                }
            }
            return listOfDouble;

        }
        public static string MakeResultQE(List<double> list,List<double> listOfParameters)
        {
            string massage = "";
            if (list.Count == 0)
            {
                massage = "No solutions";
                Log.WriteInFile("Error A = 0 B = 0 X equation doesn't have roots");
            }
            else
            {
                if (list[0] == Double.PositiveInfinity)
                {
                    massage = "X takes any value";
                    Log.WriteInFile("A = 0 B = 0 C = 0 X takes any value");
                }

                if (list[0] == Double.NegativeInfinity)
                {
                    Log.WriteInFile($"D < 0 This equation dosen't has solution A = {listOfParameters[0]} B = {listOfParameters[1]} C = {listOfParameters[2]} ");
                    massage = "This equation hasen't solution";
                }

                else
                {
                    Log.WriteInFile($"A = {listOfParameters[0]} B = {listOfParameters[1]} C = {listOfParameters[2]}");
                    foreach (var item in list)
                    {
                        Log.WriteInFile($"Result: X= {item}");
                        massage += " Result: X= " + item.ToString("0.00")+"\n";
                    }
                }
            }

            return massage;

        }
    }
}
