using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.FitnessFunction
{
    class Function2 : IFitnessFunction
    {
        public string Name { get; set; } = "Math.Pow(x + 2.0 * y - 7.0, 2.0) + Math.Pow(2.0 * x + y - 5.0, 2.0);";
        public double ComputeMaximum(double x, double y)
        {
            return Math.Pow(x + 2.0 * y - 7.0, 2.0) + Math.Pow(2.0 * x + y - 5.0, 2.0);
        }

        public double ComputeMinimum(double x, double y)
        {
            return -ComputeMaximum(x, y);
        }
    }
}
