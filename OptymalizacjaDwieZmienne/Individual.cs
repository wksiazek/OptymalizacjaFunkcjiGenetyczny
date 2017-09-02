using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OptymalizacjaDwieZmienne
{
    class Individual
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Fitness { get; set; }
        public Individual()
        {
            X = 0;
            Y = 0;
            Fitness = 0;
        }

        public Individual(double x, double y)
        {
            X = x;
            Y = x;
        }

        public Individual(double x1, double x2,double y1,double y2)
        {           
            X = RandomGenerator.random.NextDouble()*(x2-x1)+x1;
            Y = RandomGenerator.random.NextDouble()*(y2 - y1) + y1;
        }
    }
}
