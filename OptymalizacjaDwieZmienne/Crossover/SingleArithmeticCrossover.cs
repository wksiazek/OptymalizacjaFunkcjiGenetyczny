using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class SingleArithmeticCrossover : ICrossover
    {
        //alfa*x1+(1-alfa)x2
        //alfa*x2+(1-alfa)x1
        //dla wybranego genu
        private double alfa;
        public SingleArithmeticCrossover(double alfa)
        {
            this.alfa = alfa;
        }
        public Population Crossover(List<Individual> listOfIndividual)
        {
            throw new NotImplementedException();
        }
    }
}
