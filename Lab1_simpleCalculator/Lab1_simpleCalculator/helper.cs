using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_simpleCalculator
{
    public partial class Helper
    {
        public double add(double op1, double op2)
        {
            return op1 + op2;
        }

        public double minus(double op1, double op2)
        {
            return op1 - op2;
        }

        public double multi(double op1, double op2)
        {
            return op1 * op2;
        }

        public double divide(double op1, double op2)
        {
            if (op2 == 0)
                throw new DivideByZeroException();
            else
                return op1 / op2;
        }
    }
}
