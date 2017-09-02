using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.FitnessFunction
{
    class Function1 : IFitnessFunction
    {
        public string Name { get; set; } = "21.5 + x * Math.Sin(4.0 * Math.PI * x) + y * Math.Sin(20.0 * Math.PI * y);";
        public double ComputeMaximum(double x, double y)
        {
            return 21.5 + x * Math.Sin(4.0 * Math.PI * x) + y * Math.Sin(20.0 * Math.PI * y);
        }

        public double ComputeMinimum(double x, double y)
        {
            return -ComputeMaximum(x, y);
        }
    }
}
