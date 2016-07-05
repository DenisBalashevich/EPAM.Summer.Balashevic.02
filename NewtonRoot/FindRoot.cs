using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonRootSpace
{
    public class FindRoot
    {
        public static double NewtonRoot(int n, int deg, double eps = 1e-15)
        {
            if (n == 0)
                return 0;

            if (n < 0 && deg % 2 == 0)
                throw new ArgumentException("Number must be positive");

            if (eps > 1 || eps < 0)
                throw new ArgumentException("Epsilon must be less than 1 and more than 0");

            if (deg < 1 )
                throw new ArgumentException("Degree must be positive");

            double xn = 1, xm = 1;
            while (true)
            {
                xn = 1.0 / deg * ((deg - 1) * xn + n / Math.Pow(xn, deg - 1));
                if (Math.Abs(xn - xm) < eps)
                    return xn;
                else
                {
                    xm = xn;
                    continue;
                }
            }
        }
    }
}
