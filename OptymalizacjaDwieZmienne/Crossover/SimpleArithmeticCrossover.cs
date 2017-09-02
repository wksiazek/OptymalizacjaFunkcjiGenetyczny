using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    //alfa*x1+(1-alfa)x2
    //alfa*x2+(1-alfa)x1
    //pierwszych k genów bez zmian, reszta tak jak wholearithmetic
    class SimpleArithmeticCrossover : ICrossover
    {
        private double alfa;
        public SimpleArithmeticCrossover(double alfa)
        {
            this.alfa = alfa;
        }

        public Population Crossover(List<Individual> listOfIndividual)
        {
            throw new NotImplementedException();
        }
    }
}
