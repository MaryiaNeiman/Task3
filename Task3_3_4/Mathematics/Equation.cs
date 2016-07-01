using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public abstract class Equation
    {
        protected double a;
        protected double b;

        public abstract List <double> Solve(List<double> listOfDouble);

    }
}
