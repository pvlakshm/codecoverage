using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Mult
    {
        public int mult(int x, int y)
        {
            return x * y; // Added a comment to this line.
        }

        public long mult(long x, long y)
        {
            return x * y;
        }

        public float mult(float x, float y)
        {
            return x * y;
        }

        public double mult(double x, double y)
        {
            return x * y;
        }

        public int multBasedBusinessLogic(int x, int y)
        {
            switch (y)
            {
                case 1:
                    return x;
                case 2:
                    return x + x;
                case 3:
                    // we do not have a test case to test for this.
                    // this is an extremely rare scenario that cannot be replicated
                    // unless we simultaneously take down the dB and disconnect the
                    // feeders ... (basically some valid justification for not having
                    // a test case for this branch.

                    throw new Exception();
                default:
                    return x * y;
            }
        }
    }
}
