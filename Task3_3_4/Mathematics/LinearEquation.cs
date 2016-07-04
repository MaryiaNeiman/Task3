using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class LinearEquation: Equation
    {
        public  List<double> Solve(List <double> listOfDouble)
        {
           
            List<double> list = new List<double>();


            if (listOfDouble.ElementAt(0) != 0)
            {
                double x = -listOfDouble.ElementAt(1) / listOfDouble.ElementAt(0);
                list.Add(x);
            }

            if(listOfDouble.ElementAt(0) == 0  && listOfDouble.ElementAt(1) == 0)
            {
                list.Add(Double.PositiveInfinity);
            }
           
            return list;

        }
    }
}
