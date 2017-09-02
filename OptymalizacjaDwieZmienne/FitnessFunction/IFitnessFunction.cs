using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.FitnessFunction
{
    interface IFitnessFunction
    {
        string Name { get; set; }
        double ComputeMaximum(double x, double y);
        double ComputeMinimum(double x, double y);
    }
}
