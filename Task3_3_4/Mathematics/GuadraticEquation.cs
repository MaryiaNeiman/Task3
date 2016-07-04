using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class QuadraticEquation : Equation

    {
       

        public  List<double> Solve(List<double> listOfDouble)
        {
           
            double D;
            List<double> list = new List<double>();
            if (listOfDouble[0] == 0 && listOfDouble[1] == 0 && listOfDouble[2] == 0)
            {
                list.Add(Double.PositiveInfinity);
                return list;

            }
           

                if (listOfDouble[0] == 0)
                {
                    LinearEquation el = new LinearEquation();
                    listOfDouble.Remove(0);
                    list = el.Solve(listOfDouble);
                    return list;


            }

         
            D = Math.Pow(listOfDouble[1], 2) - 4 * listOfDouble[0] * listOfDouble[2];
            if (D > 0)
            {
                list.Add((-listOfDouble[1] + Math.Sqrt(D)) / (2 * listOfDouble[0]));
                list.Add((-listOfDouble[1] - Math.Sqrt(D)) / (2 * listOfDouble[0]));
                

            }
            if (D == 0)
            {
                list.Add((-listOfDouble[1] + Math.Sqrt(D)) / (2 * listOfDouble[0]));              
         

            }
            if  (D < 0)
            {
                list.Add(Double.NegativeInfinity);
            }
            return list;

        }
    }
}
