using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class RandomGenerator
    {
        public static Random random = new Random();
        public static double RandomDouble (double x1, double x2)
        {
            return RandomGenerator.random.NextDouble() * (x2 - x1) + x1;
        }
    }
}
