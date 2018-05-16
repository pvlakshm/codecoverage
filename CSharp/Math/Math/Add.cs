using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// comment..
namespace Math
{
    public class Add
    {
        public int add(int x, int y)
        {
            if (x == 0)
            {
                return y;
            }
            else if (y == 0)
            {
                return x;
            }

            return x + y;
        }

        public long add(long x, long y)
        {
            if (x == 0)
            {
                return y;
            }
            else if (y == 0)
            {
                return x;
            }

            return x + y;
        }

        public float add(float x, float y)
        {
            return x + y;
        }

        public double add(double x, double y)
        {
            return x + y;
        }
    }
}
