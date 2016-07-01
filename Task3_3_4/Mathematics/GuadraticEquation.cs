using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class QuadraticEquation : Equation

    {
        private double c;

        public override List<double> Solve(List<double> listOfDouble)
        {
            a = listOfDouble[0];
            b = listOfDouble[1];
            c = listOfDouble[2];
            double D;
            List<double> list = new List<double>();
            if (a == 0 && b == 0 && c == 0)
            {
                list.Add(Double.PositiveInfinity);
                return list;

            }
           

                if (a == 0)
                {
                    LinearEquation el = new LinearEquation();
                    listOfDouble.Remove(0);
                    list = el.Solve(listOfDouble);
                    return list;


            }

         
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                list.Add((-b + Math.Sqrt(D)) / (2 * a));
                list.Add((-b - Math.Sqrt(D)) / (2 * a));
                

            }
            if (D == 0)
            {
                list.Add((-b + Math.Sqrt(D)) / (2 * a));              
         

            }
            if  (D < 0)
            {
                list.Add(Double.NegativeInfinity);
            }
            return list;

        }
    }
}
