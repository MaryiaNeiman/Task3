using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class LinearEquation: Equation
    {
        public override List<double> Solve(List <double> listOfDouble)
        {
            a = listOfDouble.ElementAt(0);
            b = listOfDouble.ElementAt(1);
            List<double> list = new List<double>();


            if (a != 0)
            {
                double x = -b / a;
                list.Add(x);
            }

            if(a == 0  && b == 0)
            {
                list.Add(Double.PositiveInfinity);
            }
           
            return list;

        }
    }
}
