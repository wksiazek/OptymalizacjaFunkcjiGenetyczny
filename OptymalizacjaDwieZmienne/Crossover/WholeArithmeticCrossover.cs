using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class WholeArithmeticCrossover : ICrossover
    {
        //alfa*x1+(1-alfa)x2
        //alfa*x2+(1-alfa)x1
        //dla wszystkich genów
        //alfa z przedziału 0,1
        private double alfa;
        public WholeArithmeticCrossover(double alfa)
        {
            this.alfa = alfa;
        }
        public Population Crossover(List<Individual> listOfIndividual)
        {
            int randomNumber;
            double x1, x2, y1, y2;
            Population newPopulation = new Population();
            List<Individual> newIndividuals = new List<Individual>();

            while(newIndividuals.Count!=Configuration.Size)
            {
                Individual ind1 = listOfIndividual.ElementAt(RandomGenerator.random.Next(0, listOfIndividual.Count));
                Individual ind2 = listOfIndividual.ElementAt(RandomGenerator.random.Next(0, listOfIndividual.Count));
                randomNumber = RandomGenerator.random.Next(0, 100);
                if(randomNumber<Configuration.ProbabilityCrossover)
                {
                    x1=alfa* ind1.X+(1-alfa)* ind2.X;
                    y1 = alfa * ind1.Y + (1 - alfa) * ind2.Y;

                    x2 = alfa * ind2.X + (1 - alfa) * ind1.X;
                    y2 = alfa * ind2.Y + (1 - alfa) * ind1.Y;

                    Individual newInd1 = new Individual(x1, y1);
                    Individual newInd2 = new Individual(x2, y2);

                    newIndividuals.Add(newInd1);
                    newIndividuals.Add(newInd2);
                }
            }
            newPopulation.ListOfIndividual = newIndividuals;
            return newPopulation;
        }
    }
}
