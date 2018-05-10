using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Sub
    {
        public int sub(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }

            return x - y; // Added a comment to this line.
        }

        public long sub(long x, long y)
        {
            if (y == 0)
            {
                return x;
            }

            return x - y;
        }

        public float sub(float x, float y)
        {
            if (y == 0.0f)
            {
                return x;
            }

            return x - y;
        }

        public double sub(double x, double y)
        {
            if (y == 0.0)
            {
                return x;
            }

            return x - y;
        }
    }
}
