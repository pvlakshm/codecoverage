using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Div
    {
        public int div(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException();

            return x / y;
        }

        public long div (long x, long y)
        {
            return x / y;
        }

        public float div(float x, float y)
        {
            return x / y;
        }

        public double div(double x, double y)
        {
            return x / y;
        }
    }
}
